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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_PortSerie_JGM
{
    public partial class Form1 : Form
    {
        public delegate void myProtoDelegate(string lineReceived);
        myProtoDelegate objDelegate;
        public Form1()
        {
            objDelegate = methodeDelegeAffiche;   //nouvelle méthode depuis C#2.0
            InitializeComponent();

            if (serialPort1.IsOpen) // Ferme le port si il est déja ouvert
                serialPort1.Close();

            cb_port.DataSource = SerialPort.GetPortNames();
            cb_baudrate.DataSource = new int[] { 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };
            cb_parity.DataSource = Enum.GetValues(typeof(Parity));
            cb_dataBits.DataSource = new int[] { 7, 8 };
            cb_stopBits.DataSource = new int[] { 1, 2 };//Enum.GetValues(typeof(StopBits));  // Not working :(
        }

        
        private void btn_TX_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();   
            serialPort1.WriteLine(tb_tx.Text);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string lineReceived;
            lineReceived = serialPort1.ReadLine();
            BeginInvoke(objDelegate, lineReceived);
        }
        /// <summary>
        /// Méthode delegate qui sera appelée par le thread de réception de caractères sur le port série
        /// </summary>
        /// <param name="lineReceived"></param>
        private void methodeDelegeAffiche(string lineReceived)
        {
            tb_rx.Text = lineReceived;
        }

        private void btn_configSerialPort_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen) // Ferme le port si il est déja ouvert
                serialPort1.Close();

            serialPort1.PortName = (string)cb_port.SelectedItem;
            serialPort1.BaudRate = (int)cb_baudrate.SelectedItem;
            serialPort1.Parity = (Parity)cb_parity.SelectedItem; // Pour récupérer du comboBox
            serialPort1.DataBits = (int)cb_dataBits.SelectedItem;
            serialPort1.StopBits = (StopBits)cb_stopBits.SelectedItem;

            if (serialPort1.DataBits == 7)
                serialPort1.Encoding = Encoding.GetEncoding(20127); // Set l'encodage en mode US-Ascii (20127)
            else if (serialPort1.DataBits == 8)
                serialPort1.Encoding = Encoding.GetEncoding(28591); // Set l'encodage en mode iso-8859-1 (28591)
            else
                //MessageBox.Show(serialPort1.DataBits);   // Affiche un message d'erreur si les data bits sont autre que 7 ou 8

            try
            {
                if (!serialPort1.IsOpen) // ouvre le port si il n'est pas déja ouvert
                    serialPort1.Open();
            }
            catch(System.UnauthorizedAccessException)
            {
                MessageBox.Show("Access is denied on port " + (string)cb_port.SelectedItem);   // Affiche un message d'erreur si l'opération est invalide
            }
            catch (Exception )
            {

                throw;
            }
        }
    }
}
