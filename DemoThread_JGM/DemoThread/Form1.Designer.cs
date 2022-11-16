namespace DemoThread
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMAJ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAffiche = new System.Windows.Forms.TextBox();
            this.btnReprendre = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMAJ
            // 
            this.btnMAJ.Location = new System.Drawing.Point(201, 68);
            this.btnMAJ.Name = "btnMAJ";
            this.btnMAJ.Size = new System.Drawing.Size(51, 23);
            this.btnMAJ.TabIndex = 9;
            this.btnMAJ.Text = "MAJ";
            this.btnMAJ.UseVisualStyleBackColor = true;
            this.btnMAJ.Click += new System.EventHandler(this.btnMAJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compteur = ";
            // 
            // textBoxAffiche
            // 
            this.textBoxAffiche.Location = new System.Drawing.Point(120, 71);
            this.textBoxAffiche.Name = "textBoxAffiche";
            this.textBoxAffiche.Size = new System.Drawing.Size(75, 20);
            this.textBoxAffiche.TabIndex = 7;
            // 
            // btnReprendre
            // 
            this.btnReprendre.Enabled = false;
            this.btnReprendre.Location = new System.Drawing.Point(211, 115);
            this.btnReprendre.Name = "btnReprendre";
            this.btnReprendre.Size = new System.Drawing.Size(75, 23);
            this.btnReprendre.TabIndex = 4;
            this.btnReprendre.Text = "Reprendre";
            this.btnReprendre.UseVisualStyleBackColor = true;
            this.btnReprendre.Click += new System.EventHandler(this.btnReprendre_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(120, 115);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(29, 115);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(75, 23);
            this.btnDepart.TabIndex = 6;
            this.btnDepart.Text = "Départ";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 252);
            this.Controls.Add(this.btnMAJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAffiche);
            this.Controls.Add(this.btnReprendre);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnDepart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Demo Thread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMAJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAffiche;
        private System.Windows.Forms.Button btnReprendre;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnDepart;
    }
}

