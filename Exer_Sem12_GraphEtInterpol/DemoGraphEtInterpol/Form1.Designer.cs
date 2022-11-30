namespace DemoGraphEtInterpol
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            legend4.Name = "Legend1";
            this.chartGraph.Legends.Add(legend4);
            this.chartGraph.Location = new System.Drawing.Point(0, 0);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartGraph.Size = new System.Drawing.Size(462, 232);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "Graphique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y1 =";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(47, 250);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(53, 20);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.Text = "1";
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(47, 276);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(53, 20);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.Text = "10";
            this.textBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "X2 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y2 =";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(180, 250);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(53, 20);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.Text = "10";
            this.textBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(180, 276);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(53, 20);
            this.textBoxY2.TabIndex = 2;
            this.textBoxY2.Text = "20";
            this.textBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(402, 270);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcul.TabIndex = 3;
            this.buttonCalcul.Text = "Calcul";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X =";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(309, 250);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(53, 20);
            this.textBoxX.TabIndex = 2;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y =";
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(309, 275);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(53, 20);
            this.textBoxY.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 311);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartGraph);
            this.Name = "Form1";
            this.Text = "Demo graph et interpol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxY;
    }
}

