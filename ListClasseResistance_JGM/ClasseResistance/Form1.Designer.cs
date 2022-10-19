namespace ClasseResistance
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
            this.tbVolt = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolt = new System.Windows.Forms.Label();
            this.lbListeRes = new System.Windows.Forms.ListBox();
            this.bAjouteR = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMetAJour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolt
            // 
            this.tbVolt.Location = new System.Drawing.Point(32, 34);
            this.tbVolt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVolt.Maximum = 30;
            this.tbVolt.Name = "tbVolt";
            this.tbVolt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolt.Size = new System.Drawing.Size(45, 107);
            this.tbVolt.TabIndex = 0;
            this.tbVolt.ValueChanged += new System.EventHandler(this.tbVolt_ValueChanged);
            this.tbVolt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbVolt_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tension";
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Location = new System.Drawing.Point(35, 151);
            this.lblVolt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(38, 13);
            this.lblVolt.TabIndex = 2;
            this.lblVolt.Text = "x Volts";
            // 
            // lbListeRes
            // 
            this.lbListeRes.FormattingEnabled = true;
            this.lbListeRes.Location = new System.Drawing.Point(155, 81);
            this.lbListeRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbListeRes.Name = "lbListeRes";
            this.lbListeRes.Size = new System.Drawing.Size(226, 95);
            this.lbListeRes.TabIndex = 3;
            this.lbListeRes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbListeRes_MouseDoubleClick);
            // 
            // bAjouteR
            // 
            this.bAjouteR.Location = new System.Drawing.Point(155, 39);
            this.bAjouteR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAjouteR.Name = "bAjouteR";
            this.bAjouteR.Size = new System.Drawing.Size(72, 22);
            this.bAjouteR.TabIndex = 5;
            this.bAjouteR.Text = "Ajoute R";
            this.bAjouteR.UseVisualStyleBackColor = true;
            this.bAjouteR.Click += new System.EventHandler(this.bAjouteR_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(155, 15);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(39, 20);
            this.textBoxR.TabIndex = 6;
            this.textBoxR.Text = "1000";
            this.textBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ohms";
            // 
            // btnMetAJour
            // 
            this.btnMetAJour.Location = new System.Drawing.Point(155, 181);
            this.btnMetAJour.Name = "btnMetAJour";
            this.btnMetAJour.Size = new System.Drawing.Size(75, 23);
            this.btnMetAJour.TabIndex = 7;
            this.btnMetAJour.Text = "Met à jour";
            this.btnMetAJour.UseVisualStyleBackColor = true;
            this.btnMetAJour.Click += new System.EventHandler(this.btnMetAJour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 243);
            this.Controls.Add(this.btnMetAJour);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.bAjouteR);
            this.Controls.Add(this.lbListeRes);
            this.Controls.Add(this.lblVolt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVolt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Démo Classe Resistance";
            ((System.ComponentModel.ISupportInitialize)(this.tbVolt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.ListBox lbListeRes;
        private System.Windows.Forms.Button bAjouteR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMetAJour;
    }
}

