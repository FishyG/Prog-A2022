/*
 * @file   frmConfigPort.cs
 * @author Jessy Grimard-Maheu
 * @date   10/15/2022
 * @brief  Configuration du port série pour le cours 247-516-SH-A22.
 * Ce Form permet de configurer le port série. Il est possible de changer 
 * la vitesse de communication, le nombre de bits de parité, le nombre de 
 * data bits et le nombre de stop bits. Les ports séries disponibles sont 
 * affichés automatiquement.
 *
 * @version 1.0 : Première version
 * Environnement de développement: Visual Studio 2022
 * Matériel: Convertisseur USB -> Serial TTL ou un port série
 */

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
        public SerialPort m_serialPort { get; set; }

        public frmConfigPort(SerialPort serialPort)
        {
            InitializeComponent();

            cb_port.DataSource = SerialPort.GetPortNames();
            cb_baudrate.DataSource = new int[] { 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };
            cb_parity.DataSource = Enum.GetValues(typeof(Parity));
            cb_dataBits.DataSource = new int[] { 7, 8 };
            cb_stopBits.DataSource = new int[] { 1, 2 };//Can also use "Enum.GetValues(typeof(StopBits))" but it is currently Not working :(

            cb_port.SelectedItem = serialPort.PortName; // Pour récupérer du comboBox
            cb_baudrate.SelectedItem = serialPort.BaudRate; // Pour récupérer du comboBox
            cb_parity.SelectedItem = serialPort.Parity;    // Pour récupérer du comboBox
            cb_dataBits.SelectedItem = serialPort.DataBits;   // Pour récupérer du comboBox
            cb_stopBits.SelectedItem = serialPort.StopBits; // Pour récupérer du comboBox
        }

        private void btn_configSerialPort_Click(object sender, EventArgs e)
        {
            m_serialPort.PortName = (string)cb_port.SelectedItem;   // Applique le nom choisit
            m_serialPort.BaudRate = (int)cb_baudrate.SelectedItem;  // Applique la vitesse choisit
            m_serialPort.Parity = (Parity)cb_parity.SelectedItem;  // Applique le nombre de bits de parity choisit
            m_serialPort.DataBits = (int)cb_dataBits.SelectedItem;    // Applique le nombre de data bits choisit
            m_serialPort.StopBits = (StopBits)cb_stopBits.SelectedItem;  // Applique le nombre de stop bits choisit

        }
    }
}
