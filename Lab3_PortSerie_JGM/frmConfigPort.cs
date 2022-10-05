using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Lab3_PortSerie_JGM
{
    public partial class frmConfigPort : Form
    {
        //variables membres de la classe frmConfigPort
        public string m_nom { get; set; }
        public int m_vitesse { get; set; }
        public int m_nbBit { get; set; }
        public Parity m_parite { get; set; }
        public int m_stopBit { get; set; }

        public frmConfigPort(string nom, int vitesse, int nbBit, Parity parite, StopBits stopBit)
        {
            InitializeComponent();

            cb_port.DataSource = SerialPort.GetPortNames();
            cb_baudrate.DataSource = new int[] { 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };
            cb_parity.DataSource = Enum.GetValues(typeof(Parity));
            cb_dataBits.DataSource = new int[] { 7, 8 };
            cb_stopBits.DataSource = new int[] { 1, 2 };//Enum.GetValues(typeof(StopBits));  // Not working :(

            cb_port.SelectedItem = nom;
            cb_baudrate.SelectedItem = vitesse;
            cb_parity.SelectedItem = parite; // Pour récupérer du comboBox
            cb_dataBits.SelectedItem = nbBit;
            cb_stopBits.SelectedItem = stopBit;

            //m_nom = nom;
            //m_vitesse = vitesse;
            //m_nbBit = nbBit;
            //m_parite = parite;
            //m_stopBit = (int)stopBit;
        }

        private void btn_configSerialPort_Click(object sender, EventArgs e)
        {
            m_nom = (string)cb_port.SelectedItem;
            m_vitesse = (int)cb_baudrate.SelectedItem;
            m_parite = (Parity)cb_parity.SelectedItem; // Pour récupérer du comboBox
            m_nbBit = (int)cb_dataBits.SelectedItem;
            m_stopBit = (int)cb_stopBits.SelectedItem;

        }
    }
}
