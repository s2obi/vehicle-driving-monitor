using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kvaser.CanLib;

namespace vehicle_driving_monitor
{
    public partial class Form_Main : Form
    {
        /* ECU 메시지 ID 정의 */
        public const int SAS11 = 688;
        public const int TCU1 = 1087;
        public const int EngFrzFrm1 = 160;
        public const int EngFrzFrm2 = 161;
        public const int EMS_H12 = 399;
        public const int EMS5 = 672;
        public const int EMS12 = 809;
        public const int EMS14 = 1349;
        public const int ESP12 = 544;

        /* Kvaser CanLib 관련 변수 정의 */
        public int canlib_handle;       // CAN channel 관리
        public Canlib.canStatus status; // CanLib 함수 결과 저장

        /* CAN 통신 설정 관련 변수 */
        public int channelNumber = 0;   // CAN 채널 번호
        public int bitrate = 0;         // CAN 통신 속도 설정

        Thread t_monitor;               // CAN 통신 모니터링 수행하는 스레드

        public Form_Main()
        {
            InitializeComponent();
            Canlib.canInitializeLibrary();
            this.MaximizeBox = false;

            /* ComboBox 리스트 업데이트 */
            channelRefresh();
            comboBox_Bitrate.Items.Add("1000 kbit/s");
            comboBox_Bitrate.Items.Add("500 kbit/s");
            comboBox_Bitrate.Items.Add("250 kbit/s");
            comboBox_Bitrate.Items.Add("125 kbit/s");
            comboBox_Bitrate.SelectedIndex = 1;

            /* accel, brake progressbar 색상 변경 */
            modifyProgressBar.SetState(progBar_accel, 3);
            modifyProgressBar.SetState(progBar_brake, 2);
        }

        /* Main 폼에 스티어링 이미지 출력 */
        int en1 = 125, boy1 = 450, koordinatX1 = 150, koordinatY1 = 150;
        float steering_angle = 0.0f;
        Bitmap image = Properties.Resources.steering;
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            Matrix matrix = new Matrix();
            g = e.Graphics;
            g.RotateTransform(steering_angle, MatrixOrder.Append);
            g.TranslateTransform(en1, boy1, MatrixOrder.Append);
            g.DrawImage(image, -koordinatX1 / 2, -koordinatY1 / 2, koordinatX1, koordinatY1);
            e.Graphics.ResetTransform();
        }

        /* 사용 가능한 CAN 채널 리스트 업데이트 */
        public void channelRefresh()
        {
            comboBox_Channel.Items.Clear();
            int numOfChannel;
            status = Canlib.canGetNumberOfChannels(out numOfChannel);
            if (CheckStatus(status, "canGetNumberOfChannels"))
            {
                for (int i = 0; i < numOfChannel; i++)
                {
                    Object s;
                    Canlib.canGetChannelData(i, Canlib.canCHANNELDATA_CHANNEL_NAME, out s);
                    if (s != null) { comboBox_Channel.Items.Add(s); }
                }
                if (numOfChannel != 0) { comboBox_Channel.SelectedIndex = 0; }
            }
        }

        /* Canlib 상태 체크, 에러 발생 시 메시지 출력 */
        private Boolean CheckStatus(Canlib.canStatus status, string method)
        {
            if (status < 0)
            {
                MessageBox.Show(method + " failed: " + status.ToString());
            }
            return (status == Canlib.canStatus.canOK) ? true : false;
        }

