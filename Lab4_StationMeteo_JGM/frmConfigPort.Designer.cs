namespace Lab3_PortSerie_JGM
{
    partial class frmConfigPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_configSerialPort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_stopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_dataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_configSerialPort);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_stopBits);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_dataBits);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_parity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_baudrate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_port);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 238);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(152, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_configSerialPort
            // 
            this.btn_configSerialPort.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_configSerialPort.Location = new System.Drawing.Point(38, 203);
            this.btn_configSerialPort.Name = "btn_configSerialPort";
            this.btn_configSerialPort.Size = new System.Drawing.Size(72, 23);
            this.btn_configSerialPort.TabIndex = 16;
            this.btn_configSerialPort.Text = "Ok";
            this.btn_configSerialPort.UseVisualStyleBackColor = true;
            this.btn_configSerialPort.Click += new System.EventHandler(this.btn_configSerialPort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(35, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stop bits";
            // 
            // cb_stopBits
            // 
            this.cb_stopBits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stopBits.FormattingEnabled = true;
            this.cb_stopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_stopBits.Location = new System.Drawing.Point(103, 144);
            this.cb_stopBits.Name = "cb_stopBits";
            this.cb_stopBits.Size = new System.Drawing.Size(121, 21);
            this.cb_stopBits.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(35, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data bits";
            // 
            // cb_dataBits
            // 
            this.cb_dataBits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_dataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dataBits.FormattingEnabled = true;
            this.cb_dataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cb_dataBits.Location = new System.Drawing.Point(103, 117);
            this.cb_dataBits.Name = "cb_dataBits";
            this.cb_dataBits.Size = new System.Drawing.Size(121, 21);
            this.cb_dataBits.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(35, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parity";
            // 
            // cb_parity
            // 
            this.cb_parity.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(103, 90);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(121, 21);
            this.cb_parity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(35, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baudrate";
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(103, 63);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(121, 21);
            this.cb_baudrate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(35, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Config";
            // 
            // cb_port
            // 
            this.cb_port.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(103, 36);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 5;
            // 
            // frmConfigPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(269, 259);
            this.Controls.Add(this.panel1);
            this.Name = "frmConfigPort";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_configSerialPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_stopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_dataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_port;
    }
}