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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab1));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.btnRemoveSpace = new System.Windows.Forms.Button();
            this.btnInvertChar = new System.Windows.Forms.Button();
            this.btnDoubleChar = new System.Windows.Forms.Button();
            this.btnSkipOneChar = new System.Windows.Forms.Button();
            this.btnUpperLower = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnOnlyOneSpace = new System.Windows.Forms.Button();
            this.btnInvertWord = new System.Windows.Forms.Button();
            this.btnCountWord = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnConvertASCII = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.tmr500ms = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(18, 24);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(293, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Hello One 2 3";
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
            // 
            // btnRemoveSpace
            // 
            this.btnRemoveSpace.Location = new System.Drawing.Point(18, 125);
            this.btnRemoveSpace.Name = "btnRemoveSpace";
            this.btnRemoveSpace.Size = new System.Drawing.Size(127, 24);
            this.btnRemoveSpace.TabIndex = 4;
            this.btnRemoveSpace.Text = "Retirer Espaces";
            this.btnRemoveSpace.UseVisualStyleBackColor = true;
            this.btnRemoveSpace.Click += new System.EventHandler(this.button_RemoveSpace);
            // 
            // btnInvertChar
            // 
            this.btnInvertChar.Location = new System.Drawing.Point(18, 155);
            this.btnInvertChar.Name = "btnInvertChar";
            this.btnInvertChar.Size = new System.Drawing.Size(127, 24);
            this.btnInvertChar.TabIndex = 5;
            this.btnInvertChar.Text = "Inverser Caractères";
            this.btnInvertChar.UseVisualStyleBackColor = true;
            this.btnInvertChar.Click += new System.EventHandler(this.button_InvertChar);
            // 
            // btnDoubleChar
            // 
            this.btnDoubleChar.Location = new System.Drawing.Point(18, 185);
            this.btnDoubleChar.Name = "btnDoubleChar";
            this.btnDoubleChar.Size = new System.Drawing.Size(127, 24);
            this.btnDoubleChar.TabIndex = 6;
            this.btnDoubleChar.Text = "Doubler Caractères";
            this.btnDoubleChar.UseVisualStyleBackColor = true;
            this.btnDoubleChar.Click += new System.EventHandler(this.button_DoubleChar);
            // 
            // btnSkipOneChar
            // 
            this.btnSkipOneChar.Location = new System.Drawing.Point(18, 215);
            this.btnSkipOneChar.Name = "btnSkipOneChar";
            this.btnSkipOneChar.Size = new System.Drawing.Size(127, 24);
            this.btnSkipOneChar.TabIndex = 7;
            this.btnSkipOneChar.Text = "Sauter 1 Caractère";
            this.btnSkipOneChar.UseVisualStyleBackColor = true;
            this.btnSkipOneChar.Click += new System.EventHandler(this.button_SkipOneChar);
            // 
            // btnUpperLower
            // 
            this.btnUpperLower.Location = new System.Drawing.Point(18, 245);
            this.btnUpperLower.Name = "btnUpperLower";
            this.btnUpperLower.Size = new System.Drawing.Size(127, 24);
            this.btnUpperLower.TabIndex = 8;
            this.btnUpperLower.Text = "Maj-Min";
            this.btnUpperLower.UseVisualStyleBackColor = true;
            this.btnUpperLower.Click += new System.EventHandler(this.button_MajMin);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(18, 275);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(127, 24);
            this.btnPassword.TabIndex = 9;
            this.btnPassword.Text = "Mot De Passe";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.button_Password);
            // 
            // btnOnlyOneSpace
            // 
            this.btnOnlyOneSpace.Location = new System.Drawing.Point(184, 125);
            this.btnOnlyOneSpace.Name = "btnOnlyOneSpace";
            this.btnOnlyOneSpace.Size = new System.Drawing.Size(127, 24);
            this.btnOnlyOneSpace.TabIndex = 10;
            this.btnOnlyOneSpace.Text = "1 Seul Espace";
            this.btnOnlyOneSpace.UseVisualStyleBackColor = true;
            this.btnOnlyOneSpace.Click += new System.EventHandler(this.button_OnlyOneSpace);
            // 
            // btnInvertWord
            // 
            this.btnInvertWord.Location = new System.Drawing.Point(184, 155);
            this.btnInvertWord.Name = "btnInvertWord";
            this.btnInvertWord.Size = new System.Drawing.Size(127, 24);
            this.btnInvertWord.TabIndex = 11;
            this.btnInvertWord.Text = "Inverse Mots";
            this.btnInvertWord.UseVisualStyleBackColor = true;
            this.btnInvertWord.Click += new System.EventHandler(this.button_InvertWord);
            // 
            // btnCountWord
            // 
            this.btnCountWord.Location = new System.Drawing.Point(184, 185);
            this.btnCountWord.Name = "btnCountWord";
            this.btnCountWord.Size = new System.Drawing.Size(127, 24);
            this.btnCountWord.TabIndex = 12;
            this.btnCountWord.Text = "Compte Mots";
            this.btnCountWord.UseVisualStyleBackColor = true;
            this.btnCountWord.Click += new System.EventHandler(this.button_CountWord);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(184, 215);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(127, 24);
            this.btnRotate.TabIndex = 13;
            this.btnRotate.Text = "Rotation";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.button_Rotate);
            // 
            // btnConvertASCII
            // 
            this.btnConvertASCII.Location = new System.Drawing.Point(184, 245);
            this.btnConvertASCII.Name = "btnConvertASCII";
            this.btnConvertASCII.Size = new System.Drawing.Size(127, 24);
            this.btnConvertASCII.TabIndex = 14;
            this.btnConvertASCII.Text = "ASCII";
            this.btnConvertASCII.UseVisualStyleBackColor = true;
            this.btnConvertASCII.Click += new System.EventHandler(this.button_Ascii);
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
            // tmr500ms
            // 
            this.tmr500ms.Interval = 500;
            this.tmr500ms.Tick += new System.EventHandler(this.tmr500ms_Tick);
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(341, 350);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.btnConvertASCII);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnCountWord);
            this.Controls.Add(this.btnInvertWord);
            this.Controls.Add(this.btnOnlyOneSpace);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnUpperLower);
            this.Controls.Add(this.btnSkipOneChar);
            this.Controls.Add(this.btnDoubleChar);
            this.Controls.Add(this.btnInvertChar);
            this.Controls.Add(this.btnRemoveSpace);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "frmLab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button btnRemoveSpace;
        private System.Windows.Forms.Button btnInvertChar;
        private System.Windows.Forms.Button btnDoubleChar;
        private System.Windows.Forms.Button btnSkipOneChar;
        private System.Windows.Forms.Button btnUpperLower;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnOnlyOneSpace;
        private System.Windows.Forms.Button btnInvertWord;
        private System.Windows.Forms.Button btnCountWord;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnConvertASCII;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Timer tmr500ms;
    }
}

