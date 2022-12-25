namespace BMS_Control_Application
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connection_state_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.voltage_label = new System.Windows.Forms.Label();
            this.current_label = new System.Windows.Forms.Label();
            this.temprature_label = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.savedata_checkbox = new System.Windows.Forms.CheckBox();
            this.charge_button = new System.Windows.Forms.Button();
            this.discharge_button = new System.Windows.Forms.Button();
            this.idle_button = new System.Windows.Forms.Button();
            this.battery_state_label = new System.Windows.Forms.Label();
            this.cycle_counter_label = new System.Windows.Forms.Label();
            this.cycle_textBox = new System.Windows.Forms.TextBox();
            this.cycle_set_button = new System.Windows.Forms.Button();
            this.coolDown_button = new System.Windows.Forms.Button();
            this.coolDownTime_textbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // connection_state_label
            // 
            this.connection_state_label.AutoSize = true;
            this.connection_state_label.Location = new System.Drawing.Point(166, 26);
            this.connection_state_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connection_state_label.Name = "connection_state_label";
            this.connection_state_label.Size = new System.Drawing.Size(134, 16);
            this.connection_state_label.TabIndex = 2;
            this.connection_state_label.Text = "CONNECTION STATE";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(54, 76);
            this.start_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(63, 48);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(198, 76);
            this.stop_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(63, 48);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // voltage_label
            // 
            this.voltage_label.AutoSize = true;
            this.voltage_label.Location = new System.Drawing.Point(117, 175);
            this.voltage_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voltage_label.Name = "voltage_label";
            this.voltage_label.Size = new System.Drawing.Size(67, 16);
            this.voltage_label.TabIndex = 6;
            this.voltage_label.Text = "VOLTAGE";
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.Location = new System.Drawing.Point(41, 209);
            this.current_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(66, 16);
            this.current_label.TabIndex = 7;
            this.current_label.Text = "CURRENT";
            // 
            // temprature_label
            // 
            this.temprature_label.AutoSize = true;
            this.temprature_label.Location = new System.Drawing.Point(185, 209);
            this.temprature_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temprature_label.Name = "temprature_label";
            this.temprature_label.Size = new System.Drawing.Size(89, 16);
            this.temprature_label.TabIndex = 8;
            this.temprature_label.Text = "TEMPRATURE";
            // 
            // savedata_checkbox
            // 
            this.savedata_checkbox.AutoSize = true;
            this.savedata_checkbox.Location = new System.Drawing.Point(108, 395);
            this.savedata_checkbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.savedata_checkbox.Name = "savedata_checkbox";
            this.savedata_checkbox.Size = new System.Drawing.Size(99, 20);
            this.savedata_checkbox.TabIndex = 11;
            this.savedata_checkbox.Text = "SAVE DATA";
            this.savedata_checkbox.UseVisualStyleBackColor = true;
            this.savedata_checkbox.CheckedChanged += new System.EventHandler(this.saveData_checkbox_CheckedChanged);
            // 
            // charge_button
            // 
            this.charge_button.Location = new System.Drawing.Point(31, 346);
            this.charge_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.charge_button.Name = "charge_button";
            this.charge_button.Size = new System.Drawing.Size(63, 35);
            this.charge_button.TabIndex = 12;
            this.charge_button.Text = "Charge";
            this.charge_button.UseVisualStyleBackColor = true;
            this.charge_button.Click += new System.EventHandler(this.charge_button_Click);
            // 
            // discharge_button
            // 
            this.discharge_button.Location = new System.Drawing.Point(120, 346);
            this.discharge_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.discharge_button.Name = "discharge_button";
            this.discharge_button.Size = new System.Drawing.Size(87, 35);
            this.discharge_button.TabIndex = 13;
            this.discharge_button.Text = "Discharge";
            this.discharge_button.UseVisualStyleBackColor = true;
            this.discharge_button.Click += new System.EventHandler(this.discharge_button_Click);
            // 
            // idle_button
            // 
            this.idle_button.Location = new System.Drawing.Point(235, 346);
            this.idle_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idle_button.Name = "idle_button";
            this.idle_button.Size = new System.Drawing.Size(65, 35);
            this.idle_button.TabIndex = 14;
            this.idle_button.Text = "Idle";
            this.idle_button.UseVisualStyleBackColor = true;
            this.idle_button.Click += new System.EventHandler(this.idle_button_Click);
            // 
            // battery_state_label
            // 
            this.battery_state_label.AutoSize = true;
            this.battery_state_label.Location = new System.Drawing.Point(28, 143);
            this.battery_state_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.battery_state_label.Name = "battery_state_label";
            this.battery_state_label.Size = new System.Drawing.Size(106, 16);
            this.battery_state_label.TabIndex = 15;
            this.battery_state_label.Text = "Battery State Idle";
            // 
            // cycle_counter_label
            // 
            this.cycle_counter_label.AutoSize = true;
            this.cycle_counter_label.Location = new System.Drawing.Point(183, 143);
            this.cycle_counter_label.Name = "cycle_counter_label";
            this.cycle_counter_label.Size = new System.Drawing.Size(91, 16);
            this.cycle_counter_label.TabIndex = 16;
            this.cycle_counter_label.Text = "Cycle Counter";
            // 
            // cycle_textBox
            // 
            this.cycle_textBox.Location = new System.Drawing.Point(54, 244);
            this.cycle_textBox.Name = "cycle_textBox";
            this.cycle_textBox.Size = new System.Drawing.Size(73, 23);
            this.cycle_textBox.TabIndex = 17;
            this.cycle_textBox.Text = "Cycle";
            this.cycle_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cycle_textBox_KeyPress);
            // 
            // cycle_set_button
            // 
            this.cycle_set_button.Location = new System.Drawing.Point(198, 244);
            this.cycle_set_button.Name = "cycle_set_button";
            this.cycle_set_button.Size = new System.Drawing.Size(76, 23);
            this.cycle_set_button.TabIndex = 18;
            this.cycle_set_button.Text = "Set Cycle";
            this.cycle_set_button.UseVisualStyleBackColor = true;
            this.cycle_set_button.Click += new System.EventHandler(this.cycle_set_button_Click);
            // 
            // coolDown_button
            // 
            this.coolDown_button.Location = new System.Drawing.Point(172, 296);
            this.coolDown_button.Name = "coolDown_button";
            this.coolDown_button.Size = new System.Drawing.Size(102, 23);
            this.coolDown_button.TabIndex = 20;
            this.coolDown_button.Text = "Set Cool-Down";
            this.coolDown_button.UseVisualStyleBackColor = true;
            this.coolDown_button.Click += new System.EventHandler(this.coolDown_button_Click);
            // 
            // coolDownTime_textbox
            // 
            this.coolDownTime_textbox.Location = new System.Drawing.Point(54, 296);
            this.coolDownTime_textbox.Name = "coolDownTime_textbox";
            this.coolDownTime_textbox.Size = new System.Drawing.Size(73, 23);
            this.coolDownTime_textbox.TabIndex = 19;
            this.coolDownTime_textbox.Text = "Cool Down";
            this.coolDownTime_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coolDownTime_textbox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 447);
            this.Controls.Add(this.coolDown_button);
            this.Controls.Add(this.coolDownTime_textbox);
            this.Controls.Add(this.cycle_set_button);
            this.Controls.Add(this.cycle_textBox);
            this.Controls.Add(this.cycle_counter_label);
            this.Controls.Add(this.battery_state_label);
            this.Controls.Add(this.idle_button);
            this.Controls.Add(this.discharge_button);
            this.Controls.Add(this.charge_button);
            this.Controls.Add(this.savedata_checkbox);
            this.Controls.Add(this.temprature_label);
            this.Controls.Add(this.current_label);
            this.Controls.Add(this.voltage_label);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.connection_state_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BMS Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label connection_state_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label voltage_label;
        private System.Windows.Forms.Label current_label;
        private System.Windows.Forms.Label temprature_label;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox savedata_checkbox;
        private System.Windows.Forms.Button charge_button;
        private System.Windows.Forms.Button discharge_button;
        private System.Windows.Forms.Button idle_button;
        private System.Windows.Forms.Label battery_state_label;
        private System.Windows.Forms.Label cycle_counter_label;
        private System.Windows.Forms.TextBox cycle_textBox;
        private System.Windows.Forms.Button cycle_set_button;
        private System.Windows.Forms.Button coolDown_button;
        private System.Windows.Forms.TextBox coolDownTime_textbox;
        private System.Windows.Forms.Timer timer1;
    }
}

