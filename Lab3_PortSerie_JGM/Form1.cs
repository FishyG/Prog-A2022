using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
        }

        
        private void btn_TX_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();

            serialPort1.WriteLine(tb_tx.Text);
        }

        /// <summary>
        /// Lorsque des donn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //Crée la feuille de config. Appelle le constructeur et on lui passe la config. actuelle du port série.
            frmConfigPort fConfig = new frmConfigPort(serialPort1.PortName, serialPort1.BaudRate,
                                            serialPort1.DataBits, serialPort1.Parity, serialPort1.StopBits);

            //Ouvre la fenêtre de config et attend que l'usager la ferme par le bouton OK ou Annuler
            if (fConfig.ShowDialog() == DialogResult.OK) //Note: La propriété DialogResult du bouton ok doit être à OK.
            {
                if (serialPort1.IsOpen) // Ferme le port si il est déja ouvert
                    serialPort1.Close();
                //On récupère les informations de configurations et on les assignent à au port série
                serialPort1.PortName = fConfig.m_nom;
                serialPort1.BaudRate = fConfig.m_vitesse;
                serialPort1.Parity = fConfig.m_parite; // Pour récupérer du comboBox
                serialPort1.DataBits = fConfig.m_nbBit;
                serialPort1.StopBits = (StopBits)fConfig.m_stopBit;
            }

            if (serialPort1.DataBits == 7)
                serialPort1.Encoding = Encoding.GetEncoding(20127); // Set l'encodage en mode US-Ascii (20127)
            else if (serialPort1.DataBits == 8)
                serialPort1.Encoding = Encoding.GetEncoding(28591); // Set l'encodage en mode iso-8859-1 (28591)
            else
                MessageBox.Show("Unsupported databits","Error");   // Affiche un message d'erreur si les data bits sont autre que 7 ou 8
        }

        private void btn_OpenSerialPort_Click(object sender, EventArgs e)
        {
            if (btn_OpenSerialPort.Text == "Open")
            {
                DialogResult result = DialogResult.OK;
                do
                {
                    try
                    {
                        if (serialPort1.PortName != null)
                        {
                            if (!serialPort1.IsOpen) // ouvre le port si il n'est pas déja ouvert
                            {
                                serialPort1.Open();
                            }
                        }
                        else
                            MessageBox.Show("Invalid port, choose a port ", "Invalid port", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        result = MessageBox.Show("Access is denied on port " + serialPort1.PortName, serialPort1.PortName + " ACCESS DENIED O_o", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);   // Affiche un message d'erreur si l'opération est invalide
                    }
                    catch (System.IO.IOException)
                    {
                        result = MessageBox.Show("The port " + serialPort1.PortName + " does not exist.", serialPort1.PortName + " IS INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                    }
                } while (result == DialogResult.Retry);
            }
            else
            {
                DialogResult result = DialogResult.OK;
                do
                {
                    try
                    {
                        if (serialPort1.IsOpen) // ferme le port si il est déja ouvert
                            serialPort1.Close();
                    }
                    catch (Exception)
                    {
                        result = MessageBox.Show("Cannot close port " + serialPort1.PortName, serialPort1.PortName + " NOT CLOSED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);   // Affiche un message d'erreur si l'opération est invalide
                    }
                } while (result == DialogResult.Retry);
            }

            toolStripStatusLabel1.Text = serialPort1.PortName + ":" + serialPort1.BaudRate.ToString() + "," + serialPort1.Parity.ToString() + "," + serialPort1.DataBits.ToString() + "," + serialPort1.StopBits.ToString();
            if (serialPort1.IsOpen)
            {
                btn_TX.Enabled = true;
                btn_OpenSerialPort.Text = "Close";
                toolStripStatusLabel2.Text = "Opened";
                toolStripStatusLabel2.ForeColor = Color.Green;
            }
            else
            {
                btn_TX.Enabled = false;
                btn_OpenSerialPort.Text = "Open";
                toolStripStatusLabel2.Text = "Closed";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // ferme le port si il est déja ouvert
                serialPort1.Close();
            Application.Exit();
        }
    }
}
