namespace DemoServeurUDP
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.listRxTrame = new System.Windows.Forms.ListBox();
            this.votesDataGridView = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.chartVotes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDepartVotation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.votesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réception des trames";
            // 
            // listRxTrame
            // 
            this.listRxTrame.FormattingEnabled = true;
            this.listRxTrame.ItemHeight = 16;
            this.listRxTrame.Location = new System.Drawing.Point(12, 31);
            this.listRxTrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRxTrame.Name = "listRxTrame";
            this.listRxTrame.Size = new System.Drawing.Size(404, 324);
            this.listRxTrame.TabIndex = 3;
            // 
            // votesDataGridView
            // 
            this.votesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.votesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.votesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.votesDataGridView.Location = new System.Drawing.Point(443, 31);
            this.votesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.votesDataGridView.Name = "votesDataGridView";
            this.votesDataGridView.ReadOnly = true;
            this.votesDataGridView.RowHeadersWidth = 51;
            this.votesDataGridView.RowTemplate.Height = 24;
            this.votesDataGridView.Size = new System.Drawing.Size(406, 324);
            this.votesDataGridView.TabIndex = 4;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Noms";
            this.Col1.MinimumWidth = 6;
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col1.Width = 49;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Votes";
            this.Col2.MinimumWidth = 6;
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col2.Width = 48;
            // 
            // Col3
            // 
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.Col3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col3.HeaderText = "Pourcentage";
            this.Col3.MinimumWidth = 6;
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col3.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // chartVotes
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVotes.ChartAreas.Add(chartArea2);
            this.chartVotes.Location = new System.Drawing.Point(871, 31);
            this.chartVotes.Margin = new System.Windows.Forms.Padding(4);
            this.chartVotes.Name = "chartVotes";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartVotes.Series.Add(series2);
            this.chartVotes.Size = new System.Drawing.Size(536, 324);
            this.chartVotes.TabIndex = 12;
            this.chartVotes.Text = "Votes";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1236, 382);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(171, 38);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDepartVotation
            // 
            this.btnDepartVotation.Location = new System.Drawing.Point(940, 382);
            this.btnDepartVotation.Name = "btnDepartVotation";
            this.btnDepartVotation.Size = new System.Drawing.Size(171, 38);
            this.btnDepartVotation.TabIndex = 16;
            this.btnDepartVotation.Text = "Départ votation";
            this.btnDepartVotation.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 437);
            this.Controls.Add(this.btnDepartVotation);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.chartVotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.votesDataGridView);
            this.Controls.Add(this.listRxTrame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Demo Examen final 2022 (prof)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.votesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRxTrame;
        private System.Windows.Forms.DataGridView votesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVotes;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDepartVotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
    }
}

