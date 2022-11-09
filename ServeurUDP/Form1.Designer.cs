namespace ServeurUDP
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
            this.lb_Rx = new System.Windows.Forms.ListBox();
            this.btn_LastReceived = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Rx
            // 
            this.lb_Rx.FormattingEnabled = true;
            this.lb_Rx.Location = new System.Drawing.Point(505, 65);
            this.lb_Rx.Name = "lb_Rx";
            this.lb_Rx.Size = new System.Drawing.Size(494, 407);
            this.lb_Rx.TabIndex = 0;
            // 
            // btn_LastReceived
            // 
            this.btn_LastReceived.Location = new System.Drawing.Point(505, 29);
            this.btn_LastReceived.Name = "btn_LastReceived";
            this.btn_LastReceived.Size = new System.Drawing.Size(159, 30);
            this.btn_LastReceived.TabIndex = 1;
            this.btn_LastReceived.Text = "Last Received Msg";
            this.btn_LastReceived.UseVisualStyleBackColor = true;
            this.btn_LastReceived.Click += new System.EventHandler(this.btn_LastReceived_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServeurUDP.Properties.Resources.cool_yoshi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1007, 478);
            this.Controls.Add(this.btn_LastReceived);
            this.Controls.Add(this.lb_Rx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Rx;
        private System.Windows.Forms.Button btn_LastReceived;
    }
}

