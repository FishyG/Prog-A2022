namespace Exercice_Semain5___Joueur
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
            this.gbTeamA = new System.Windows.Forms.GroupBox();
            this.gbTeamB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFight = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gbTeamA
            // 
            this.gbTeamA.Location = new System.Drawing.Point(12, 12);
            this.gbTeamA.Name = "gbTeamA";
            this.gbTeamA.Size = new System.Drawing.Size(200, 126);
            this.gbTeamA.TabIndex = 0;
            this.gbTeamA.TabStop = false;
            this.gbTeamA.Text = "Équipe A";
            // 
            // gbTeamB
            // 
            this.gbTeamB.Location = new System.Drawing.Point(299, 12);
            this.gbTeamB.Name = "gbTeamB";
            this.gbTeamB.Size = new System.Drawing.Size(200, 126);
            this.gbTeamB.TabIndex = 1;
            this.gbTeamB.TabStop = false;
            this.gbTeamB.Text = "Équipe B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(218, 89);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(75, 23);
            this.btnFight.TabIndex = 3;
            this.btnFight.Text = "FIGHT !!!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(185, 144);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(142, 69);
            this.lbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 229);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTeamB);
            this.Controls.Add(this.gbTeamA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeamA;
        private System.Windows.Forms.GroupBox gbTeamB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.ListBox lbResult;
    }
}

