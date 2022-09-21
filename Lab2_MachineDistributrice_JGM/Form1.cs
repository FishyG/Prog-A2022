using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
        private Lcd4Lignes m_objAffichage;
        private ItemInventaire[,] m_tabInventaire = new ItemInventaire[NBRANGEE, NBCOLONNE];//tableau contenant l'inventaire
        private Button[] m_Clavier = new Button[NBCOLONNE]; //tableau contenant les objets (Button) du clavier
         
        /*** Les variables ci-dessous sont utilisées par m_objAffichage pour générer l'affichage ***/
        private int m_prixCourant;
        private int m_credit;
        private int m_retourCredit;
        private int m_indexRangee = 255;
        private int m_indexColonne = 255;
        private Boolean m_manqueCredit;
        private Boolean m_annulationVente;
        private Boolean m_distributionActive;
        private Boolean m_qteZero;

        public Form1()
        {
            Control ctrlSuivant;  // Déclaration d'un objet Control
            Random rand = new Random(); // Création de l'objet rand pour avoir des valeurs aléatoires (Prix)
            int prixTemp = 0;   // Variable contenant le prix de l'item (de facon temporaire
            m_objAffichage = new Lcd4Lignes();  // Insranciation de 
            InitializeComponent();
            
            for (int i = 0; i < NBRANGEE; i++)
            {
                for (int j = 0; j < NBCOLONNE; j++)
                {
                    prixTemp = rand.Next(1,60) * 5;
                    m_tabInventaire[i, j] = new ItemInventaire(prixTemp, 2);
                }
            }

            ctrlSuivant = panelClavier;  // Le point de départ de la recherche sera le Pannel
            for (int i = 0; i < NBCOLONNE; i++) // Boucle pour la création des boutons
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_Clavier[i] = (Button)ctrlSuivant; //casting de l'objet Control trouvé (ctrlSuivant) en TextBox
            }

            cb_Rangee.Text = "A";
            cb_Colonne.Text = "0";
            cb_Rangee.SelectedIndex = 0; 
            cb_Colonne.SelectedIndex = 0;
            tb_Price.Text = m_tabInventaire[0, 0].prix.ToString();
            tb_Quantity.Text = m_tabInventaire[0, 0].quantite.ToString();
            Affiche();
            SetClavierLettre();
        }


        private void ClavierABC123_Click(object sender, EventArgs e)
        {
            
            Button bouton = (Button)sender; // Casting du sender en Button

            if (char.IsNumber(bouton.Text[0]))  // Si le premier caractère du button est un nombre
            {
                m_indexColonne = bouton.Text[0] - '0';
                m_prixCourant = m_tabInventaire[m_indexRangee, m_indexColonne].prix;
                if (m_tabInventaire[m_indexRangee, m_indexColonne].quantite == 0)
                {
                    m_qteZero = true;
                    tmr_1Sec.Enabled = true;
                }

                SetClavierState(false); // Barre le clavier
            }
            else
            {
                m_indexRangee = bouton.Text[0] - 'A';
                SetClavierChiffres();
            }
            Affiche();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            m_indexRangee = 255;
            m_indexColonne = 255;
            m_annulationVente = true;
            m_retourCredit = m_credit;
            tmr_1Sec.Enabled = true;
            SetClavierState(false);
            Affiche();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (m_indexRangee != 255 && m_indexColonne != 255)
            {
                if(m_credit < m_prixCourant)
                {
                    m_manqueCredit = true;
                    tmr_1Sec.Enabled = true;
                }
                else
                {
                    m_distributionActive = true;
                    m_retourCredit = m_credit - m_prixCourant;
                    tmr_1Sec.Enabled = true;
                }
            }
            Affiche();
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; //casting du sender en Button
            string temporaire = bouton.Text;
            temporaire = temporaire.Remove(4, 1);   // Efface le $
            temporaire = temporaire.Remove(1, 1);   // Efface le point
            m_credit += Convert.ToInt32(temporaire);// Ajout du nombre de crédits

            Affiche();
        }

        private void SetClavierState(bool state)
        {
            for (int i = 0; i < NBCOLONNE; i++)
            {
                m_Clavier[i].Enabled = state;
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

        private void Affiche()
        {
            // Génération d'un nouvelle affichage
            if (m_objAffichage.genererAffichage(m_indexRangee, m_indexColonne, m_credit, m_retourCredit, m_prixCourant, m_distributionActive, m_manqueCredit, m_annulationVente, m_qteZero))
            {
                // Refresh l'affichage si besoin (if genererAffichage = true)
                lb_Affichage.Items.Clear();    // Efface l'affichage
                for (int i = 0; i < 4; i++)
                {
                    lb_Affichage.Items.Add(m_objAffichage.lignesAffichage[i]);
                }
            }
        }

        private void tmr_1Sec_Tick_1(object sender, EventArgs e)
        {
            tmr_1Sec.Enabled = false;
            

            if (m_manqueCredit)
            {
                m_manqueCredit = false;
            }
            else if (m_annulationVente)
            {
                m_credit = 0;
                m_annulationVente = false;
                m_prixCourant = 0;
                m_retourCredit = 0;
                m_indexRangee = 255;
                m_indexColonne = 255;
                SetClavierState(true);
                SetClavierLettre();
            }
            else if (m_qteZero)
            {
                m_qteZero = false;
                m_indexRangee = 255;
                m_indexColonne = 255;
                SetClavierState(true);
                SetClavierLettre();
            }
            else if (m_manqueCredit)
            {
                m_distributionActive = false;
                m_credit = 0;
                m_retourCredit = 0;
                m_prixCourant = 0;
                m_tabInventaire[m_indexRangee, m_indexColonne].diminuerInventaire();
                m_indexRangee = 255;
                m_indexColonne = 255;
                SetClavierState(true);
                SetClavierLettre();
            }
            else if (m_distributionActive)
            {
                m_distributionActive = false;
                m_credit = 0;
                m_retourCredit = 0;
                m_prixCourant = 0;
                m_tabInventaire[m_indexRangee, m_indexColonne].diminuerInventaire();
                m_indexRangee = 255;
                m_indexColonne = 255;
                SetClavierState(true);
                SetClavierLettre();
            }
            Affiche();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].prix;
            int quantity = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].quantite;
            tb_Price.Text = price.ToString();
            tb_Quantity.Text = quantity.ToString();
        }

        private void btn_Modif_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (cb_Colonne.Text[0] < '0' && cb_Colonne.Text[0] > '9' && cb_Colonne.Text.Length > 1)
            {
                MessageBox.Show("Colonne invalide");
                error = false;
            }
            else
            {
                cb_Colonne.SelectedIndex = (cb_Colonne.Text[0] - '0');
                error = true;
            }

            if ((cb_Rangee.Text[0] < 'A' && cb_Rangee.Text[0] > ('A' + NBRANGEE-1)) && cb_Rangee.Text.Length > 1 && error)
            {
                MessageBox.Show("Rangée invalide");
                error = false;
            }
            else
            {
                cb_Rangee.SelectedIndex = (cb_Rangee.Text[0] - 'A');
                error = true;
            }

            if(error)
                if (!(m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].modifierInventaire(Convert.ToInt32(tb_Price.Text), Convert.ToInt32(tb_Quantity.Text))))
                    MessageBox.Show("Prix ou quantité invalide");
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].prix;
            int quantity = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].quantite;
            tb_Price.Text = price.ToString();
            tb_Quantity.Text = quantity.ToString();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int price = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].prix;
            int quantity = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].quantite;
            tb_Price.Text = price.ToString();
            tb_Quantity.Text = quantity.ToString();
        }
    }
}
