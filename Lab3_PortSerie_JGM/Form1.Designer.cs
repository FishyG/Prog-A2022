namespace Lab3_PortSerie_JGM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tb_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rx = new System.Windows.Forms.TextBox();
            this.btn_TX = new System.Windows.Forms.Button();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tb_tx
            // 
            this.tb_tx.Location = new System.Drawing.Point(12, 25);
            this.tb_tx.Name = "tb_tx";
            this.tb_tx.Size = new System.Drawing.Size(183, 20);
            this.tb_tx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to TX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text RX";
            // 
            // tb_rx
            // 
            this.tb_rx.Location = new System.Drawing.Point(12, 96);
            this.tb_rx.Name = "tb_rx";
            this.tb_rx.Size = new System.Drawing.Size(183, 20);
            this.tb_rx.TabIndex = 3;
            // 
            // btn_TX
            // 
            this.btn_TX.Location = new System.Drawing.Point(12, 51);
            this.btn_TX.Name = "btn_TX";
            this.btn_TX.Size = new System.Drawing.Size(75, 23);
            this.btn_TX.TabIndex = 4;
            this.btn_TX.Text = "TX";
            this.btn_TX.UseVisualStyleBackColor = true;
            this.btn_TX.Click += new System.EventHandler(this.btn_TX_Click);
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(103, 36);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 5;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(285, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 238);
            this.panel1.TabIndex = 6;
            // 
            // btn_configSerialPort
            // 
            this.btn_configSerialPort.Location = new System.Drawing.Point(103, 196);
            this.btn_configSerialPort.Name = "btn_configSerialPort";
            this.btn_configSerialPort.Size = new System.Drawing.Size(121, 23);
            this.btn_configSerialPort.TabIndex = 16;
            this.btn_configSerialPort.Text = "Open/Set serial port";
            this.btn_configSerialPort.UseVisualStyleBackColor = true;
            this.btn_configSerialPort.Click += new System.EventHandler(this.btn_configSerialPort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stop bits";
            // 
            // cb_stopBits
            // 
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
            this.label7.Location = new System.Drawing.Point(35, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data bits";
            // 
            // cb_dataBits
            // 
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
            this.label6.Location = new System.Drawing.Point(35, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parity";
            // 
            // cb_parity
            // 
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(103, 90);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(121, 21);
            this.cb_parity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baudrate";
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(103, 63);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(121, 21);
            this.cb_baudrate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Config";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TX);
            this.Controls.Add(this.tb_rx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tb_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_rx;
        private System.Windows.Forms.Button btn_TX;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_stopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_dataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.Button btn_configSerialPort;
    }
}

