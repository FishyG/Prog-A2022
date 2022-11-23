using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Web;
using System.Threading;
using Exam2RxSol2021;

namespace Exam2RxEtu2022
{
    public partial class Form1 : Form
    {
        const int NB_TEAM = 4;
        const int NBRESMAX = 16;    // Nombre de gamer

        List<Gamer> m_lstGamer = new List<Gamer>();    // instanciation d'une liste de gamers
        
        private TextBox[] m_tboxForces = new TextBox[NB_TEAM];
        private ListBox[] m_lboxEquipes = new ListBox[NB_TEAM];

        public delegate void myProtoDelegate(string lineReceived);
        myProtoDelegate objDelegate;

        public Form1()
        {
            objDelegate = methodeDelegeAffiche;   //nouvelle méthode depuis C#2.0

            InitializeComponent();

            serialPort1.Encoding = Encoding.Default;// 
            comboBoxPort.DataSource = SerialPort.GetPortNames();

            for (int i = 0; i < NB_TEAM; i++)   // Pour Q2
            {
                m_tboxForces[i] = new TextBox();
                m_tboxForces[i].AutoSize = true;
                m_tboxForces[i].ReadOnly = true;
                m_tboxForces[i].Location = new System.Drawing.Point((i * 200) + 20, 350);
                this.Controls.Add(m_tboxForces[i]);

                m_lboxEquipes[i] = new ListBox();
                m_lboxEquipes[i].AutoSize = true;
                m_lboxEquipes[i].Location = new System.Drawing.Point((i * 200) + 20, 240);
                this.Controls.Add(m_lboxEquipes[i]);
            }
        }

        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
            if (verifTrame(lineReceived))
            {
                lbRx.Items.Add(lineReceived);
                string[] strings = lineReceived.Split(' ');
                string name = strings[0];
                int team = Convert.ToInt32(strings[2]);
                int force = Convert.ToInt32(strings[4]);

                m_lstGamer.Add(new Gamer(name, team, force));
            }
            else
            {
                string[] strings = lineReceived.Split(' ');
                lbRx.Items.Add(lineReceived + " Invalide");
            }

        }

        private bool verifTrame(String s)
        {
            int team = 0;
            string[] strings = s.Split(' ');
            try
            {
                team = Convert.ToInt32(strings[2]);
            }
            catch (FormatException)
            {
                // MessageBox.Show("Bad string", "INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                return false;
            }
            
            if ((team < 1) || (team > 4))
                return false;
            if ((Convert.ToInt32(strings[4]) < 0) || (Convert.ToInt32(strings[4]) > 999))
                return false;

            return true;
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            try
            {
                btnOuvrir.ForeColor = System.Drawing.Color.Red;
                serialPort1.Close();
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.Open();
                btnOuvrir.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                MessageBox.Show("Ne peut ouvrir le port " + serialPort1.PortName + ".");
            }
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOuvrir.PerformClick();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c >= '1' && c <= '4' || c == (char)ConsoleKey.Backspace )) 
            {
                e.Handled = true;
            }
        }

        private void btnEffaceLBoxRX_Click(object sender, EventArgs e)
        {
            lbRx.Items.Clear();
            m_lstGamer.Clear();
        }

        private void btnMetAJour_Click(object sender, EventArgs e)
        {
            btnCombat.Enabled = true;
            int force = 0;
            for (int i = 0; i < NB_TEAM; i++)
            {
                m_tboxForces[i].Text = "";
                m_lboxEquipes[i].Items.Clear();
            }

            foreach (Gamer bob in m_lstGamer)
            {
                m_lboxEquipes[(bob.m_equipe - 1)].Items.Add(bob.m_gamerTag);
                if (m_tboxForces[bob.m_equipe - 1].Text == null)
                    m_tboxForces[bob.m_equipe - 1].Text = "0";
                
                try
                {
                    force = Convert.ToInt32(m_tboxForces[(bob.m_equipe - 1)].Text) + bob.m_force;
                }
                catch (FormatException)
                {
                    //MessageBox.Show("Bad string", "INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                    force = bob.m_force;
                }
                m_tboxForces[(bob.m_equipe - 1)].Text = Convert.ToString(force);
            }
        }

        private void btnCombat_Click(object sender, EventArgs e)
        {
            btnCombat.Enabled = false;
            int teamA = Convert.ToInt32(tbEqA.Text);
            int teamB = Convert.ToInt32(tbEqB.Text);

            try
            {
                if (Convert.ToInt32(m_tboxForces[teamA - 1].Text) > Convert.ToInt32(m_tboxForces[teamB - 1].Text))
                {
                    m_lboxEquipes[(teamB - 1)].Items.Clear();
                    for (int i = 0; i < m_lstGamer.Count; i++)
                    {
                        if (m_lstGamer[i].m_equipe == teamB - 1)
                        {
                            if (m_lstGamer.Remove(m_lstGamer[i]))
                            {
                                MessageBox.Show("No error", "Good", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                            }
                            else
                            {
                                MessageBox.Show("Error", "BAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est 
                            }
                        }
                    }
                }
                else
                {
                    m_lboxEquipes[(teamA - 1)].Items.Clear();
                    for (int i = 0; i < m_lstGamer.Count; i++)
                    {
                        if (m_lstGamer[i].m_equipe == teamA - 1)
                            m_lstGamer.Remove(m_lstGamer[i]);
                    }
                    
                    /*
                    foreach (Gamer noob in m_lstGamer)
                    {
                        if (noob.m_equipe == teamA)
                            m_lstGamer.Remove(noob);
                    }
                    */
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bad string", "INVALID X_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   // Affiche un message d'erreur si l'opération est invalide
                btnCombat.Enabled = false;
            }
        }
    }
}
