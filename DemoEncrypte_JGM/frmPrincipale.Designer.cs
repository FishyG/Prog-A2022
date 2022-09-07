namespace DemoClasseEncrypte
{
    partial class frmPrincipale
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
            this.label1 = new System.Windows.Forms.Label();
            this.chaineText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultatLabel = new System.Windows.Forms.Label();
            this.codeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texte de départ";
            // 
            // chaineText
            // 
            this.chaineText.Location = new System.Drawing.Point(32, 57);
            this.chaineText.Name = "chaineText";
            this.chaineText.Size = new System.Drawing.Size(163, 20);
            this.chaineText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texte encrypté";
            // 
            // resultatLabel
            // 
            this.resultatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultatLabel.Location = new System.Drawing.Point(29, 149);
            this.resultatLabel.Name = "resultatLabel";
            this.resultatLabel.Size = new System.Drawing.Size(166, 23);
            this.resultatLabel.TabIndex = 3;
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(126, 216);
            this.codeText.Margin = new System.Windows.Forms.Padding(2);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(29, 20);
            this.codeText.TabIndex = 4;
            this.codeText.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code d\'encryption:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(168, 216);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(46, 34);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 276);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.resultatLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chaineText);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipale";
            this.Text = "Démo Classe Encrypte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chaineText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultatLabel;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
    }
}

