namespace Exam2RxEtu2022
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
            this.components = new System.ComponentModel.Container();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbRx = new System.Windows.Forms.ListBox();
            this.btnRx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMetAJour = new System.Windows.Forms.Button();
            this.tbEqB = new System.Windows.Forms.TextBox();
            this.tbEqA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCombat = new System.Windows.Forms.Button();
            this.btnEffaceLBoxRX = new System.Windows.Forms.Button();
            this.tb_Debug = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.ForeColor = System.Drawing.Color.Red;
            this.btnOuvrir.Location = new System.Drawing.Point(147, 10);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(62, 23);
            this.btnOuvrir.TabIndex = 3;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(6, 10);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lbRx
            // 
            this.lbRx.FormattingEnabled = true;
            this.lbRx.Location = new System.Drawing.Point(246, 23);
            this.lbRx.Name = "lbRx";
            this.lbRx.Size = new System.Drawing.Size(351, 147);
            this.lbRx.TabIndex = 4;
            // 
            // btnRx
            // 
            this.btnRx.Location = new System.Drawing.Point(606, 42);
            this.btnRx.Name = "btnRx";
            this.btnRx.Size = new System.Drawing.Size(142, 30);
            this.btnRx.TabIndex = 5;
            this.btnRx.Text = "Rx";
            this.btnRx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Si Delegate ne fonctionne pas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Équipe 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Équipe 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Équipe 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Équipe 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Réception:";
            // 
            // btnMetAJour
            // 
            this.btnMetAJour.Location = new System.Drawing.Point(29, 394);
            this.btnMetAJour.Name = "btnMetAJour";
            this.btnMetAJour.Size = new System.Drawing.Size(142, 30);
            this.btnMetAJour.TabIndex = 5;
            this.btnMetAJour.Text = "Met à jour";
            this.btnMetAJour.UseVisualStyleBackColor = true;
            this.btnMetAJour.Click += new System.EventHandler(this.btnMetAJour_Click);
            // 
            // tbEqB
            // 
            this.tbEqB.Location = new System.Drawing.Point(414, 392);
            this.tbEqB.Margin = new System.Windows.Forms.Padding(2);
            this.tbEqB.Name = "tbEqB";
            this.tbEqB.Size = new System.Drawing.Size(29, 20);
            this.tbEqB.TabIndex = 9;
            this.tbEqB.Text = "2";
            this.tbEqB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tbEqA
            // 
            this.tbEqA.Location = new System.Drawing.Point(319, 392);
            this.tbEqA.Margin = new System.Windows.Forms.Padding(2);
            this.tbEqA.Name = "tbEqA";
            this.tbEqA.Size = new System.Drawing.Size(29, 20);
            this.tbEqA.TabIndex = 10;
            this.tbEqA.Text = "1";
            this.tbEqA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contre";
            // 
            // btnCombat
            // 
            this.btnCombat.Enabled = false;
            this.btnCombat.Location = new System.Drawing.Point(319, 422);
            this.btnCombat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCombat.Name = "btnCombat";
            this.btnCombat.Size = new System.Drawing.Size(123, 27);
            this.btnCombat.TabIndex = 11;
            this.btnCombat.Text = "Combat";
            this.btnCombat.UseVisualStyleBackColor = false;
            this.btnCombat.Click += new System.EventHandler(this.btnCombat_Click);
            // 
            // btnEffaceLBoxRX
            // 
            this.btnEffaceLBoxRX.Location = new System.Drawing.Point(606, 135);
            this.btnEffaceLBoxRX.Name = "btnEffaceLBoxRX";
            this.btnEffaceLBoxRX.Size = new System.Drawing.Size(142, 35);
            this.btnEffaceLBoxRX.TabIndex = 12;
            this.btnEffaceLBoxRX.Text = "Efface ListBox";
            this.btnEffaceLBoxRX.UseVisualStyleBackColor = true;
            this.btnEffaceLBoxRX.Click += new System.EventHandler(this.btnEffaceLBoxRX_Click);
            // 
            // tb_Debug
            // 
            this.tb_Debug.Location = new System.Drawing.Point(572, 429);
            this.tb_Debug.Name = "tb_Debug";
            this.tb_Debug.Size = new System.Drawing.Size(216, 20);
            this.tb_Debug.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pour DEBUG ne pas tenir compte :)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Debug);
            this.Controls.Add(this.btnEffaceLBoxRX);
            this.Controls.Add(this.btnCombat);
            this.Controls.Add(this.tbEqA);
            this.Controls.Add(this.tbEqB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMetAJour);
            this.Controls.Add(this.btnRx);
            this.Controls.Add(this.lbRx);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.comboBoxPort);
            this.Name = "Form1";
            this.Text = "Examen 2 partie Rx 2022 Etu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox lbRx;
        private System.Windows.Forms.Button btnRx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMetAJour;
        private System.Windows.Forms.TextBox tbEqB;
        private System.Windows.Forms.TextBox tbEqA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCombat;
        private System.Windows.Forms.Button btnEffaceLBoxRX;
        private System.Windows.Forms.TextBox tb_Debug;
        private System.Windows.Forms.Label label8;
    }
}

