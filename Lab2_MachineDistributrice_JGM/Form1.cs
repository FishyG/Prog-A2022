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
        private Button[] m_Clavier = new Button[NBCOLONNE]; //tableau contenant les objets (Button) du clavier

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

            Control ctrlSuivant;  // Déclaration d'un objet Control
            ctrlSuivant = panelClavier;  // Le point de départ de la recherche sera le Pannel

            for (int i = 0; i < NBCOLONNE; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);
                m_Clavier[i] = (Button)ctrlSuivant; //casting de l'objet Control trouvé (ctrlSuivant) en TextBox
            }
            SetClavierLettre();
        }

        private void ClavierABC123_Click(object sender, EventArgs e)
        {
            
            Button bouton = (Button)sender; // Casting du sender en Button

            if (char.IsNumber(bouton.Text[0]))  // Si le premier caractère du button est un nombre
            {
                m_indexColonne = bouton.Text[0] - '1';
                /* TO REMOVE */ label2.Text = m_indexColonne.ToString();  // TO REMOVE
                SetClavierLocked();
            }
            else
            {
                m_indexRangee = bouton.Text[0] - 'A';
                /* TO REMOVE */ label2.Text = m_indexRangee.ToString();  // TO REMOVE
                SetClavierChiffres();
            }
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; //casting du sender en Button
            string temporaire = bouton.Text;
            temporaire = temporaire.Remove(4, 1);   // Efface le $
            temporaire = temporaire.Remove(1, 1);   // Efface le point
            m_credit += Convert.ToInt32(temporaire);// Ajout du nombre de crédits

            /* TO REMOVE */
            label1.Text = m_credit.ToString();  // TO REMOVE
        }

        private void SetClavierLocked()
        {
            for (int i = 0; i < NBCOLONNE; i++)
            {
                m_Clavier[i].Enabled = false;
            }
        }

        private void SetClavierLettre()
        {
            int i = 0;
            for (i = 1; i < NBRANGEE + 1; i++)
            {
                m_Clavier[i].Text = Convert.ToChar((i - 1) + 'A').ToString();
            }
            m_Clavier[0].Text = " ";
            for (; i < NBCOLONNE; i++)
            {
                m_Clavier[i].Text = " ";
            }
        }

        private void SetClavierChiffres()
        {
            for (int i = 0; i < NBCOLONNE; i++)
            {
                m_Clavier[i].Text = i.ToString();
            }
        }
    }
}
