/*
 * @file   Form1.cs
 * @author Jessy Grimard-Maheu
 * @date   10/15/2022
 * @brief  LaboCommSerie(lab3) pour le cours 247-516-SH-A22.
 * Le but de ce laboratoire est de concevoir un programme qui envoie et reçoit des caractères 
 * sur un port série. Il est possible d'envoyer et de recevoir une ligne à la fois. Le texte
 * dans la textBox "Text to TX" est le texte qui sera envoyé. Le port série est configurable,
 * il est possible de changer la vitesse de communication, le nombre de bits de parité, le
 * nombre de data bits et le nombre de stop bits. La fenêtre principale contient uniquement
 * le texte recu et le texte à envoyer. La configuration du port série se fait dans une 
 * fenêtre séparée. Le bouton "Config" permet d'ouvrir la fenêtre de configuration.
 *
 * @version 1.0 : Première version
 * Environnement de développement: Visual Studio 2022
 * Matériel: Convertisseur USB -> Serial TTL ou un port série
 */

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

            // Affichage de la toolStrip avec les informations du port série
            toolStripStatusLabel1.Text = serialPort1.PortName + ":" + serialPort1.BaudRate.ToString() + "," + serialPort1.Parity.ToString() + "," + serialPort1.DataBits.ToString() + "," + serialPort1.StopBits.ToString();
            if (serialPort1.IsOpen)
            {
                btn_TX.Enabled = true;  // Activation du bouton
                btn_OpenSerialPort.Text = "Close";  // Change le texte
                toolStripStatusLabel2.Text = "Opened";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Green;  // Change la couleur du texte
            }
            else
            {
                btn_TX.Enabled = false; // Désactivation du bouton
                btn_OpenSerialPort.Text = "Open";   // Change le texte
                toolStripStatusLabel2.Text = "Closed";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Red;    // Change la couleur du texte
            }
        }
        
        private void btn_TX_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)    // Ouvre le port s'il n'est pas déja ouvert (very unlikely)
                    serialPort1.Open();

                serialPort1.WriteLine(tb_tx.Text);  // Écriture de la ligne
            }
            catch (System.IO.IOException)
            {
                // Affiche un message d'erreur si le port est débranché
                MessageBox.Show("The port " + serialPort1.PortName + " was removed.", serialPort1.PortName + " IS INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                btn_OpenSerialPort.PerformClick();
            }
        }

        /// <summary>
        /// Lorsque des données sont reçu sur le port série
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
                if (fConfig.m_nom == null)
                    MessageBox.Show("No COM port", "Error");   // Affiche un message d'erreur si il n'y a pas de ports
                else
                serialPort1.PortName = fConfig.m_nom;
                
                serialPort1.BaudRate = fConfig.m_vitesse;
                serialPort1.Parity = fConfig.m_parite;
                serialPort1.DataBits = fConfig.m_nbBit;
                serialPort1.StopBits = (StopBits)fConfig.m_stopBit;
            }

            if (serialPort1.DataBits == 7)
                serialPort1.Encoding = Encoding.GetEncoding(20127); // Set l'encodage en mode US-Ascii (20127)
            else if (serialPort1.DataBits == 8)
                serialPort1.Encoding = Encoding.GetEncoding(28591); // Set l'encodage en mode iso-8859-1 (28591)
            else
                MessageBox.Show("Unsupported databits","Error");   // Affiche un message d'erreur si les data bits sont autre que 7 ou 8
            btn_OpenSerialPort.Text = "Open";   // Change le text afin de forcé une ouverture du port
            btn_OpenSerialPort.PerformClick();  // Ouverture du port
        }

        /// <summary>
        /// Bouton permettant d'ouvrir et de fermé le port série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenSerialPort_Click(object sender, EventArgs e)
        {
            // Si le port est fermé
            if (btn_OpenSerialPort.Text == "Open")
            {
                DialogResult result = DialogResult.OK;
                // Réessaie d'ouvrir le port tant que l'usager appuie sur retry
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
                        else // Affiche un message d'erreur si aucun port n'est choisi
                            MessageBox.Show("Invalid port, choose a port ", "Invalid port", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        result = DialogResult.OK;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Affiche un message d'erreur si le port est déja utilisé (access denied)
                        result = MessageBox.Show("Access is denied on port " + serialPort1.PortName, serialPort1.PortName + " ACCESS DENIED O_o", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);   // Affiche un message d'erreur si l'opération est invalide
                    }
                    catch (System.IO.IOException)
                    {
                        // Affiche un message d'erreur si le port n'existe plus (débranché)
                        result = MessageBox.Show("The port " + serialPort1.PortName + " does not exist.", serialPort1.PortName + " IS INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                    }
                } while (result == DialogResult.Retry);
            }
            else // Si le port est ouvert
            {
                DialogResult result = DialogResult.OK;
                // Réessaie d'ouvrir le port tant que l'usager appuie sur retry
                do
                {
                    try
                    {
                        if (serialPort1.IsOpen) // ferme le port si il est déja ouvert
                            serialPort1.Close();
                    }
                    catch (Exception)
                    {
                        // Affiche un message d'erreur si le port ne peut pas être fermé (very unlikely)
                        result = MessageBox.Show("Cannot close port " + serialPort1.PortName, serialPort1.PortName + " NOT CLOSED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);   // Affiche un message d'erreur si l'opération est invalide
                    }
                } while (result == DialogResult.Retry);
            }

            // Affichage de la toolStrip avec les informations du port série
            toolStripStatusLabel1.Text = serialPort1.PortName + ":" + serialPort1.BaudRate.ToString() + "," + serialPort1.Parity.ToString() + "," + serialPort1.DataBits.ToString() + "," + serialPort1.StopBits.ToString();
            if (serialPort1.IsOpen)
            {
                btn_TX.Enabled = true;  // Activation du bouton
                btn_OpenSerialPort.Text = "Close";  // Change le texte
                toolStripStatusLabel2.Text = "Opened";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Green;  // Change la couleur du texte
            }
            else
            {
                btn_TX.Enabled = false; // Désactivation du bouton
                btn_OpenSerialPort.Text = "Open";   // Change le texte
                toolStripStatusLabel2.Text = "Closed";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Red;    // Change la couleur du texte
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // ferme le port si il est déja ouvert
                serialPort1.Close();
            Application.Exit(); // Exit the application
        }
    }
}
