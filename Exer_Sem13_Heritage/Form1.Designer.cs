namespace Exer_Sem13_Heritage
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.btn_etu = new System.Windows.Forms.Button();
            this.tso_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(12, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 23);
            this.tb_name.TabIndex = 0;
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.Location = new System.Drawing.Point(198, 39);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(52, 23);
            this.tb_number.TabIndex = 1;
            // 
            // btn_etu
            // 
            this.btn_etu.Location = new System.Drawing.Point(12, 83);
            this.btn_etu.Name = "btn_etu";
            this.btn_etu.Size = new System.Drawing.Size(106, 47);
            this.btn_etu.TabIndex = 2;
            this.btn_etu.Text = "Etudiant";
            this.btn_etu.UseVisualStyleBackColor = true;
            this.btn_etu.Click += new System.EventHandler(this.btn_etu_Click);
            // 
            // tso_btn
            // 
            this.tso_btn.Location = new System.Drawing.Point(144, 83);
            this.tso_btn.Name = "tso_btn";
            this.tso_btn.Size = new System.Drawing.Size(106, 47);
            this.tso_btn.TabIndex = 3;
            this.tso_btn.Text = "TSO";
            this.tso_btn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 160);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 311);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tso_btn);
            this.Controls.Add(this.btn_etu);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button btn_etu;
        private System.Windows.Forms.Button tso_btn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

