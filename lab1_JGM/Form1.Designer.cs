namespace lab1_JGM
{
    partial class frmLab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab1));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(18, 24);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(293, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Champ de saisie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résultat :";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(18, 75);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTextBox.Size = new System.Drawing.Size(293, 20);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retirer Espaces";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_RemoveSpace);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inverser Caractères";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_InvertChar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Doubler Caractères";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_DoubleChar);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sauter 1 Caractère";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_SkipOneChar);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 24);
            this.button5.TabIndex = 8;
            this.button5.Text = "Maj-Min";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_MajMin);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 24);
            this.button6.TabIndex = 9;
            this.button6.Text = "Mot De Passe";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Password);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(184, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 24);
            this.button7.TabIndex = 10;
            this.button7.Text = "1 Seul Espace";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_OnlyOneSpace);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(184, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 24);
            this.button8.TabIndex = 11;
            this.button8.Text = "Inverse Mots";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_InvertWord);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(184, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 24);
            this.button9.TabIndex = 12;
            this.button9.Text = "Compte Mots";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_CountWord);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(184, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 24);
            this.button10.TabIndex = 13;
            this.button10.Text = "Rotation";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Rotate);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(184, 245);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(127, 24);
            this.button11.TabIndex = 14;
            this.button11.Text = "ASCII";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Ascii);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(184, 275);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(127, 24);
            this.quitter.TabIndex = 15;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(341, 350);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button quitter;
    }
}

