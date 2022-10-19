using System.Drawing;
using System;
using System.Windows.Forms;

namespace Lab4_StationMeteo_JGM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.red;
            }*/
            toolStripStatusLabel1.Text = serialPort1.PortName + ":" + serialPort1.BaudRate.ToString() + "," + serialPort1.Parity.ToString() + "," + serialPort1.DataBits.ToString() + "," + serialPort1.StopBits.ToString();
            if (serialPort1.IsOpen)
            {
                toolStripStatusLabel2.Text = "Opened";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Green;  // Change la couleur du texte
            }
            else
            {
                toolStripStatusLabel2.Text = "Closed";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Red;    // Change la couleur du texte
            }
        }

        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}