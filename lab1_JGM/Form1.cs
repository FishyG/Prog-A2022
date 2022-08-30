/**
 * @file   form1.cs
 * @author A.Bernier
 * @date   8/28/2022
 * @brief  LaboChaines pour le cours 247-516-SH-A22. Le but de ce laboratoire est de ce familiariser avec les types string (chaine de caractère)
 * 
 *
 * @version 1.0 : Première version
 * Environnement de développement: Visual Studio 2022
 * Matériel: N/A
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_JGM
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();  // Permet l'initialisation des composants
        }

        /// <summary>
        /// Ce bouton permet d'enlever tous les espaces de la chaîne de caractères contenus dans le champ de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RemoveSpace(object sender, EventArgs e)
        {
            resultTextBox.Text = inputTextBox.Text.Replace(" ",""); // Remplace les espaces par des espaces vide
        }

        /// <summary>
        /// Ce bouton permet d'afficher en ordre inverse la chaîne de caractères.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_InvertChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                resultTextBox.Text = c + resultTextBox.Text;    // Met les caractères dans le sens inverse
            }
        }

        /// <summary>
        /// Ce bouton permet de doubler chacun des caractères apparaissant dans la chaîne de saisie. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DoubleChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                resultTextBox.Text = resultTextBox.Text + c + c;    // Double le caractère
            }
        }

        /// <summary>
        /// Ce bouton permet d'afficher qu'une seule lettre sur 2. On affiche une lettre, on en saute une, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SkipOneChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            int i = 0;

            foreach (char c in inputTextBox.Text)   // Pour chaque caractères de la string
            {
                i++;    // Incrémentation à chaque caractère
                if (i % 2 == 1) // Modulo de 2 donc la condition est vrai une fois sur deux
                    resultTextBox.Text = resultTextBox.Text + c;
            }
        }

        /// <summary>
        /// Ce bouton met la première lettre en majuscule, la deuxième en minuscule, la troisièmes en majuscule, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ce bouton vérifie la validité et la force du mot de passe entrée dans le champ de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Password(object sender, EventArgs e)
        {
            int charLower = 0;
            int charUpper = 0;
            int charDigit = 0;
            int charOther = 0;
            bool validMDP = true;

            int forceIndex = -1;
            string[] force = { "faible", "moyen", "fort", "très fort" };

            if (inputTextBox.Text.Length < 8) // Le mot de passe doit avoir au moins 8 caractères
            {
                validMDP = false;
            }
            else
            {
                foreach (char c in inputTextBox.Text)
                {
                    if (Convert.ToUInt32(c) > 127)  // Si le caractère est supérieur à 127
                    {
                        validMDP = false;
                    }
                    if (c == ' ')   // Si le caractère est un espace 
                    {
                        validMDP = false;
                    }
                }
            }

            if (validMDP)
            {
                foreach (char c in inputTextBox.Text)
                {
                    if (char.IsLower(c))    // Vérification minuscule
                        charLower = 1;

                    if (char.IsUpper(c))    // Vérification majuscule
                        charUpper = 1;

                    if (char.IsDigit(c))    // Vérification chiffre
                        charDigit = 1;

                    if (!char.IsLetterOrDigit(c))   // Vérification ni chiffre ni lettre
                        charOther = 1;
                }

                forceIndex = (charLower + charUpper + charDigit + charOther) - 1;   // Conversion des valeurs binaire en int
            }

            if (forceIndex < 0) // Si le mot de passe n'est pas valide
                resultTextBox.Text = "Invalide";    // Affiche la force du mot de passe ("faible", "moyen", "fort", "très fort")
            else
                resultTextBox.Text = force[forceIndex]; 
        }

        /// <summary>
        /// Ce bouton permet de retirer les espaces au début et à la fin de la chaîne, en plus de faire en sorte de ne laisser qu'un seul espace entre chacun des mots. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ce bouton permet d'inverser les mots dans la chaîne. Il retire les espaces supplémentaires au début et à la fin de la chaîne en plus de ne laisser qu'un seul espace entre les mots.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ce bouton permet d'affiche le nombre de mots dans la chaîne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ce bouton, copie le champ de saisie dans le champ résultat et démarrer un timer qui fera une rotation des lettres du champ de résultat à chaque 500ms.
        /// Le texte du bouton change pour Stop rotation et si on appuie dessus à nouveau, la rotation s'arrête et le texte redevient simplement Rotation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Rotate(object sender, EventArgs e)
        {
            if(tmr500ms.Enabled)
            { 
                btnRotate.Text = "Rotation";// Change le texte pour "Rotation"
                tmr500ms.Enabled = false;   // Stop le timer de 500ms
            }
            else
            {
                if (inputTextBox.Text.Length > 0)  // Si resultBox n'est pas vide
                {
                    btnRotate.Text = "Stop Rotation";// Change le texte pour "Stop Rotation"
                    tmr500ms.Enabled = true;    // Start le timer de 500ms
                }
            }
        }

        /// <summary>
        /// On affiche dans le champ de résultat le code ASCII de chacune des lettres du champ de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Ascii(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)   
            {
                resultTextBox.Text = resultTextBox.Text + Convert.ToString(Convert.ToUInt64(c)) + " ";  // Convertie la variable char en l'équivalent sur le tableau ascii (ex: A = 65) puis convertie le nombre en string afin de pouvoir l'afficher
            }
        }
        
        /// <summary>
        /// Permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitter_Click(object sender, EventArgs e)
        {
            SoundPlayer quack = new SoundPlayer(lab1_JGM.Properties.Resources.DuckQuack);   // Charge le fichier audio pour pouvoir le jouer
            quack.Play();   // Quack
            Thread.Sleep(500);  // Délais de 500ms pour permettre de jouer l'audio
            Application.Exit(); // Quitter l'application
        }

        /// <summary>
        /// Timer de 500ms pour la fonction rotate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr500ms_Tick(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length <= 0) // Si resultBox est vide
            {
                resultTextBox.Text = inputTextBox.Text; // Met le text de inputBox dans resultBox
            }
            else // Si resultBox n'est pas vide
            {
                char[] character = resultTextBox.Text.ToCharArray();    // Conversion de la string en tableau de char
                char temp = character[character.Length - 1];            // Varaible temporaire pour variable qui va être remplacé

                for (int i = character.Length - 1; i > 0; i--)
                {
                    character[i] = character[i - 1];  // Déplace les caractères d'un espace vers la droite
                }
                character[0] = temp;    // Met la valeur temporaire à gauche

                resultTextBox.Text = string.Join("", character);    // Conversion du tableau 
            }
        }
    }
}
