using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoGraphEtInterpol
{
    public partial class Form1 : Form
    {
        private double x1, y1, x2, y2, m, b;

        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Note: Effacer la série et l'area présente par défaut dans les propriétés de l'objet Chart au besoin
            //**** Cette section peut aussi se faire via l'éditeur de l'objet chart****
            chartGraph.Series.Clear();
            chartGraph.ChartAreas.Clear();

            //Pour le grah du haut 
            chartGraph.Titles.Add("Capteurs météo");
            chartGraph.ChartAreas.Add("Test");

            //Ajout d'une première courbe
            chartGraph.Series.Add("T1");
            chartGraph.Series["T1"].ChartType = SeriesChartType.Line; //type xy

        }

        private void textBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08) && (e.KeyChar != '-') && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            chartGraph.Series["T1"].Points.Clear();
            try
            {
                x1 = Convert.ToDouble(textBoxX1.Text);
                x2 = Convert.ToDouble(textBoxX2.Text);
                y1 = Convert.ToDouble(textBoxY1.Text);
                y2 = Convert.ToDouble(textBoxY2.Text);
                //x = Convert.ToDouble(textBoxX.Text);

                chartGraph.ChartAreas["Test"].AxisX.Minimum = x1;
                chartGraph.ChartAreas["Test"].AxisX.Maximum = x2;
                chartGraph.ChartAreas["Test"].AxisY.Minimum = y1;
                chartGraph.ChartAreas["Test"].AxisY.Maximum = y2;

                m = (y2 - y1) / (x2 - x1);
                b = y1 - (m * x1);

                //chartGraph.Series["T1"].Points.AddXY(x1,y1);
                //chartGraph.Series["T1"].Points.AddXY(x2,y2);

                for(int i = Convert.ToInt32(x1); i <= x2; i++)
                    chartGraph.Series["T1"].Points.AddXY(i, ((m*i) + b));

                //chartGraph.Series
            }
            catch(Exception)
            {
                MessageBox.Show("error", "Please fix");
            }

        }

    }
}