        /* Refresh 버튼 클릭 이벤트 - Channel 업데이트 */
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            channelRefresh();
        }

        private void start_failed()
        {
            btn_start_stop.Text = "Start";
            comboBox_Channel.Enabled = true;
            comboBox_Bitrate.Enabled = true;
            btn_refresh.Enabled = true;
        }

        private void start_monitoring()
        {
            /* Channel Open */
            canlib_handle = Canlib.canOpenChannel(channelNumber, Canlib.canOPEN_ACCEPT_VIRTUAL);
            if (!CheckStatus((Canlib.canStatus)canlib_handle, "canOpenChannel"))
            {
                start_failed();
                return;
            }
            /* CAN 통신 설정 (bitrate, tseg1, tseg2, sjw) */
            switch (bitrate)
            {
                case 0:
                    /* Sample Point 75% 설정 (Tseg1=5, Tseg2=2, SJW=2) */
                    status = Canlib.canSetBusParams(canlib_handle, Canlib.canBITRATE_1M, 0, 0, 0, 0);
                    break;
                case 1:
                    /* Sample Point 75% 설정 (Tseg1=11, Tseg2=4, SJW=4) */
                    status = Canlib.canSetBusParams(canlib_handle, Canlib.canBITRATE_500K, 11, 4, 4, 0);
                    break;
                case 2:
                    /* Sample Point 75% 설정 (Tseg1=11, Tseg2=4, SJW=4) */
                    status = Canlib.canSetBusParams(canlib_handle, Canlib.canBITRATE_250K, 0, 0, 0, 0);
                    break;
                case 3:
                    /* Sample Point 75% 설정 (Tseg1=11, Tseg2=4, SJW=4) */
                    status = Canlib.canSetBusParams(canlib_handle, Canlib.canBITRATE_125K, 0, 0, 0, 0);
                    break;
            }
            if (!CheckStatus(status, "canSetBusParams"))
            {
                start_failed();
                return;
            }
            status = Canlib.canBusOn(canlib_handle);
            if (!CheckStatus(status, "canBusOn"))
            {
                start_failed();
                return;
            }
            t_monitor = new Thread(DumpMessageLoop);
            t_monitor.Start();
        }

        private void stop_monitoring()
        {
            t_monitor.Abort();
            status = Canlib.canBusOff(canlib_handle);
            CheckStatus(status, "canBusOff");
            status = Canlib.canClose(canlib_handle);
            CheckStatus(status, "canClose");
        }

        /* CAN 통신 시작,정지 */
        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            String btn_name = btn_start_stop.Text;
            if (btn_name == "Start")
            {
                btn_start_stop.Text = "Stop";
                comboBox_Channel.Enabled = false;
                comboBox_Bitrate.Enabled = false;
                btn_refresh.Enabled = false;
                textBox_can_output.Clear();
                start_monitoring();
            }
            else // Stop Monitoring
            {
                btn_start_stop.Text = "Start";
                comboBox_Channel.Enabled = true;
                comboBox_Bitrate.Enabled = true;
                btn_refresh.Enabled = true;
                stop_monitoring();
            }
        }

        private void DumpMessageLoop()
        {
            byte[] data = new byte[8]; // 수신 데이터 8byte
            int id;                    // 수신 데이터 ID
            int dlc;                   // CAN data byte 길이
            int flags;                 // 수신 flag
            long timestamp;            // 수신 timestamp
            //textBox_can_output.AppendText("Channel opened.\r\n");
            //textBox_can_output.AppendText("ID  DLC DATA                     Timestamp\r\n");
            while (true)
            {
                status = Canlib.canReadWait((int)canlib_handle, out id, data, out dlc, out flags, out timestamp, 0);
                if (status == Canlib.canStatus.canOK)
                {
                    //DumpMessage(id, data, dlc, flags, timestamp);
                    GetSignal(id, data, dlc, flags);
                }
                else if (status != Canlib.canStatus.canERR_NOMSG)
                {
                    CheckStatus(status, "canReadWait");
                }
            }
        }

        private void comboBox_Channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            channelNumber = comboBox_Channel.SelectedIndex;
        }

        private void comboBox_Bitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitrate = comboBox_Bitrate.SelectedIndex;
        }

        int cnt = 3; // reduce rotate steering image delay
        float prev_angle = 0;
        private void GetSignal(int id, byte[] data, int dlc, int flags)
        {
            int i_scale = 0, i_offset = 0;
            float f_scale = 0.0f, f_offset = 0.0f;

            if ((flags & Canlib.canMSG_ERROR_FRAME) != 0)
            {
                textBox_can_output.AppendText("Error Frame received ****");
            }
            else if (id == SAS11)
            {
                /* SAS_Angle calculate */
                f_scale = 0.1f;
                f_offset = 0.0f;
                Int16 angle_val = (Int16)((data[1] << 8) + data[0]);
                float SAS_Angle = 0;
                if (angle_val >> 15 == 1) // 음수인 경우 계산
                {
                    angle_val = (Int16)(~angle_val + 1);
                }
                SAS_Angle = (float)(f_offset + f_scale * angle_val);
                SAS_Angle = -SAS_Angle;
                label_steering_angle.Text = SAS_Angle.ToString();
                steering_angle = SAS_Angle;
                if (prev_angle != SAS_Angle)
                {
                    if (cnt == 3)
                    {
                        Invalidate();
                        cnt = 0;
                    }
                    cnt++;
                    //Thread t_form_refresh = new Thread(Invalidate);
                    //t_form_refresh.Start();
                }
                prev_angle = SAS_Angle;

                /* SAS_Speed calculate */
                f_scale = 4.0f;
                f_offset = 0.0f;
                byte sas_speed_val = data[2];
                byte SAS_Speed = 0;
                SAS_Speed = (byte)(f_offset + f_scale * sas_speed_val);
                label_steering_speed.Text = SAS_Speed.ToString();
            }
            else if (id == TCU1)
            {
                /* CUR_GR: current transmission position */
                int scale = 1;
                int offset = 0;
                byte gr_val = (byte)(data[1] & 0x0F);
                byte CUR_GR = (byte)(offset + scale * gr_val);
                switch (CUR_GR)
                {
                    case 0:
                        label_current_gear.Text = "P";
                        break;
                    case 7:
                        label_current_gear.Text = "R";
                        break;
                    case 6:
                        label_current_gear.Text = "N";
                        break;
                    case 5:
                        label_current_gear.Text = "D";
                        break;
                    case 3:
                        label_current_gear.Text = "3";
                        break;
                    case 2:
                        label_current_gear.Text = "2";
                        break;
                    case 1:
                        label_current_gear.Text = "1";
                        break;
                }
            }
            else if (id == EngFrzFrm1)
            {
                /* PID_05h: Engine Coolant Temperature */
                i_scale = 1;
                i_offset = -40;
                byte pid_05h_val = data[1];
                float PID_05h = (byte)(i_offset + i_scale * pid_05h_val);
                label_eng_coolant_temp.Text = "Engine Coolant Temperature(°C): " + String.Format("{0:0.00}", PID_05h);

                /* PID_0Ch: Engine RPM */
                f_scale = 0.25f;
                i_offset = 0;
                UInt16 PID_0Ch = (UInt16)((data[3] << 8) + data[2]);
                PID_0Ch = (UInt16)(i_offset + Math.Truncate(f_scale * PID_0Ch));
                label_rpm.Text = PID_0Ch.ToString() + " RPM";

                /* PID_0Dh: Vehicle Speed */
                i_scale = 1;
                i_offset = 0;
                byte PID_0Dh = data[4];
                PID_0Dh = (byte)(i_offset + i_scale * PID_0Dh);
                label_vehicle_speed.Text = PID_0Dh.ToString() + " km/h";
            }
            else if (id == EngFrzFrm2)
            {
                /* PID_0Bh: Engine Manifold Pressure */
                i_scale = 1;
                i_offset = 0;
                byte PID_0Bh = data[4];
                PID_0Bh = (byte)(i_offset + i_scale * PID_0Bh);
                label_eng_manifold_pressure.Text = "Engine Manifold Pressure(kPa): " + PID_0Bh.ToString();
            }
            else if (id == EMS_H12)
            {
                /* R_PAcnC: Air conditioning pressure */
                f_scale = 125.0f;
                f_offset = 0.0f;
                byte val = data[1];
                float R_PAcnC = (float)(f_offset + f_scale * val);
                label_air_conditioning_pressure.Text = "Air Conditioning Pressure(hPa): " + R_PAcnC.ToString();
            }
            else if (id == EMS5)
            {
                /* IntAirTemp: Intake Air Temperature */
                f_scale = 0.75f;
                i_offset = -48;
                byte val = data[2];
                float IntAirTemp = (float)(i_offset + f_scale * val);
                label_air_temp.Text = "Intake Air Temperature(°C): " + String.Format("{0:0.00}", IntAirTemp);
            }
            else if (id == EMS12)
            {
                /* TEMP_ENG: Engine Temperature */
                f_scale = 0.75f;
                f_offset = -48.0f;
                byte val = data[1];
                float TEMP_ENG = (float)(f_offset + f_scale * val);
                label_eng_temp.Text = "Engine Temperature(°C): " + String.Format("{0:0.00}", TEMP_ENG);

                /* BRAKE_ACT: Brake Activate - 1: 안밟음 2: 밟음, 2값 확인 안됨 */
                f_scale = 1.0f;
                f_offset = 0.0f;
                byte brake_val = (byte)((data[4] & 0x03));
                byte BRAKE_ACT = (byte)(f_offset + f_scale * brake_val);
                if (BRAKE_ACT == 1)
                {
                    label_brake.Text = "Brake Off";
                    label_brake.ForeColor = Color.Black;
                }
                else if (BRAKE_ACT == 2)
                {
                    label_brake.Text = "Brake On";
                    label_brake.ForeColor = Color.Red;
                }

                /* ENG_CHR: Engine Type */
                f_scale = 1.0f;
                f_offset = 0.0f;
                byte engChr_val = (byte)((data[4] & 0x3C) >> 2);
                byte ENG_CHR = (byte)(f_offset + f_scale * engChr_val);
                String type = "";
                if (ENG_CHR == 0 || ENG_CHR == 4)       { type = "Gasoline"; }
                else if (ENG_CHR == 1 || ENG_CHR == 5)  { type = "LPI"; }
                else                                    { type = "Diesel"; }
                label_eng_char.Text = "Engine Characteristic: " + type;

                /* PV_AV_CAN: Accel Pedal Position */
                f_scale = 0.3906f;
                i_offset = 0;
                byte pv_av_can_val = data[6];
                float PV_AV_CAN = (float)(i_offset + f_scale * pv_av_can_val);
                label_throttle_position.Text = "Throttle Position(%): " + PV_AV_CAN.ToString();
                progBar_accel.Value = (int)PV_AV_CAN;
            }
            else if (id == EMS14)
            {
                /* AMP_CAN: Atmospheric Pressure */
                f_scale = 10.731613f;
                f_offset = 458.98f;
                byte amp_val = (byte)(data[0] >> 3);
                float AMP_CAN = (float)(f_offset + f_scale * amp_val);
                label_atmo_pressure.Text = "Atmospheric Pressure(mmHg): " + AMP_CAN.ToString();

                /* VB: Voltage of Battery */
                f_scale = 0.1015625f;
                f_offset = 0.0f;
                byte vb_val = data[3];
                float VB = (float)(f_offset + f_scale * vb_val);
                label_voltage.Text = "Votage of Battery(V): " + VB.ToString();
            }
            else if (id == ESP12)
            {
                /* CYL_PRES: Brake Pedal Position */
                f_scale = 0.1f;
                i_offset = 0;
                UInt16 cyl_pres_val = (UInt16)(((data[5] & 0x0F) << 8) | data[4]);
                float CYL_PRES = (float)(i_offset + f_scale * cyl_pres_val);
                label_brake_pos.Text = "Brake Position(Bar): " + String.Format("{0:0.00}", CYL_PRES);
                progBar_brake.Value = ((int)CYL_PRES > 100) ? 100 : (int)CYL_PRES;
            }
        }

        /* CAN 메시지 출력 */
        private void DumpMessage(int id, byte[] data, int dlc, int flags, long timestamp)
        {
            if ((flags & Canlib.canMSG_ERROR_FRAME) != 0)
            {
                textBox_can_output.AppendText("Error Frame received ****");
            }
            else
            {
                if (id == SAS11 || id == TCU1 || id == EngFrzFrm1 || id == EngFrzFrm2 || id == EMS_H12 || id == EMS5 || id == EMS12 || id == EMS14)
                {
                    String s = string.Format("{0:X3}  {1:X2}  {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2} {8:X2} {9:X2}    {10}\r\n",
                    id, dlc, data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], timestamp);
                    textBox_can_output.AppendText(s);
                }
            }
        }

        /* 폼 종료 전 남아있는 스레드 종료 */
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t_monitor != null && t_monitor.IsAlive)
            {
                t_monitor.Abort();
            }
        }
    }
}
