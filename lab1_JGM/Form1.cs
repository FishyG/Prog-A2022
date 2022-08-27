using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_JGM
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();

            bool rotate = false;

            if(rotate)
            {

                Task.Delay(500);
            }
        }

        private void button_RemoveSpace(object sender, EventArgs e)
        {
            resultTextBox.Text = inputTextBox.Text.Replace(" ",""); // Remplace les espaces par des espaces vide
        }

        private void button_InvertChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                resultTextBox.Text = c + resultTextBox.Text;    // Met les caractères dans le sens inverse
            }
        }

        private void button_DoubleChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                resultTextBox.Text = resultTextBox.Text + c + c;    // Double le caractère
            }
        }

        private void button_SkipOneChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            int i = 0;

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                i++;
                if (i % 2 == 1) // Modulo de 2 donc la condition est vrai une fois sur deux
                    resultTextBox.Text = resultTextBox.Text + c;
            }
        }

        private void button_MajMin(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            int i = 0;
            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                i++;

                if (i % 2 == 1) // Modulo de 2 donc la condition est vrai une fois sur deux
                    resultTextBox.Text = resultTextBox.Text + c.ToString().ToUpper();   // Lettre majuscule
                else
                    resultTextBox.Text = resultTextBox.Text + c.ToString().ToLower();   // Lettre minuscule
            }
        }

        private void button_Password(object sender, EventArgs e)
        {
            bool validMDP = true;
            
            foreach(char c in inputTextBox.Text)
            {
                if (Convert.ToUInt64(c) > 127)
                {
                    validMDP = false;
                }
            }
        }

        private void button_OnlyOneSpace(object sender, EventArgs e)
        {
            char oldC = '\0';

            resultTextBox.Text = "";    // Empty the string 

            foreach (char c in inputTextBox.Text.Trim()) // Pour chaque caractères de la string (trim() efface les espaces à la fin et au début)
            {
                if (oldC == ' ' && c == ' ')
                { } // Ne copie pas si il y a deux espaces collé
                else
                    resultTextBox.Text = resultTextBox.Text + c.ToString(); // Copie le caractère s'il n'est pas un double espace (' ')
                oldC = c;
            }
        }

        private void button_InvertWord(object sender, EventArgs e)
        {
            btnOnlyOneSpace.PerformClick(); // Call btnOnlyOneSpace pour effacer les espaces en trop

            string[] words = resultTextBox.Text.Split(' '); // Sépare la string en mots à chaque fois qu'il y a un espace
            
            resultTextBox.Text = "";    // Vide la string

            for (int i = 0; i < words.Length; i++)
            {
                resultTextBox.Text = words[i] + " " + resultTextBox.Text;   // Remet les caractères ensemble dans l'ordre inverse
            }
        }

        private void button_CountWord(object sender, EventArgs e)
        {
            int i = 0;

            btnOnlyOneSpace.PerformClick(); // Call btnOnlyOneSpace pour effacer les espaces en trop

            if (resultTextBox.Text.Length != 0) // Si la string n'est pas vide
            {
                string[] words = resultTextBox.Text.Split(' '); // Sépare la string en un tableau de string (split la string à chaque espace)
                i = words.Length;   // Compte le nombre de mots
            }

            resultTextBox.Text = "Nombre de mot(s) : " + Convert.ToString(i);   // Affiche le nombre de mots
        }

        private void button_Rotate(object sender, EventArgs e)
        {
            if(tmr500ms.Enabled)
            { 
                btnRotate.Text = "Rotation";
                tmr500ms.Enabled = false;   // Stop le timer de 500ms
            }
            else
            {
                btnRotate.Text = "Stop Rotation";
                tmr500ms.Enabled = true;    // Start le timer de 500ms
            }
        }

        private void button_Ascii(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)
            {
                resultTextBox.Text = resultTextBox.Text + Convert.ToString(Convert.ToUInt64(c)) + " ";  // Convertie la variable char en l'équivalent sur le tableau ascii (ex: A = 65) puis convertie le nombre en string afin de pouvoir l'afficher
            }
        }
        
        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quitter l'application
        }

        private void tmr500ms_Tick(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length == 0) // Si resultBox est vide
            {
                resultTextBox.Text = inputTextBox.Text; // Met le text de inputBox dans resultBox
            }   

            char[] character = resultTextBox.Text.ToCharArray();    // Conversion de la string en tableau de char
            char temp = character[character.Length - 1];            // Varaible temporaire pour variable qui va être remplacé

            for (int i = character.Length - 1; i > 0; i--)
            {
                character[i] = character[i-1];  // Déplace les caractères d'un espace vers la droite
            }
            character[0] = temp;    // Met la valeur temporaire à gauche

            resultTextBox.Text = string.Join("",character);    // Conversion du tableau 
        }
    }
}
