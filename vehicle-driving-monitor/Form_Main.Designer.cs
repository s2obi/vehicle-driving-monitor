
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
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(514, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAN Configuration";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(399, 70);
            this.btn_start_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(107, 34);
            this.btn_start_stop.TabIndex = 5;
            this.btn_start_stop.Text = "Start";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(399, 27);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(107, 34);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // comboBox_Bitrate
            // 
            this.comboBox_Bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bitrate.FormattingEnabled = true;
            this.comboBox_Bitrate.Location = new System.Drawing.Point(113, 70);
            this.comboBox_Bitrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Bitrate.Name = "comboBox_Bitrate";
            this.comboBox_Bitrate.Size = new System.Drawing.Size(275, 26);
            this.comboBox_Bitrate.TabIndex = 3;
            this.comboBox_Bitrate.SelectedIndexChanged += new System.EventHandler(this.comboBox_Bitrate_SelectedIndexChanged);
            // 
            // comboBox_Channel
            // 
            this.comboBox_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Channel.FormattingEnabled = true;
            this.comboBox_Channel.Location = new System.Drawing.Point(113, 30);
            this.comboBox_Channel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Channel.Name = "comboBox_Channel";
            this.comboBox_Channel.Size = new System.Drawing.Size(275, 26);
            this.comboBox_Channel.TabIndex = 2;
            this.comboBox_Channel.SelectedIndexChanged += new System.EventHandler(this.comboBox_Channel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(17, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(514, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Engine && Transmission";
            // 
            // label_vehicle_speed
            // 
            this.label_vehicle_speed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_vehicle_speed.Location = new System.Drawing.Point(326, 172);
            this.label_vehicle_speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_vehicle_speed.Name = "label_vehicle_speed";
            this.label_vehicle_speed.Size = new System.Drawing.Size(186, 45);
            this.label_vehicle_speed.TabIndex = 10;
            this.label_vehicle_speed.Text = "0 km/h";
            this.label_vehicle_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11F);
            this.label12.Location = new System.Drawing.Point(351, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Speed(km/h)";
            // 
            // label_current_gear
            // 
            this.label_current_gear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_current_gear.Location = new System.Drawing.Point(187, 172);
            this.label_current_gear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_current_gear.Name = "label_current_gear";
            this.label_current_gear.Size = new System.Drawing.Size(143, 45);
            this.label_current_gear.TabIndex = 8;
            this.label_current_gear.Text = "N";
            this.label_current_gear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rpm
            // 
            this.label_rpm.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_rpm.Location = new System.Drawing.Point(9, 172);
            this.label_rpm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rpm.Name = "label_rpm";
            this.label_rpm.Size = new System.Drawing.Size(191, 45);
            this.label_rpm.TabIndex = 6;
            this.label_rpm.Text = "0 RPM";
            this.label_rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 11F);
            this.label10.Location = new System.Drawing.Point(199, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Current Gear";
            // 
            // label_eng_char
            // 
            this.label_eng_char.AutoSize = true;
            this.label_eng_char.Location = new System.Drawing.Point(9, 110);
            this.label_eng_char.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eng_char.Name = "label_eng_char";
            this.label_eng_char.Size = new System.Drawing.Size(190, 18);
            this.label_eng_char.TabIndex = 4;
            this.label_eng_char.Text = "Engine Characteristic: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11F);
            this.label8.Location = new System.Drawing.Point(67, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "RPM";
            // 
            // label_eng_manifold_pressure
            // 
            this.label_eng_manifold_pressure.AutoSize = true;
            this.label_eng_manifold_pressure.Location = new System.Drawing.Point(9, 88);
            this.label_eng_manifold_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eng_manifold_pressure.Name = "label_eng_manifold_pressure";
            this.label_eng_manifold_pressure.Size = new System.Drawing.Size(268, 18);
            this.label_eng_manifold_pressure.TabIndex = 3;
            this.label_eng_manifold_pressure.Text = "Engine Manifold Pressure(kPa): ";
            // 
            // label_eng_coolant_temp
            // 
            this.label_eng_coolant_temp.AutoSize = true;
            this.label_eng_coolant_temp.Location = new System.Drawing.Point(9, 68);
            this.label_eng_coolant_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eng_coolant_temp.Name = "label_eng_coolant_temp";
            this.label_eng_coolant_temp.Size = new System.Drawing.Size(281, 18);
            this.label_eng_coolant_temp.TabIndex = 1;
            this.label_eng_coolant_temp.Text = "Engine Coolant Temperature(°C): ";
            // 
            // label_eng_temp
            // 
            this.label_eng_temp.AutoSize = true;
            this.label_eng_temp.Location = new System.Drawing.Point(9, 46);
            this.label_eng_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eng_temp.Name = "label_eng_temp";
            this.label_eng_temp.Size = new System.Drawing.Size(213, 18);
            this.label_eng_temp.TabIndex = 2;
            this.label_eng_temp.Text = "Engine Temperature(°C): ";
            // 
            // label_throttle_position
            // 
            this.label_throttle_position.AutoSize = true;
            this.label_throttle_position.Location = new System.Drawing.Point(9, 26);
            this.label_throttle_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_throttle_position.Name = "label_throttle_position";
            this.label_throttle_position.Size = new System.Drawing.Size(176, 18);
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
            this.groupBox3.Location = new System.Drawing.Point(17, 384);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(514, 170);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Miscellaneous";
            // 
            // label_brake
            // 
            this.label_brake.AutoSize = true;
            this.label_brake.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_brake.Location = new System.Drawing.Point(164, 111);
            this.label_brake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_brake.Name = "label_brake";
            this.label_brake.Size = new System.Drawing.Size(184, 48);
            this.label_brake.TabIndex = 4;
            this.label_brake.Text = "Brake Off";
            this.label_brake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Location = new System.Drawing.Point(9, 88);
            this.label_voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(185, 18);
            this.label_voltage.TabIndex = 3;
            this.label_voltage.Text = "Votage of Battery(V): ";
            // 
            // label_atmo_pressure
            // 
            this.label_atmo_pressure.AutoSize = true;
            this.label_atmo_pressure.Location = new System.Drawing.Point(9, 68);
            this.label_atmo_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_atmo_pressure.Name = "label_atmo_pressure";
            this.label_atmo_pressure.Size = new System.Drawing.Size(264, 18);
            this.label_atmo_pressure.TabIndex = 2;
            this.label_atmo_pressure.Text = "Atmospheric Pressure(mmHg): ";
            // 
            // label_air_temp
            // 
            this.label_air_temp.AutoSize = true;
            this.label_air_temp.Location = new System.Drawing.Point(9, 46);
            this.label_air_temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_air_temp.Name = "label_air_temp";
            this.label_air_temp.Size = new System.Drawing.Size(180, 18);
            this.label_air_temp.TabIndex = 1;
            this.label_air_temp.Text = "Air Temperature(°C): ";
            // 
            // label_air_conditioning_pressure
            // 
            this.label_air_conditioning_pressure.AutoSize = true;
            this.label_air_conditioning_pressure.Location = new System.Drawing.Point(9, 26);
            this.label_air_conditioning_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_air_conditioning_pressure.Name = "label_air_conditioning_pressure";
            this.label_air_conditioning_pressure.Size = new System.Drawing.Size(267, 18);
            this.label_air_conditioning_pressure.TabIndex = 0;
            this.label_air_conditioning_pressure.Text = "Air Conditioning Pressure(hPa): ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(354, 584);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 22);
            this.label19.TabIndex = 12;
            this.label19.Text = "Steering Angle(°C)";
            // 
            // label_steering_angle
            // 
            this.label_steering_angle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_steering_angle.Location = new System.Drawing.Point(364, 606);
            this.label_steering_angle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_steering_angle.Name = "label_steering_angle";
            this.label_steering_angle.Size = new System.Drawing.Size(149, 72);
            this.label_steering_angle.TabIndex = 14;
            this.label_steering_angle.Text = "0";
            this.label_steering_angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(363, 711);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 22);
            this.label21.TabIndex = 15;
            this.label21.Text = "Steering Speed";
            // 
            // label_steering_speed
            // 
            this.label_steering_speed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_steering_speed.Location = new System.Drawing.Point(364, 734);
            this.label_steering_speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_steering_speed.Name = "label_steering_speed";
            this.label_steering_speed.Size = new System.Drawing.Size(149, 72);
            this.label_steering_speed.TabIndex = 16;
            this.label_steering_speed.Text = "0";
            this.label_steering_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_can_output
            // 
            this.textBox_can_output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_can_output.Location = new System.Drawing.Point(9, 30);
            this.textBox_can_output.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_can_output.Multiline = true;
            this.textBox_can_output.Name = "textBox_can_output";
            this.textBox_can_output.ReadOnly = true;
            this.textBox_can_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_can_output.Size = new System.Drawing.Size(495, 184);
            this.textBox_can_output.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_can_output);
            this.groupBox4.Location = new System.Drawing.Point(17, 824);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(514, 225);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CAN Messages";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 1066);
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
    }
}

