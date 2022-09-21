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
            int positionA = 0,positionB = 0;
            InitializeComponent();

            for (int i = 0; i < NBJOUEURS; i++)
            {
                m_tabObjJoueurs[i] = new Joueur(m_tabObjJoueurs[i]);
            }
        }
    }
}