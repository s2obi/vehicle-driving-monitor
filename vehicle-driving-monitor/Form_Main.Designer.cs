
namespace vehicle_driving_monitor
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.comboBox_Bitrate = new System.Windows.Forms.ComboBox();
            this.comboBox_Channel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_vehicle_speed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_current_gear = new System.Windows.Forms.Label();
            this.label_rpm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_eng_char = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_eng_manifold_pressure = new System.Windows.Forms.Label();
            this.label_eng_coolant_temp = new System.Windows.Forms.Label();
            this.label_eng_temp = new System.Windows.Forms.Label();
            this.label_throttle_position = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_brake = new System.Windows.Forms.Label();
            this.label_voltage = new System.Windows.Forms.Label();
            this.label_atmo_pressure = new System.Windows.Forms.Label();
            this.label_air_temp = new System.Windows.Forms.Label();
            this.label_air_conditioning_pressure = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_steering_angle = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_steering_speed = new System.Windows.Forms.Label();
            this.textBox_can_output = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_brake_pos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start_stop);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.comboBox_Bitrate);
            this.groupBox1.Controls.Add(this.comboBox_Channel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAN Configuration";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(279, 47);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_start_stop.TabIndex = 5;
            this.btn_start_stop.Text = "Start";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(279, 18);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // comboBox_Bitrate
            // 
            this.comboBox_Bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bitrate.FormattingEnabled = true;
            this.comboBox_Bitrate.Location = new System.Drawing.Point(79, 47);
            this.comboBox_Bitrate.Name = "comboBox_Bitrate";
            this.comboBox_Bitrate.Size = new System.Drawing.Size(194, 20);
            this.comboBox_Bitrate.TabIndex = 3;
            this.comboBox_Bitrate.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bitrate_SelectedIndexChanged);
            // 
            // comboBox_Channel
            // 
            this.comboBox_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Channel.FormattingEnabled = true;
            this.comboBox_Channel.Location = new System.Drawing.Point(79, 20);
            this.comboBox_Channel.Name = "comboBox_Channel";
            this.comboBox_Channel.Size = new System.Drawing.Size(194, 20);
            this.comboBox_Channel.TabIndex = 2;
            this.comboBox_Channel.SelectedIndexChanged += new System.EventHandler(this.comboBox_Channel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_brake_pos);
            this.groupBox2.Controls.Add(this.label_vehicle_speed);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label_current_gear);
            this.groupBox2.Controls.Add(this.label_rpm);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label_eng_char);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_eng_manifold_pressure);
            this.groupBox2.Controls.Add(this.label_eng_coolant_temp);
            this.groupBox2.Controls.Add(this.label_eng_temp);
            this.groupBox2.Controls.Add(this.label_throttle_position);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Engine && Transmission";
            // 
            // label_vehicle_speed
            // 
            this.label_vehicle_speed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_vehicle_speed.Location = new System.Drawing.Point(228, 120);
            this.label_vehicle_speed.Name = "label_vehicle_speed";
            this.label_vehicle_speed.Size = new System.Drawing.Size(130, 30);
            this.label_vehicle_speed.TabIndex = 10;
            this.label_vehicle_speed.Text = "0 km/h";
            this.label_vehicle_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11F);
            this.label12.Location = new System.Drawing.Point(246, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Speed(km/h)";
            // 
            // label_current_gear
            // 
            this.label_current_gear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_current_gear.Location = new System.Drawing.Point(131, 120);
            this.label_current_gear.Name = "label_current_gear";
            this.label_current_gear.Size = new System.Drawing.Size(100, 30);
            this.label_current_gear.TabIndex = 8;
            this.label_current_gear.Text = "N";
            this.label_current_gear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rpm
            // 
            this.label_rpm.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_rpm.Location = new System.Drawing.Point(6, 120);
            this.label_rpm.Name = "label_rpm";
            this.label_rpm.Size = new System.Drawing.Size(134, 30);
            this.label_rpm.TabIndex = 6;
            this.label_rpm.Text = "0 RPM";
            this.label_rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 11F);
            this.label10.Location = new System.Drawing.Point(139, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Current Gear";
            // 
            // label_eng_char
            // 
            this.label_eng_char.AutoSize = true;
            this.label_eng_char.Location = new System.Drawing.Point(6, 87);
            this.label_eng_char.Name = "label_eng_char";
            this.label_eng_char.Size = new System.Drawing.Size(134, 12);
            this.label_eng_char.TabIndex = 4;
            this.label_eng_char.Text = "Engine Characteristic: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11F);
            this.label8.Location = new System.Drawing.Point(47, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "RPM";
            // 
            // label_eng_manifold_pressure
            // 
            this.label_eng_manifold_pressure.AutoSize = true;
            this.label_eng_manifold_pressure.Location = new System.Drawing.Point(6, 73);
            this.label_eng_manifold_pressure.Name = "label_eng_manifold_pressure";
            this.label_eng_manifold_pressure.Size = new System.Drawing.Size(190, 12);
            this.label_eng_manifold_pressure.TabIndex = 3;
            this.label_eng_manifold_pressure.Text = "Engine Manifold Pressure(kPa): ";
            // 
            // label_eng_coolant_temp
            // 
            this.label_eng_coolant_temp.AutoSize = true;
            this.label_eng_coolant_temp.Location = new System.Drawing.Point(6, 59);
            this.label_eng_coolant_temp.Name = "label_eng_coolant_temp";
            this.label_eng_coolant_temp.Size = new System.Drawing.Size(198, 12);
            this.label_eng_coolant_temp.TabIndex = 1;
            this.label_eng_coolant_temp.Text = "Engine Coolant Temperature(°C): ";
            // 
            // label_eng_temp
            // 
            this.label_eng_temp.AutoSize = true;
            this.label_eng_temp.Location = new System.Drawing.Point(6, 45);
            this.label_eng_temp.Name = "label_eng_temp";
            this.label_eng_temp.Size = new System.Drawing.Size(151, 12);
            this.label_eng_temp.TabIndex = 2;
            this.label_eng_temp.Text = "Engine Temperature(°C): ";
            // 
            // label_throttle_position
            // 
            this.label_throttle_position.AutoSize = true;
            this.label_throttle_position.Location = new System.Drawing.Point(6, 17);
            this.label_throttle_position.Name = "label_throttle_position";
            this.label_throttle_position.Size = new System.Drawing.Size(124, 12);
            this.label_throttle_position.TabIndex = 1;
            this.label_throttle_position.Text = "Throttle Position(%): ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_brake);
            this.groupBox3.Controls.Add(this.label_voltage);
            this.groupBox3.Controls.Add(this.label_atmo_pressure);
            this.groupBox3.Controls.Add(this.label_air_temp);
            this.groupBox3.Controls.Add(this.label_air_conditioning_pressure);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 113);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Miscellaneous";
            // 
            // label_brake
            // 
            this.label_brake.AutoSize = true;
            this.label_brake.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_brake.Location = new System.Drawing.Point(115, 74);
            this.label_brake.Name = "label_brake";
            this.label_brake.Size = new System.Drawing.Size(122, 32);
            this.label_brake.TabIndex = 4;
            this.label_brake.Text = "Brake Off";
            this.label_brake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Location = new System.Drawing.Point(6, 59);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(127, 12);
            this.label_voltage.TabIndex = 3;
            this.label_voltage.Text = "Votage of Battery(V): ";
            // 
            // label_atmo_pressure
            // 
            this.label_atmo_pressure.AutoSize = true;
            this.label_atmo_pressure.Location = new System.Drawing.Point(6, 45);
            this.label_atmo_pressure.Name = "label_atmo_pressure";
            this.label_atmo_pressure.Size = new System.Drawing.Size(186, 12);
            this.label_atmo_pressure.TabIndex = 2;
            this.label_atmo_pressure.Text = "Atmospheric Pressure(mmHg): ";
            // 
            // label_air_temp
            // 
            this.label_air_temp.AutoSize = true;
            this.label_air_temp.Location = new System.Drawing.Point(6, 31);
            this.label_air_temp.Name = "label_air_temp";
            this.label_air_temp.Size = new System.Drawing.Size(127, 12);
            this.label_air_temp.TabIndex = 1;
            this.label_air_temp.Text = "Air Temperature(°C): ";
            // 
            // label_air_conditioning_pressure
            // 
            this.label_air_conditioning_pressure.AutoSize = true;
            this.label_air_conditioning_pressure.Location = new System.Drawing.Point(6, 17);
            this.label_air_conditioning_pressure.Name = "label_air_conditioning_pressure";
            this.label_air_conditioning_pressure.Size = new System.Drawing.Size(189, 12);
            this.label_air_conditioning_pressure.TabIndex = 0;
            this.label_air_conditioning_pressure.Text = "Air Conditioning Pressure(hPa): ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(248, 389);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "Steering Angle(°C)";
            // 
            // label_steering_angle
            // 
            this.label_steering_angle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_steering_angle.Location = new System.Drawing.Point(255, 404);
            this.label_steering_angle.Name = "label_steering_angle";
            this.label_steering_angle.Size = new System.Drawing.Size(104, 48);
            this.label_steering_angle.TabIndex = 14;
            this.label_steering_angle.Text = "0";
            this.label_steering_angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(254, 474);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 15);
            this.label21.TabIndex = 15;
            this.label21.Text = "Steering Speed";
            // 
            // label_steering_speed
            // 
            this.label_steering_speed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_steering_speed.Location = new System.Drawing.Point(255, 489);
            this.label_steering_speed.Name = "label_steering_speed";
            this.label_steering_speed.Size = new System.Drawing.Size(104, 48);
            this.label_steering_speed.TabIndex = 16;
            this.label_steering_speed.Text = "0";
            this.label_steering_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_can_output
            // 
            this.textBox_can_output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_can_output.Location = new System.Drawing.Point(6, 20);
            this.textBox_can_output.Multiline = true;
            this.textBox_can_output.Name = "textBox_can_output";
            this.textBox_can_output.ReadOnly = true;
            this.textBox_can_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_can_output.Size = new System.Drawing.Size(348, 124);
            this.textBox_can_output.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_can_output);
            this.groupBox4.Location = new System.Drawing.Point(12, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 150);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CAN Messages";
            // 
            // label_brake_pos
            // 
            this.label_brake_pos.AutoSize = true;
            this.label_brake_pos.Location = new System.Drawing.Point(6, 31);
            this.label_brake_pos.Name = "label_brake_pos";
            this.label_brake_pos.Size = new System.Drawing.Size(123, 12);
            this.label_brake_pos.TabIndex = 19;
            this.label_brake_pos.Text = "Brake Position(Bar): ";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 707);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_steering_speed);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label_steering_angle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Main";
            this.Text = "Vehicle Data Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Bitrate;
        private System.Windows.Forms.ComboBox comboBox_Channel;
        private System.Windows.Forms.Button btn_start_stop;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label_vehicle_speed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_current_gear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_rpm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_eng_char;
        private System.Windows.Forms.Label label_eng_manifold_pressure;
        private System.Windows.Forms.Label label_eng_coolant_temp;
        private System.Windows.Forms.Label label_eng_temp;
        private System.Windows.Forms.Label label_throttle_position;
        private System.Windows.Forms.Label label_brake;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.Label label_atmo_pressure;
        private System.Windows.Forms.Label label_air_temp;
        private System.Windows.Forms.Label label_air_conditioning_pressure;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_steering_angle;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_steering_speed;
        private System.Windows.Forms.TextBox textBox_can_output;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_brake_pos;
    }
}

