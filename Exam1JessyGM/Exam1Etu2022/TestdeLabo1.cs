//Votre nom: 
//septembre 2022


using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestLabo1
{
    public partial class ExamenLabo1 : Form
    {
        
        private const int NB_JOUEUR = 17;
        private const int NB_CBOX = 20;
 

        static readonly string[] m_listeJoueurs = { "Nathanaël Amaridon", "Thomas Bélanger", "Jackob Breton", "David Corriveau", "Étienne Dubé", "Andy Flores-Gonzalez", "Marc-Étienne Gendron-Fontaine", "Éric Gingras", 
                                                    "Nicolas Gosselin", "Jessy Grimard-Maheu", "Félix-Antoine Guimont", "Jérémie Hamel", "Zachary Poulin","Samuel Savaria", "Mathis Savoie","Jacob Turcotte", "Barin Wahidi" };
        private Joueur[] m_tabJoueur = new Joueur[NB_JOUEUR];
        private int m_nbJoueur=0;
        
        CheckBox[] m_checkBoxes = new CheckBox[NB_CBOX];    // Pour Q2

        public ExamenLabo1()
        {
            

            InitializeComponent();
          
            for(int i = 0; i<NB_JOUEUR; i++)
            {
                comboBoxQ3.Items.Add(m_listeJoueurs[i]);
            }
            comboBoxQ3.DropDownStyle = ComboBoxStyle.DropDownList; //Empèche l'usger d'ajouter ou modifier la liste de joueurs
            comboBoxQ3.SelectedIndex = 0; //1er joueur de la liste sélectionné

            for (int i = 0; i < NB_CBOX; i++)   // Pour Q2
            {
                m_checkBoxes[i] = new CheckBox();
                m_checkBoxes[i].AutoSize = true;
                m_checkBoxes[i].Location = new System.Drawing.Point(370, (i * 20) + 100);
                this.Controls.Add(m_checkBoxes[i]);
            }
        }


        #region Q1
        
        private void tbSaisieQ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool unefois = false;
            foreach (var c in tbSaisieQ1.Text)
            {
                if (c == '#')
                    unefois = true;
            }

            if (unefois && e.KeyChar == '#')
            {
                e.Handled = true;
            }

            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '#' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            bool unefois = false;
            foreach (var c in tbSaisieQ1.Text)
            {
                if (c == '#')
                    unefois = true;
            }

            if (unefois)
            {
                string[] words = tbSaisieQ1.Text.Split('#'); // Sépare la string en mots à chaque fois qu'il y a un espace

                tbSaisieQ1.Text = words[1] + "#" + words[0];   // Remet les caractères ensemble dans l'ordre inverse
            }
        }

        #endregion  // Q1

        #region Q2

        private void btnTourne_Click(object sender, EventArgs e)
        {
            if (monTimer.Enabled)
            {
                monTimer.Enabled = false;   // Stop le timer de 500ms
            }
            else
            {
                monTimer.Enabled = true;    // Start le timer de 500ms
            }
        }

        private void monTimer_Tick(object sender, EventArgs e)
        {
            bool temp = m_checkBoxes[m_checkBoxes.Length - 1].Checked;            // Varaible temporaire pour variable qui va être remplacé

            for (int i = m_checkBoxes.Length - 1; i > 0; i--)
            {
                m_checkBoxes[i].Checked = m_checkBoxes[i - 1].Checked;  // Déplace les caractères d'un espace vers la droite
            }
            m_checkBoxes[0].Checked = temp;    // Met la valeur temporaire à gauche
        }



        #endregion  // Q2

        #region Q3


        private void btnNvJoueur_Click(object sender, EventArgs e)
        {
            //à compléter ...
            string[] human = comboBoxQ3.Text.Split(' '); // Sépare la string en mots à chaque fois qu'il y a un espace
            bool spaceleft = true;
            bool onlyOneDude = true;

            for (int i = 0; i < m_tabJoueur.Length; i++)
            {
                if(m_tabJoueur[i] != null)
                    if (human[0] == m_tabJoueur[i].m_prenom)
                        onlyOneDude = false;
            }

            if (onlyOneDude)    // Si ya pas deux fois le meme dude
            {
                for (int i = 0; i < m_tabJoueur.Length; i++)
                {
                    if (m_tabJoueur[i] == null && spaceleft)
                    {
                        spaceleft = false;
                        m_tabJoueur[i] = new Joueur(human[0], human[1]);
                    }
                }
            }
            else
                MessageBox.Show("Yé déja là mon pti torieu"); // Affiche un message d'erreur
            
            affiche();
            //passe au prochain élément du combo box en s'assurant de ne pas dépasser la fin
            if (comboBoxQ3.SelectedIndex < comboBoxQ3.Items.Count-1)
                comboBoxQ3.SelectedIndex++;
        }

        private void affiche()
        {
            int i;
            string s;
            lbQ3.Items.Clear();

            for (i = 0; i < m_tabJoueur.Length; i++)
            {
                if (m_tabJoueur[i] != null)
                {
                    s = m_tabJoueur[i].m_prenom + " " + m_tabJoueur[i].m_nom;
                    lbQ3.Items.Add(s + ", Vies = " + m_tabJoueur[i].getVie().ToString());

                }
            }
        }
        private void lbQ3_DoubleClick(object sender, EventArgs e)
        {
            ListBox joueurToKill = (ListBox)sender;
            if (joueurToKill.SelectedIndex >= 0)
            {
                // Remove une vie au joueur si plus que 1
                //else Affiche un message d'erreur
            }
        }

        #endregion  // Q3
    }
}
