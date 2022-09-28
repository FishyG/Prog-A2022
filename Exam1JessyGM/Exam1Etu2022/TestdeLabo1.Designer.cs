namespace TestLabo1
{
    partial class ExamenLabo1
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
        /// the contents of this method with the code editor
        ///  2012
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInverse = new System.Windows.Forms.Button();
            this.tbSaisieQ1 = new System.Windows.Forms.TextBox();
            this.btnTourne = new System.Windows.Forms.Button();
            this.monTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQ3 = new System.Windows.Forms.ListBox();
            this.btnNvJoueur = new System.Windows.Forms.Button();
            this.comboBoxQ3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(64, 97);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(159, 23);
            this.btnInverse.TabIndex = 10;
            this.btnInverse.Text = "Inverse au #";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // tbSaisieQ1
            // 
            this.tbSaisieQ1.Location = new System.Drawing.Point(25, 53);
            this.tbSaisieQ1.Name = "tbSaisieQ1";
            this.tbSaisieQ1.Size = new System.Drawing.Size(262, 20);
            this.tbSaisieQ1.TabIndex = 0;
            this.tbSaisieQ1.Text = "123";
            this.tbSaisieQ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaisieQ1_KeyPress);
            // 
            // btnTourne
            // 
            this.btnTourne.Location = new System.Drawing.Point(320, 51);
            this.btnTourne.Name = "btnTourne";
            this.btnTourne.Size = new System.Drawing.Size(135, 23);
            this.btnTourne.TabIndex = 9;
            this.btnTourne.Text = "Tourne";
            this.btnTourne.UseVisualStyleBackColor = true;
            this.btnTourne.Click += new System.EventHandler(this.btnTourne_Click);
            // 
            // monTimer
            // 
            this.monTimer.Interval = 1000;
            this.monTimer.Tick += new System.EventHandler(this.monTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Question 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Question 3";
            // 
            // lbQ3
            // 
            this.lbQ3.FormattingEnabled = true;
            this.lbQ3.Location = new System.Drawing.Point(559, 137);
            this.lbQ3.Name = "lbQ3";
            this.lbQ3.Size = new System.Drawing.Size(311, 264);
            this.lbQ3.TabIndex = 5;
            this.lbQ3.DoubleClick += new System.EventHandler(this.lbQ3_DoubleClick);
            // 
            // btnNvJoueur
            // 
            this.btnNvJoueur.Location = new System.Drawing.Point(723, 53);
            this.btnNvJoueur.Margin = new System.Windows.Forms.Padding(2);
            this.btnNvJoueur.Name = "btnNvJoueur";
            this.btnNvJoueur.Size = new System.Drawing.Size(147, 22);
            this.btnNvJoueur.TabIndex = 0;
            this.btnNvJoueur.Text = "NouveauJoeur";
            this.btnNvJoueur.UseVisualStyleBackColor = true;
            this.btnNvJoueur.Click += new System.EventHandler(this.btnNvJoueur_Click);
            // 
            // comboBoxQ3
            // 
            this.comboBoxQ3.FormattingEnabled = true;
            this.comboBoxQ3.Location = new System.Drawing.Point(567, 53);
            this.comboBoxQ3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxQ3.Name = "comboBoxQ3";
            this.comboBoxQ3.Size = new System.Drawing.Size(140, 21);
            this.comboBoxQ3.TabIndex = 6;
            // 
            // ExamenLabo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 570);
            this.Controls.Add(this.comboBoxQ3);
            this.Controls.Add(this.btnNvJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbQ3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTourne);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.tbSaisieQ1);
            this.Name = "ExamenLabo1";
            this.Tag = "2012";
            this.Text = "Exam #1 Aut2022, Jessy Grimard-Maheu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSaisieQ1;
        private System.Windows.Forms.Button btnTourne;
        private System.Windows.Forms.Timer monTimer;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbQ3;
        private System.Windows.Forms.Button btnNvJoueur;
        private System.Windows.Forms.ComboBox comboBoxQ3;
    }
}

