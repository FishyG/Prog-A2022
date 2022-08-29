using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine2_Exemple1
{
    public partial class Form1 : Form
    {
        const int NB_TEXTBOX = 5;
        TextBox[] m_arrayTextBox = new TextBox[NB_TEXTBOX];

        public Form1()
        {
            InitializeComponent();

            Control ctrlSuivant;  //déclaration d'un objet Control
            ctrlSuivant = panelTextBox;  // Le point de départ de la recherche sera le Pannel

            for (int i = 0; i < NB_TEXTBOX; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);
                m_arrayTextBox[i] = (TextBox)ctrlSuivant; //casting de l'objet Control trouvé (ctrlSuivant) en TextBox
            }
        }

        // On désire que 3 boutons partagent le même événement, alors on
        // sélectionne les 3 boutons avec la souris et dans la fenêtre des propriétés
        // on choisi de voir les événements et dans le "Click" on inscrit le nom désiré, soit ABC_Click et l'on presse ENTER
        // Ceci va associer la même fonction Click sur les 3 boutons
        // Une fois dans l'événement click, on devra utiliser le sender pour savoir de quel bouton provient l'événement.
        private void ABC_Click(object sender, EventArgs e)
        {
            Button bouton;
            string chaine;

            bouton = (Button)sender; //casting du sender en Button
            chaine = bouton.Text; //on récupère le texte inscrit sur le bouton
            //resultatLabel.Text = resultatLabel.Text + chaine;
            for (int i = 0; i < NB_TEXTBOX; i++)
            {
                m_arrayTextBox[i].Text += chaine;
            }

        }
    }
}
