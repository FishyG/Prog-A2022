/**
 * @file   frmPrincipal.cs
 * @author Jessy GM
 * @date   déc 2022
 * @brief  Examen final 
 *  */


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;         // Pour les Threads
using System.Net;
using System.Net.Sockets;       // Ajout pour les Sockets
using System.Drawing;
using Lab4_StationMeteo_JGM;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoServeurUDP
{
    public partial class frmPrincipal : Form
    {
        // Constantes
        const Byte SOH = 0x01; // défini dans le protocole

        // Variables membres
        private const int NBELECTEURS = 20;

        private string[] m_noms = { "Rey", "Ben Solo", "Finn", "Poe", "Leia", "Luke", "R2D2", "C3P0", "Yoda" };
        private string[] m_couleurs = { "Red", "Blue", "Green", "Purple", "Navy", "Lime", "Olive", "Cyan", "Magenta", "Maroon", "Black", "Orange" };

        
        private List<Personnage> m_personnages = new List<Personnage>(); 


        private delegate void monProtoDelegate(byte[] trame, string ip);
        monProtoDelegate objDelegate;

        Thread objTh;  //On fera tourner l'objet objThUDP dans un Thread pour la rx de la trame
        ThreadRxUDP objUDP;


        public frmPrincipal()
        {
            InitializeComponent();
            initPersonnages();  //Init des personnages
            initDataGrid();//Init du dataGrid
            initGraph(); //init du graphique (chart) 

            //On instencie les obj et lance le Thread
            objUDP = new ThreadRxUDP(this);
            objUDP.objDelegate = majDelegate; //on instancie le delegate (En bref, objDelegate est un pointeur de fonction qui pointe sur DelegateAffiche.
            objTh = new Thread(objUDP.FaitTravail);
            objTh.Start();

        }
        /// <summary>
        /// Initialise la liste d'objets personnage (m_personnages) à partir des tableaux
        /// m_nom et m_couleurs
        /// </summary>
        private void initPersonnages()
        {
            int i = 0;
            foreach (string nom in m_noms)
            {
                //Crée on nouvel objet Personnage et l'ajoute m_personnages
                m_personnages.Add(new Personnage(nom, m_couleurs[i]));
                i++;
            }
        }

        /// <summary>
        /// Initialise le graphique. Utilise m_personnages pour le peupler.
        /// </summary>
        private void initGraph()
        {
            int i = 0;

            chartVotes.Titles.Add("Résultats des votes");
            chartVotes.ChartAreas[0].AxisY.Maximum = NBELECTEURS;
            chartVotes.ChartAreas[0].AxisX.Interval = 1; //pour s'assurer que tous les noms seront écrit sur l'axe des x

            //ajoute les personnages et assigne les couleurs
            foreach (Personnage personnage in m_personnages)
            {
                chartVotes.Series.Add(personnage.nom);
                // Affiche la legen au bas du graph
                chartVotes.Series[personnage.nom].LegendText = personnage.nom;
                chartVotes.Series[personnage.nom].Color = Color.FromName(personnage.couleur);
                chartVotes.Series[personnage.nom].Points.AddY(0);
                i++;
            }
        }

        /// <summary>
        /// Initialise le dataGridView. Utilise m_personnages pour le peupler.
        /// </summary>
        private void initDataGrid()
        {
            foreach (Personnage p in m_personnages)
            {
                votesDataGridView.Rows.Add(p.nom, "0", "0.0");
            }


        }

        /// <summary>
        /// Delegate pour traiter et afficher la trame UDP reçue.
        /// Appelée par la méthode FaitTravail
        /// </summary>

        private void majDelegate(byte[] buffer, string srcIp)
        {
            int i = 0;
            int totalVote = 0;
            float pourcentage = 0;

            if (buffer.Length == 5)
            listRxTrame.Items.Add("Trame recue " + Convert.ToString(buffer[0]) + " " + Convert.ToString(buffer[1]) + " " + Convert.ToString(buffer[2]) + " " + Convert.ToString(buffer[3]) + " " + Convert.ToString(buffer[4]));

            if (verifTrame(buffer))
            {
                listRxTrame.Items.Add("Un vote de IP : " + srcIp + " Poste : " + Convert.ToString(buffer[1]) + Convert.ToString(buffer[2]) + " pour : " + m_personnages[buffer[3] - 1].nom);

                // Ajoute le vote
                m_personnages[buffer[3]].voter();
                votesDataGridView.Rows[buffer[3]].Cells[1].Value = Convert.ToString(m_personnages[buffer[3]].getNbVotes());
                chartVotes.Series[m_personnages[buffer[3]].nom].Points.AddY(m_personnages[buffer[3]].getNbVotes());

                // Calcul pourcentage
                foreach (Personnage p in m_personnages)
                {
                    totalVote += p.getNbVotes();
                }

                foreach (Personnage p in m_personnages)
                {
                    pourcentage = (p.getNbVotes() * 100) / totalVote;
                    votesDataGridView.Rows[i].Cells[2].Value = Convert.ToString(pourcentage);
                    i++;
                }
            }
            else
                listRxTrame.Items.Add("Trame Invalide");
        }

        /// <summary>
        /// Vérifie si la trame reçue est bonne. 
        /// La trame est bonne si SOH = 1 et Checksum est OK
        /// </summary>
        /// <param name="t">La trame de 5 octets</param>
        /// <returns>vrai si la trame est bonne, faux sinon</returns>
        private bool verifTrame(byte[] trame)
        {
            bool allgood = true;

            if (!((trame.Length == 5) && allgood))
                allgood = false;
            else
            {
                if (!((trame[0] == SOH) && allgood))   // Si SOH est ok
                    allgood = false;

                if (!((trame[4] == calculChecksum(trame)) && allgood))
                    allgood = false;
            }

            return allgood;
        }

        /// <summary>
        /// Calcul le checksum (addition des octets de la trame et retourne la valeur des 8 LSB.)
        /// </summary>
        /// <param name="trame"></param>
        /// <returns></returns>
        private byte calculChecksum(byte[] trame)
        {
            byte checksum = 0;

            for (int i = 0; i < trame.Length - 1; i++)
            {
                checksum += trame[i];
            }

            return checksum;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            objUDP.ArreteClientUDP();
            objTh.Abort();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            objUDP.ArreteClientUDP();
            objTh.Abort();
            Application.Exit();
        }
    }
}
