using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Semain5___Joueur
{
    public partial class Form1 : Form
    {
        const int NBJOUEURS = 10;
        static readonly string[] m_listeJoueurs = { "Mario", "Luigi", "Princess Peach", "Yoshi", "Bowser", "Donkey Kong", "Koopa", "Toad", "Gino", "Tony" };
        CheckBox[] m_cbJoueur = new CheckBox[NBJOUEURS];
        Joueur[] m_tabObjJoueurs = new Joueur[NBJOUEURS];

        public Form1()
        {
            InitializeComponent();
            int j = 0;
            int k = 0;
            for (int i = 0; i < NBJOUEURS; i++)
            {
                m_tabObjJoueurs[i] = new Joueur(m_listeJoueurs[i]);
                m_cbJoueur[i] = new CheckBox();
                m_cbJoueur[i].AutoSize = true;
                if (m_tabObjJoueurs[i].team == 0)
                {
                    gbTeamA.Controls.Add(m_cbJoueur[i]);
                    m_cbJoueur[i].Location = new Point(10, (j * 20) + 20);
                    j++;
                }
                else
                {
                    gbTeamB.Controls.Add(m_cbJoueur[i]);
                    m_cbJoueur[i].Location = new Point(10, (k * 20) + 20);
                    k++;
                }
                m_cbJoueur[i].Text = m_listeJoueurs[i];
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            int scoreTeamA = 0;
            int scoreTeamB = 0;
            for (int i = 0; i < NBJOUEURS; i++)
            {
                if (m_cbJoueur[i].Checked)
                {
                    if (m_tabObjJoueurs[i].team == 0)
                        scoreTeamA += m_tabObjJoueurs[i].getForce();
                    else
                        scoreTeamB += m_tabObjJoueurs[i].getForce();
                }
            }

            lbResult.Items.Clear();
            lbResult.Items.Add("Total Team A " + Convert.ToString(scoreTeamA));
            lbResult.Items.Add("Total Team B " + Convert.ToString(scoreTeamB));
            if (scoreTeamA > scoreTeamB)
                lbResult.Items.Add("Gagnant = Team A");
            else if (scoreTeamA < scoreTeamB)
                lbResult.Items.Add("Gagnant = Team B");
            else
                lbResult.Items.Add("Les deux sont dead X_X");
        }
    }
}