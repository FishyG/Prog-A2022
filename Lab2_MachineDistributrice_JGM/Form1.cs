/*
 * @file   Form1.cs
 * @author Jessy Grimard-Maheu
 * @date   9/20/2022
 * @brief  LaboMachineDist(lab2) pour le cours 247-516-SH-A22.
 * Le but de ce laboratoire est de concevoir une machine distributrice.
 * La machine distributrice possède un système d'inventaire, il est alors impossible de faire l'achat de cet article
 * une fois que la quantité de celui-ci est à 0. La machine distributrice possède également un moyen de modifier l'inventaire
 * en modifiant le prix et la quantité des articles. Il est possible d'ajouter des crédits afin de faire l'achat des articles. Si
 * les crédits sont insuffisants, la machine affiche un message d'erreur à l'usager en lui indiquant combien de crédits il 
 * doit rajouter. Si l'usager à ajouter trop de crédits pour l'article choisit, la machine distributrice va lui remettre les 
 * crédits en trop. Le choix de l'article se fait en choisissant une colonne et une rangée.
 *
 * @version 1.0 : Première version
 * Environnement de développement: Visual Studio 2022
 * Matériel: N/A
 */

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
            m_objAffichage = new Lcd4Lignes();  // Instanciation de m_objAffichage
            InitializeComponent();
            
            for (int i = 0; i < NBRANGEE; i++)
            {
                for (int j = 0; j < NBCOLONNE; j++)
                {
                    prixTemp = rand.Next(1,60) * 5; // Pour avoir un prix entre 5 et 300 cents
                    m_tabInventaire[i, j] = new ItemInventaire(prixTemp, 2);    // Ajout de l'item avec une quantié de 2 et un prix aléatoire
                }
            }

            ctrlSuivant = panelClavier;  // Le point de départ de la recherche sera le Pannel
            for (int i = 0; i < NBCOLONNE; i++) // Boucle pour la création des boutons
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_Clavier[i] = (Button)ctrlSuivant; //casting de l'objet Control trouvé (ctrlSuivant) en TextBox
            }

            cb_Rangee.Text = "A";   // Met le texte de la combo box de la rangée à A
            cb_Colonne.Text = "0";  // Met le texte de la combo box de la colonne à 0
            cb_Rangee.SelectedIndex = 0;    // Met l'index de la combo box à 0
            cb_Colonne.SelectedIndex = 0;   // Met l'index de la combo box à 0
            tb_Price.Text = m_tabInventaire[0, 0].prix.ToString();  
            tb_Quantity.Text = m_tabInventaire[0, 0].quantite.ToString();
            Affiche();  // Refresh l'affichage
            SetClavierLettre(); // Met le clavier en mode lettre
        }

        /// <summary>
        /// Fonction servant à gérer les clicks des boutons du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClavierABC123_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; // Casting du sender en Button

            if (char.IsNumber(bouton.Text[0]))  // Si le premier caractère du button est un nombre
            {
                m_indexColonne = bouton.Text[0] - '0';  // Récupère le numéro de l'index en fonction de la valeur ASCII
                m_prixCourant = m_tabInventaire[m_indexRangee, m_indexColonne].prix;
                if (m_tabInventaire[m_indexRangee, m_indexColonne].quantite == 0)   // Si la quantité est 0
                {
                    m_qteZero = true;   // Met la quantité restante à 0
                    tmr_1Sec.Enabled = true;    // Activation du timer de 1 seconde
                }

                SetClavierState(false); // Barre le clavier
            }
            else
            {
                m_indexRangee = bouton.Text[0] - 'A';   // Récupère le numéro de l'index en fonction de la valeur ASCII
                SetClavierChiffres();   // Met le clavier en mode chiffres
            }
            Affiche();  // Refresh l'affichage
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            m_indexRangee = 255;
            m_indexColonne = 255;
            m_annulationVente = true;
            m_retourCredit = m_credit;
            tmr_1Sec.Enabled = true;    // Activation du timer de 1 seconde
            SetClavierState(false); // Barre le clavier
            Affiche();  // Refresh l'affichage
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (m_indexRangee != 255 && m_indexColonne != 255)
            {
                if(m_credit < m_prixCourant)
                {
                    m_manqueCredit = true;
                    tmr_1Sec.Enabled = true;    // Activation du timer de 1 seconde
                }
                else
                {
                    m_distributionActive = true;
                    m_retourCredit = m_credit - m_prixCourant;
                    tmr_1Sec.Enabled = true;    // Activation du timer de 1 seconde
                }
            }
            Affiche();  // Refresh l'affichage
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender; //casting du sender en Button
            string temporaire = bouton.Text;
            temporaire = temporaire.Remove(4, 1);   // Efface le $
            temporaire = temporaire.Remove(1, 1);   // Efface le point
            m_credit += Convert.ToInt32(temporaire);// Ajout du nombre de crédits

            Affiche();  // Refresh l'affichage
        }

        /// <summary>
        /// Fonction servant à barrer ou débarrer le clavier en fonction de la valeur reçus
        /// </summary>
        /// <param name="state"> True = le clavier est débarré, False = le clavier est barré</param>
        private void SetClavierState(bool state)
        {
            for (int i = 0; i < NBCOLONNE; i++) // Pour chaque touche du clavier (autre que enter et clear)
            {
                m_Clavier[i].Enabled = state;   // Met le clavier à l'état spécifié
            }
        }

        private void SetClavierLettre()
        {
            int i = 0;
            for (i = 1; i < NBRANGEE + 1; i++)  // Pour chaque bouton
            {
                m_Clavier[i].Text = Convert.ToChar((i - 1) + 'A').ToString();   // Met le texte du clavier à la touche correspondante
            }
            m_Clavier[0].Text = " ";    // Met un espace pour le bouton 0
            for (/*Ne change pas i*/; i < NBCOLONNE; i++)   // Pour les boutons de trop
            {
                m_Clavier[i].Text = " ";    // Met des espaces pour les boutons de trop
            }
        }

        private void SetClavierChiffres()   
        {
            for (int i = 0; i < NBCOLONNE; i++) // Pour chaque bouton
            {
                m_Clavier[i].Text = i.ToString();   // Met le texte du clavier au nombre correspondant
            }
        }

        /// <summary>
        /// Fonction servant à afficher ce qui est générer par la fonction genererAffichage()
        /// </summary>
        private void Affiche()
        {
            // Génération d'un nouvelle affichage
            if (m_objAffichage.genererAffichage(m_indexRangee, m_indexColonne, m_credit, m_retourCredit, m_prixCourant, m_distributionActive, m_manqueCredit, m_annulationVente, m_qteZero))
            {
                // Refresh l'affichage si besoin (si genererAffichage = true)
                lb_Affichage.Items.Clear();    // Efface l'affichage
                for (int i = 0; i < 4; i++)
                {
                    lb_Affichage.Items.Add(m_objAffichage.lignesAffichage[i]);  // Ajoute le texte dans la liste box
                }
            }
        }


        private void tmr_1Sec_Tick_1(object sender, EventArgs e)
        {
            tmr_1Sec.Enabled = false;   // Désactivation du timer de 1 seconde


            if (m_manqueCredit) // Si il manque du crédit
            {
                m_manqueCredit = false; // Remet à false
            }
            else if (m_annulationVente)
            {
                m_credit = 0;
                m_annulationVente = false;
                m_prixCourant = 0;  // Remet le prix courant à 0
                m_retourCredit = 0; // Remet le retour de crédit à 0
                m_indexRangee = 255;    // Change l'index pour une valeur impossible
                m_indexColonne = 255;   // Change l'index pour une valeur impossible
                SetClavierState(true);  // Unlock le clavier
                SetClavierLettre(); // Met le clavien en mode lettre
            }
            else if (m_qteZero)
            {
                m_qteZero = false;
                m_indexRangee = 255;    // Change l'index pour une valeur impossible
                m_indexColonne = 255;   // Change l'index pour une valeur impossible
                SetClavierState(true);  // Unlock le clavier
                SetClavierLettre(); // Met le clavien en mode lettre
            }
            else if (m_distributionActive)  // Si la machine doit distribué l'item
            {
                m_distributionActive = false;   // Remet la distribution à false
                m_credit = 0;       // Remet le crédit à 0
                m_retourCredit = 0; // Remet le retour de crédit à 0
                m_prixCourant = 0;  // Remet le prix courant à 0
                m_tabInventaire[m_indexRangee, m_indexColonne].diminuerInventaire();    // Diminution de l'inventaire
                m_indexRangee = 255;    // Change l'index pour une valeur impossible
                m_indexColonne = 255;   // Change l'index pour une valeur impossible
                SetClavierState(true);  // Unlock le clavier
                SetClavierLettre(); // Met le clavien en mode lettre
            }
            Affiche();  // Refresh l'affichage
        }

        /// <summary>
        /// Lorsque le bouton pour la modification de l'inventaire est appuyé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modif_Click(object sender, EventArgs e)
        {
            bool error = true;
            if (cb_Colonne.Text[0] < '0' && cb_Colonne.Text[0] > ('0' + NBCOLONNE-1) && cb_Colonne.Text.Length > 1) // Si la valeur est entre '0' et le nombre de rangées de colonne (ici '9')
            {
                MessageBox.Show("Colonne invalide");    // Affiche un message d'erreur
                error = true;   // Une erreur à été détecté
            }
            else
            {
                cb_Colonne.SelectedIndex = (cb_Colonne.Text[0] - '0');  // Met l'index séléectionné de la colonne à la valeur spécifé
                error = false;  // Pas d'erreur
            }

            if ((cb_Rangee.Text[0] < 'A' && cb_Rangee.Text[0] > ('A' + NBRANGEE-1)) && cb_Rangee.Text.Length > 1 && !error) // Si la valeur est entre 'A' et la lettre du nombre de rangées maximale (ici 'F')
            {
                MessageBox.Show("Rangée invalide"); // Affiche un message d'erreur
                error = true;   // Une erreur à été détecté
            }
            else
            {
                cb_Rangee.SelectedIndex = (cb_Rangee.Text[0] - 'A');    // Met l'index séléectionné de la rangée à la valeur spécifé
                error = false;  // Pas d'erreur
            }

            if(!error)  // Si il n'y a pas d'erreur
                if (!(m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].modifierInventaire(Convert.ToInt32(tb_Price.Text), Convert.ToInt32(tb_Quantity.Text))))
                    MessageBox.Show("Prix ou quantité invalide");   // Affiche un message d'erreur si l'opération est invalide
        }

        /// <summary>
        /// Fonction servant à changer le contenu des textbox lorsque l'on change de pages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].prix;    // Prix de l'item correspondante
            int quantity = m_tabInventaire[cb_Rangee.SelectedIndex, cb_Colonne.SelectedIndex].quantite; // Quantité de l'item correspondante
            tb_Price.Text = price.ToString();   // Met le prix dans la text box
            tb_Quantity.Text = quantity.ToString(); // Met la quantité dans la text box
        }
    }
}
