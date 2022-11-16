using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DemoThread
{
    public partial class Form1 : Form
    {
        private Compteur m_objCompteur; //Dans la section des variables membres, car sera accédé par la méthode majClick();
        private Thread m_objLeThread; //déclaration
        public Form1()
        {
            InitializeComponent();
            m_objCompteur = new Compteur(200,false,this); // New obj compteur that start at 200 and set pause to false
            m_objLeThread = new Thread(m_objCompteur.faitTravail); //Dans le constructeur de la form
            m_objCompteur.objDelegate = delegateAffiche;

        }

    private void btnMAJ_Click(object sender, EventArgs e)
        {
            textBoxAffiche.Text = m_objCompteur.m_compteur.ToString();
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            if (!m_objLeThread.IsAlive)
            {
                m_objLeThread.Start();
                btnPause.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_objLeThread.Abort();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!m_objCompteur.m_pause)
            {
                m_objCompteur.m_pause = true;
                btnReprendre.Enabled = true;
                btnPause.Enabled = false;
            }
        }

        private void btnReprendre_Click(object sender, EventArgs e)
        {
            if (m_objCompteur.m_pause)
            {
                m_objCompteur.m_pause = false;
                m_objLeThread.Interrupt();  // Send an interrupt to the thread
                btnReprendre.Enabled = false;
                btnPause.Enabled = true;
            }
        }

        private void delegateAffiche(int valeurRecu)
        {
            textBoxAffiche.Text = m_objCompteur.m_compteur.ToString();
        }
    }
}
