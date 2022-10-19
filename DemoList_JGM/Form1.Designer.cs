namespace DemoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tboxPosition = new System.Windows.Forms.TextBox();
            this.btnBas = new System.Windows.Forms.Button();
            this.btnHaut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(89, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 26);
            this.textBox2.TabIndex = 2;
            // 
            // tboxPosition
            // 
            this.tboxPosition.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPosition.Location = new System.Drawing.Point(517, 184);
            this.tboxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tboxPosition.Name = "tboxPosition";
            this.tboxPosition.Size = new System.Drawing.Size(57, 26);
            this.tboxPosition.TabIndex = 3;
            this.tboxPosition.Text = "5";
            // 
            // btnBas
            // 
            this.btnBas.Image = ((System.Drawing.Image)(resources.GetObject("btnBas.Image")));
            this.btnBas.Location = new System.Drawing.Point(521, 43);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(53, 49);
            this.btnBas.TabIndex = 4;
            this.btnBas.UseVisualStyleBackColor = true;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // btnHaut
            // 
            this.btnHaut.Image = ((System.Drawing.Image)(resources.GetObject("btnHaut.Image")));
            this.btnHaut.Location = new System.Drawing.Point(521, 107);
            this.btnHaut.Name = "btnHaut";
            this.btnHaut.Size = new System.Drawing.Size(53, 49);
            this.btnHaut.TabIndex = 4;
            this.btnHaut.UseVisualStyleBackColor = true;
            this.btnHaut.Click += new System.EventHandler(this.btnHaut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position:";
            // 
            // btnEchange
            // 
            this.btnEchange.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEchange.Location = new System.Drawing.Point(358, 231);
            this.btnEchange.Margin = new System.Windows.Forms.Padding(2);
            this.btnEchange.Name = "btnEchange";
            this.btnEchange.Size = new System.Drawing.Size(216, 33);
            this.btnEchange.TabIndex = 6;
            this.btnEchange.Text = "Échange position:";
            this.btnEchange.UseVisualStyleBackColor = true;
            this.btnEchange.Click += new System.EventHandler(this.btnEchange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 288);
            this.Controls.Add(this.btnEchange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHaut);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.tboxPosition);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DemoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tboxPosition;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.Button btnHaut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEchange;
    }
}

