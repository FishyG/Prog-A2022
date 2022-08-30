namespace Semaine2_Exemple1
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
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_L = new System.Windows.Forms.Button();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(18, 232);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(50, 23);
            this.btn_D.TabIndex = 1;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.ABC_Click);
            // 
            // btn_E
            // 
            this.btn_E.Location = new System.Drawing.Point(74, 232);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(50, 23);
            this.btn_E.TabIndex = 2;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.ABC_Click);
            // 
            // btn_L
            // 
            this.btn_L.Location = new System.Drawing.Point(130, 232);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(50, 23);
            this.btn_L.TabIndex = 3;
            this.btn_L.Text = "L";
            this.btn_L.UseVisualStyleBackColor = true;
            this.btn_L.Click += new System.EventHandler(this.ABC_Click);
            // 
            // panelTextBox
            // 
            this.panelTextBox.Controls.Add(this.textBox5);
            this.panelTextBox.Controls.Add(this.textBox4);
            this.panelTextBox.Controls.Add(this.textBox3);
            this.panelTextBox.Controls.Add(this.textBox2);
            this.panelTextBox.Controls.Add(this.textBox1);
            this.panelTextBox.Location = new System.Drawing.Point(18, 23);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(162, 184);
            this.panelTextBox.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 305);
            this.Controls.Add(this.panelTextBox);
            this.Controls.Add(this.btn_L);
            this.Controls.Add(this.btn_E);
            this.Controls.Add(this.btn_D);
            this.Name = "Form1";
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_L;
        private System.Windows.Forms.Panel panelTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

