using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampeDel_Etu
{
    public partial class Form1 : Form
    {
        /********* constantes ***********/
        public const int NB_DEL = 11;

        /********** variables membres ***********/
        private TrackBar[] m_LumTrackBar = new TrackBar[NB_DEL];  // Tableau de TrackBar pour les lumières (DEL et Halogènes)
        private TextBox[] m_LumTextBox = new TextBox[NB_DEL];     // Tableau de TextBox pour les lumières (DEL et Halogènes)

        public Form1()
        {
            InitializeComponent();

            Control ctrlSuivant;        // Déclaration d'un objet Control
            ctrlSuivant = lumierePanel; // Le point de départ de la recherche sera le Pannel du contrôle des DELs

            // Boucle pour le tableau de TrackBar
            for (int i = 0; i < NB_DEL; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_LumTrackBar[i] = (TrackBar)ctrlSuivant;           // Casting de l'objet Control trouvé (ctrlSuivant) en TrackBar
                m_LumTrackBar[i].Tag = i;                           // Assigne le tag
            }
            // Boucle pour le tableau de TextBox
            for (int i = 0; i < NB_DEL; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_LumTextBox[i] = (TextBox)ctrlSuivant;             // Casting de l'objet Control trouvé (ctrlSuivant) en TrackBar
                m_LumTextBox[i].Tag = i;                            // Assigne le tag
                m_LumTextBox[i].Text = "0";                         // Met le texte à 0
            }
        }

        /// <summary>
        /// Met la valeur des "Trackbars" dans les boites de texte correspondantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lum1TrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;

            m_LumTextBox[(int)trackBar.Tag].Text = Convert.ToString(trackBar.Value);    // Met la valeur des "Trackbars" dans les boites de texte correspondantes

        }

        /// <summary>
        /// Pour gèrer les caractères reçus dans les boites de texte. Tous les caractères
        /// sont ignorer sauf les chiffres et le "Backspace" et le "Delete"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 0x08))
                e.Handled = true;
        }

        /// <summary>
        /// Remet toutes les boites de texte et les "TrackBars" à zéro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void razDelsButton_Click(object sender, EventArgs e)
        {
            foreach (TrackBar trackBar in m_LumTrackBar)
            {
                trackBar.Value = 0;
                m_LumTextBox[(int)trackBar.Tag].Text = "0";
            }
        }

        /// <summary>
        /// Ajoute 10 à toutes les boites de texte et les "TrackBars"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addValeurLumiere_Click(object sender, EventArgs e)
        {
            foreach (TrackBar trackBar in m_LumTrackBar)
            {
                if (trackBar.Value < 100)
                {
                    if (trackBar.Value >= 90)
                        trackBar.Value = 100;
                    else
                        trackBar.Value += 10;

                    m_LumTextBox[(int)trackBar.Tag].Text = Convert.ToString(trackBar.Value);
                }
            }
        }

        /// <summary>
        /// Soustrait 10 à toutes les boites de texte et les "TrackBars"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sousValeurLumiere_Click(object sender, EventArgs e)
        {
            foreach (TrackBar trackBar in m_LumTrackBar)
            {
                if (trackBar.Value > 0)
                {
                    if (trackBar.Value <= 10)
                        trackBar.Value = 0;
                    else
                        trackBar.Value -= 10;

                    m_LumTextBox[(int)trackBar.Tag].Text = Convert.ToString(trackBar.Value);
                }
            }
        }

        /// <summary>
        /// Pour modifier les "TrackBars" quand les boites de texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lum1TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text != null)
            {
                try
                {
                    if (Convert.ToInt32(textBox.Text) >= 100)
                        textBox.Text = "100";

                    m_LumTrackBar[(int)textBox.Tag].Value = Convert.ToInt32(textBox.Text);  // Change la trackBar pour la valeur dans la boite de texte
                }
                catch (System.FormatException)  // Catch the exception (when less or equal to 0)
                {
                    m_LumTrackBar[(int)textBox.Tag].Value = 0;  // Force la valeur de la trackbar à zéro
                    textBox.Text = "0";                         // Force la valeur de la textbox à zéro
                }
            }
        }

        /// <summary>
        /// Pour afficher le "Temps de consigne" en format 24H00 quand le pointeur est déplacé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tempsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            tempsConsigneTexteLabel.Text = "Temps de consigne : " + Convert.ToString(tempsTrackBar.Value / 2);  // Affichage tu temps à l'heure précise

            // Ajout précision aux 30 minutes
            if (tempsTrackBar.Value % 2 != 0)   // Si on doit afficher les 30 minutes
                tempsConsigneTexteLabel.Text += "H30";
            else                                // Si on ne doit PAS afficher les 30 minutes
                tempsConsigneTexteLabel.Text += "H00";
        }
    }
}
