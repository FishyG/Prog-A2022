using System.Drawing;
using System;
using System.Windows.Forms;
using Lab3_PortSerie_JGM;
using System.IO.Ports;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.IO;
using System.Linq;

namespace Lab4_StationMeteo_JGM
{
    public partial class Form1 : Form
    {
        public delegate void myProtoDelegate(List<byte> lineReceived);
        myProtoDelegate objDelegate;

        // variables membres liées à la gestion des trames
        const int LIMITE_BUFFER = 128;  // Grosseur max du buffer de réception
        List<byte> m_lstTrameRx = new List<byte>(); //conserve les octets reçus du port. Seule la méthode DataReceived du port série utilise cette variable



        // variables membres liées à la gestion des trames
        const Byte SOH = 0x01; // défini dans le protocole
        enum enumTrame // les différentes positions sont les index des différents bytes
        {
            soh = 0, // début 
            tempEntier,
            tempFraction,
            humidite,
            dirVent,
            vitVent,
            pressionEntier,
            pressionFraction,
            intensiteMsb,
            intensiteLsb,
            tempIntEntier,
            tempIntFraction,
            checksum,
            maxTrame
        };

        enum enumDirVent { Nord = 0, NordEst, Est, SudEst, Sud, SudOuest, Ouest, NordOuest };

        public Form1()
        {
            objDelegate = methodeDelegeAffiche;   //nouvelle méthode depuis C#2.0
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
            // Crée la feuille de config. Appelle le constructeur et on lui passe la config.actuelle du port série.
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
                MessageBox.Show("Unsupported databits", "Error");   // Affiche un message d'erreur si les data bits sont autre que 7 ou 8
            openSerialPortToolStripMenuItem.Text = "Open Serial Port";   // Change le text afin de forcé une ouverture du port
            openSerialPortToolStripMenuItem.PerformClick();  // Ouverture du port
        }

        private void openSerialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si le port est fermé
            if (openSerialPortToolStripMenuItem.Text == "Open Serial Port")
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
                //btn_TX.Enabled = true;  // Activation du bouton
                openSerialPortToolStripMenuItem.Text = "Close Serial Port";  // Change le texte
                toolStripStatusLabel2.Text = "Opened";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Green;  // Change la couleur du texte
            }
            else
            {
                //btn_TX.Enabled = false; // Désactivation du bouton
                openSerialPortToolStripMenuItem.Text = "Open Serial Port";   // Change le texte
                toolStripStatusLabel2.Text = "Closed";  // Change le texte
                toolStripStatusLabel2.ForeColor = Color.Red;    // Change la couleur du texte
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            serialPortToolStripMenuItem.PerformClick();
        }

        private void serialPort1_DataReceived (object sender, SerialDataReceivedEventArgs e)
        {
            int nbALire;
            byte[] lecture = new byte[LIMITE_BUFFER];
            nbALire = serialPort1.BytesToRead;  //on a reçu combien de bytes
            if (nbALire > 0)  //Petit test car, de temps en temps on a un événement dataReceive et il n'y a pas de bytes à lire !!!!
            {
                serialPort1.Read(lecture, 0, nbALire);
                for (int i = 0; i < nbALire; i++)
                {
                    m_lstTrameRx.Add(lecture[i]);
                }

                if (m_lstTrameRx.Count >= (int)enumTrame.maxTrame)
                {
                    if (verifTrame(m_lstTrameRx))
                    {
                        BeginInvoke(objDelegate, m_lstTrameRx);
                    }
                    else
                    {
                        MessageBox.Show("Serial Frame Error (invalid data received)", "Reception Error");
                        m_lstTrameRx.Clear();   // Efface la trame
                    }
                }
                //else if (m_lstTrameRx.Count )
            }
        }
        /// <summary>
        /// Retourne vrai, si la trame est valide. Faux si la trame est incomplète ou invalide.
        /// </summary>
        /// <param name="trame"></param>
        /// <returns></returns>
        private bool verifTrame(List<byte> trame)
        {
            bool allgood = true;

            if (!((trame.Count == (int)enumTrame.maxTrame) && allgood))
                allgood = false;
            else
            {
                if (!((trame[(int)enumTrame.soh] == SOH) && allgood))   // Si SOH est ok
                    allgood = false;
             
                if (!((trame[(int)enumTrame.checksum] == calculChecksum(trame)) && allgood))
                    allgood = false;
            }
            
            return allgood;
        }

