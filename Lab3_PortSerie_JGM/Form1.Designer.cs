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
            this.btn_configSerialPort = new System.Windows.Forms.Button();
            this.btn_OpenSerialPort = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "Com1";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tb_tx
            // 
            this.tb_tx.Location = new System.Drawing.Point(12, 25);
            this.tb_tx.Name = "tb_tx";
            this.tb_tx.Size = new System.Drawing.Size(228, 20);
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
            this.tb_rx.Size = new System.Drawing.Size(228, 20);
            this.tb_rx.TabIndex = 3;
            // 
            // btn_TX
            // 
            this.btn_TX.Enabled = false;
            this.btn_TX.Location = new System.Drawing.Point(12, 51);
            this.btn_TX.Name = "btn_TX";
            this.btn_TX.Size = new System.Drawing.Size(75, 23);
            this.btn_TX.TabIndex = 4;
            this.btn_TX.Text = "TX";
            this.btn_TX.UseVisualStyleBackColor = true;
            this.btn_TX.Click += new System.EventHandler(this.btn_TX_Click);
            // 
            // btn_configSerialPort
            // 
            this.btn_configSerialPort.Location = new System.Drawing.Point(12, 175);
            this.btn_configSerialPort.Name = "btn_configSerialPort";
            this.btn_configSerialPort.Size = new System.Drawing.Size(46, 23);
            this.btn_configSerialPort.TabIndex = 17;
            this.btn_configSerialPort.Text = "Config";
            this.btn_configSerialPort.UseVisualStyleBackColor = true;
            this.btn_configSerialPort.Click += new System.EventHandler(this.btn_configSerialPort_Click);
            // 
            // btn_OpenSerialPort
            // 
            this.btn_OpenSerialPort.Location = new System.Drawing.Point(64, 175);
            this.btn_OpenSerialPort.Name = "btn_OpenSerialPort";
            this.btn_OpenSerialPort.Size = new System.Drawing.Size(46, 23);
            this.btn_OpenSerialPort.TabIndex = 18;
            this.btn_OpenSerialPort.Text = "Open";
            this.btn_OpenSerialPort.UseVisualStyleBackColor = true;
            this.btn_OpenSerialPort.Click += new System.EventHandler(this.btn_OpenSerialPort_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(186, 175);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(54, 23);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 205);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(252, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 227);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_OpenSerialPort);
            this.Controls.Add(this.btn_configSerialPort);
            this.Controls.Add(this.btn_TX);
            this.Controls.Add(this.tb_rx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btn_configSerialPort;
        private System.Windows.Forms.Button btn_OpenSerialPort;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

