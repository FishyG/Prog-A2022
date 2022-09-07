using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_MachineDistributrice_JGM
{
    public partial class Form1 : Form
    {
        /********* constantes ***********/
        public const int NBRANGEE = 6;
        public const int NBCOLONNE = 10;

        /********** variables membres ***********/
        //private Lcd4Lignes m_objAffichage;
        //private ItemInventaire[,] m_tabInventaire;  //tableau contenant l'inventaire
        private Button[] m_Clavier; //tableau contenant les objets (Button) du clavier

        /*** Les variables ci-dessous sont utilisées par m_objAffichage pour générer l'affichage ***/
        private int m_prixCourant;
        private int m_credit;
        private int m_retourCredit;
        private int m_indexRangee;
        private int m_indexColonne;
        private Boolean m_manqueCredit;
        private Boolean m_annulationVente;
        private Boolean m_distributionActive;
        private Boolean m_qteZero;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClavierABC123_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; // Casting du sender en Button

            if (char.IsNumber(bouton.Text[0]))  // Si le premier caractère du button est un nombre
            {
                m_indexColonne = bouton.Text[0];
                
                bouton.Text = "A";
            }
            else
            {
                m_indexRangee = bouton.Text[0] - 'A';
                bouton.Text = m_indexRangee.ToString();
            }
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; //casting du sender en Button



            //m_credit =
        }
    }
}