        /// <summary>
        /// Calcul le checksum (addition des octets de la trame et retourne la valeur des 8 LSB.)
        /// </summary>
        /// <param name="trame"></param>
        /// <returns></returns>
        private byte calculChecksum(List<byte> trame)
        {
            byte checksum = 0;

            for (int i = 1; i < trame.Count - 1; i++)
            {
                checksum += trame[i];
            }

            return checksum;
        }

        private void methodeDelegeAffiche(List<byte> frame)
        {
            string time = string.Format("{0:HH:mm:ss}", DateTime.Now);  // Get time from the os (time the data was received)
            string temperature = Convert.ToString((sbyte)frame[(int)enumTrame.tempEntier]); //************************************************************************************
            string temperatureFrac = Convert.ToString(frame[(int)enumTrame.tempFraction]);  //
            string humidity = Convert.ToString(frame[(int)enumTrame.humidite]);             // Conversion des valeur en string 
            string windSpeed = Convert.ToString(frame[(int)enumTrame.vitVent]);             // Pour plus d'info voir :
            string windDir = Convert.ToString((enumDirVent)frame[(int)enumTrame.dirVent]);  // http://wikitge.org/w/images/b/b4/Trame_Projet_M%C3%A9t%C3%A9o_du_cours_ISO.pdf
            string pressure = Convert.ToString(frame[(int)enumTrame.pressionEntier]);       //
            string pressureFrac = Convert.ToString(frame[(int)enumTrame.pressionFraction]); //************************************************************************************

            if (windDir.All(char.IsDigit))
                windDir = "Invalid";
            tbTemperature.Text = temperature + "." + temperatureFrac;    // écrit dans la case la temépature 
            tbHumidity.Text = humidity;  // écrit dans la case l'humidité
            tbWindSpeed.Text = windSpeed;  // écrit dans la case la vitesse du vent
            tbWindDirection.Text = windDir;    // écrit dans la case la direction du vent
            tbPressure.Text = pressure + "." + pressureFrac;   // écrit dans la case la pression

            dataGridView1.Rows.Insert(0, time, temperature + "." + temperatureFrac, humidity, windSpeed, windDir, pressure + "." + pressureFrac);

            //dataGridView1.Rows[0].Selected = true;  // sélection la première 
            //dataGridView1.Rows[1].Selected = false; // désélection la deuxième

            m_lstTrameRx.Clear();   // Efface la trame
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter swFichier;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();  // New object for the savefile dialog
            saveFileDialog1.AddExtension = true;    // Add the extension if the user forget
            saveFileDialog1.Filter = "Sus files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                swFichier = File.CreateText(saveFileDialog1.FileName);  // Create the text file
                swFichier.WriteLine("Donnees de la station meteo le " + DateTime.Now.ToString("yyyy-MM-dd") + " a " + string.Format("{0:HH:mm:ss tt}", DateTime.Now)); // Add the little header like this http://wikitge.org/wiki/Fichier:FichierCSVLab4.JPG
                for (int i = 0; i < dataGridView1.RowCount -1 ; i++) // Pour les rows
                {
                    for (int j = 0; j < dataGridView1.ColumnCount - 1; j++) // Pour les columns
                    {
                        swFichier.Write((string)(dataGridView1.Rows[i].Cells[j].Value) + ";");
                    }
                    swFichier.WriteLine("");    // Jump to the next line
                }
                swFichier.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Ferme le port s'il est ouvert
                serialPort1.Close();
            Application.Exit(); // Quitte l'application
        }
    }
}