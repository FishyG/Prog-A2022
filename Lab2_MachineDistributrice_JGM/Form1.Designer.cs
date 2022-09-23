namespace Lab2_MachineDistributrice_JGM
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
            this.components = new System.ComponentModel.Container();
            this.panelCredit = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelClavier = new System.Windows.Forms.Panel();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Affichage = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_Modif = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Colonne = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Rangee = new System.Windows.Forms.ComboBox();
            this.tmr_1Sec = new System.Windows.Forms.Timer(this.components);
            this.panelCredit.SuspendLayout();
            this.panelClavier.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCredit
            // 
            this.panelCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelCredit.Controls.Add(this.button5);
            this.panelCredit.Controls.Add(this.button4);
            this.panelCredit.Controls.Add(this.button3);
            this.panelCredit.Controls.Add(this.button2);
            this.panelCredit.Controls.Add(this.label1);
            this.panelCredit.Controls.Add(this.button1);
            this.panelCredit.Location = new System.Drawing.Point(8, 157);
            this.panelCredit.Name = "panelCredit";
            this.panelCredit.Size = new System.Drawing.Size(200, 100);
            this.panelCredit.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(65, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "2.00$";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Credit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(6, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "1.00$";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Credit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(124, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "0.25$";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Credit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(65, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "0.10$";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Credit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crédit ($):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "0.05$";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Credit_Click);
            // 
            // panelClavier
            // 
            this.panelClavier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelClavier.Controls.Add(this.btn_Enter);
            this.panelClavier.Controls.Add(this.btn_0);
            this.panelClavier.Controls.Add(this.btn_Clear);
            this.panelClavier.Controls.Add(this.btn_9);
            this.panelClavier.Controls.Add(this.btn_8);
            this.panelClavier.Controls.Add(this.btn_7);
            this.panelClavier.Controls.Add(this.btn_6);
            this.panelClavier.Controls.Add(this.btn_5);
            this.panelClavier.Controls.Add(this.btn_4);
            this.panelClavier.Controls.Add(this.btn_3);
            this.panelClavier.Controls.Add(this.btn_2);
            this.panelClavier.Controls.Add(this.btn_1);
            this.panelClavier.Controls.Add(this.label2);
            this.panelClavier.Location = new System.Drawing.Point(245, 157);
            this.panelClavier.Name = "panelClavier";
            this.panelClavier.Size = new System.Drawing.Size(200, 176);
            this.panelClavier.TabIndex = 1;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.DimGray;
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Enter.Location = new System.Drawing.Point(130, 123);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(56, 23);
            this.btn_Enter.TabIndex = 11;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.DimGray;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_0.Location = new System.Drawing.Point(68, 123);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(56, 23);
            this.btn_0.TabIndex = 0;
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(6, 123);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(56, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.DimGray;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_9.Location = new System.Drawing.Point(130, 94);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(56, 23);
            this.btn_9.TabIndex = 9;
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.DimGray;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_8.Location = new System.Drawing.Point(68, 94);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(56, 23);
            this.btn_8.TabIndex = 8;
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.DimGray;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_7.Location = new System.Drawing.Point(6, 94);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(56, 23);
            this.btn_7.TabIndex = 7;
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.DimGray;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_6.Location = new System.Drawing.Point(130, 65);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(56, 23);
            this.btn_6.TabIndex = 6;
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.DimGray;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_5.Location = new System.Drawing.Point(68, 65);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(56, 23);
            this.btn_5.TabIndex = 5;
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.DimGray;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_4.Location = new System.Drawing.Point(6, 65);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(56, 23);
            this.btn_4.TabIndex = 4;
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.DimGray;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_3.Location = new System.Drawing.Point(130, 36);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(56, 23);
            this.btn_3.TabIndex = 3;
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.DimGray;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_2.Location = new System.Drawing.Point(68, 36);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(56, 23);
            this.btn_2.TabIndex = 2;
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.DimGray;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_1.Location = new System.Drawing.Point(6, 36);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(56, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.ClavierABC123_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Clavier:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 367);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.lb_Affichage);
            this.tabPage1.Controls.Add(this.panelClavier);
            this.tabPage1.Controls.Add(this.panelCredit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Achat";
            // 
            // lb_Affichage
            // 
            this.lb_Affichage.FormattingEnabled = true;
            this.lb_Affichage.Location = new System.Drawing.Point(14, 17);
            this.lb_Affichage.Name = "lb_Affichage";
            this.lb_Affichage.Size = new System.Drawing.Size(417, 108);
            this.lb_Affichage.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.tb_Quantity);
            this.tabPage2.Controls.Add(this.tb_Price);
            this.tabPage2.Controls.Add(this.btn_Modif);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cb_Colonne);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cb_Rangee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventaire";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(296, 76);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(121, 20);
            this.tb_Quantity.TabIndex = 10;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(296, 50);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(121, 20);
            this.tb_Price.TabIndex = 9;
            // 
            // btn_Modif
            // 
            this.btn_Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modif.Location = new System.Drawing.Point(274, 102);
            this.btn_Modif.Name = "btn_Modif";
            this.btn_Modif.Size = new System.Drawing.Size(143, 23);
            this.btn_Modif.TabIndex = 8;
            this.btn_Modif.Text = "Modifier inventaire";
            this.btn_Modif.UseVisualStyleBackColor = true;
            this.btn_Modif.Click += new System.EventHandler(this.btn_Modif_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(212, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(212, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colonne";
            // 
            // cb_Colonne
            // 
            this.cb_Colonne.BackColor = System.Drawing.Color.Gray;
            this.cb_Colonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Colonne.FormattingEnabled = true;
            this.cb_Colonne.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_Colonne.Location = new System.Drawing.Point(72, 75);
            this.cb_Colonne.Name = "cb_Colonne";
            this.cb_Colonne.Size = new System.Drawing.Size(121, 21);
            this.cb_Colonne.TabIndex = 2;
            this.cb_Colonne.SelectedIndex = 0;
            this.cb_Colonne.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rangée";
            // 
            // cb_Rangee
            // 
            this.cb_Rangee.BackColor = System.Drawing.Color.Gray;
            this.cb_Rangee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Rangee.FormattingEnabled = true;
            this.cb_Rangee.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cb_Rangee.Location = new System.Drawing.Point(72, 48);
            this.cb_Rangee.Name = "cb_Rangee";
            this.cb_Rangee.Size = new System.Drawing.Size(121, 21);
            this.cb_Rangee.TabIndex = 0;
            this.cb_Rangee.SelectedIndex = 0;
            this.cb_Rangee.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // tmr_1Sec
            // 
            this.tmr_1Sec.Interval = 1000;
            this.tmr_1Sec.Tick += new System.EventHandler(this.tmr_1Sec_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(461, 366);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCredit.ResumeLayout(false);
            this.panelCredit.PerformLayout();
            this.panelClavier.ResumeLayout(false);
            this.panelClavier.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelClavier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Rangee;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Modif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Colonne;
        private System.Windows.Forms.ListBox lb_Affichage;
        private System.Windows.Forms.Timer tmr_1Sec;
    }
}

