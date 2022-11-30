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

namespace ExerSemaine12Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Note: Effacer la série et l'area présente par défaut dans les propriétés de l'objet Chart au besoin
            //**** Cette section peut aussi se faire via l'éditeur de l'objet chart****
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            //Pour le grah du haut 
            chart1.Titles.Add("Capteurs météo");
            chart1.ChartAreas.Add("Temperature");
            chart1.ChartAreas["Temperature"].AxisX.Minimum = 0;

            //Ajout d'une première courbe
            chart1.Series.Add("T1");
            chart1.Series[0].ChartType = SeriesChartType.Line; //type xy
                                                               //chart1.Series["T1"].ChartType = SeriesChartType.Line; //Equivalent à .Series[0]

            //ajout d'une 2e courbe
            chart1.Series.Add("T2");
            chart1.Series["T2"].ChartType = SeriesChartType.Line; //type xy


            //Graph du bas (mode histogramme par défaut)
            chart1.ChartAreas.Add("Humidite"); //Ajout d'un nouveau graphique
            chart1.Series.Add("H1"); //Ajout d'une nouvelle courbe
            chart1.Series["H1"].ChartArea = "Humidite"; //Associe cette courbe au graph du bas
            chart1.Series["H1"].ChartType = SeriesChartType.Column; //Peut être omis, car celui par défaut

            for (int i = 0; i < 19; i++)
            {
                chart1.Series["T1"].Points.AddXY(i, i * i + 4);
                chart1.Series["T2"].Points.AddXY(i, (20-i)*(20-i));
                chart1.Series["H1"].Points.AddXY(i, i + 4);
            }
        }
    }
}
