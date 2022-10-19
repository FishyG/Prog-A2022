using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoList
{
    public partial class Form1 : Form
    {

        List<int> chiffres = new List<int>(); // création de la liste. On met le type d'objets entre <>
        List<int> lettres = new List<int>(); // création de la liste. On met le type d'objets entre <>

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                chiffres.Add(i + '0'); // Ajout de code ascii (chiffres)
                lettres.Add(i + 'A'); // Ajout de code ascii (lettres)
            }
            affiche();
        }


        void affiche()
        {
            textBox1.Clear();
            textBox2.Clear();
            foreach (int chiffre in chiffres)
                textBox1.Text += Convert.ToChar(chiffre) + " ";
            foreach (int lettre in lettres)
                textBox2.Text += Convert.ToChar(lettre) + " ";

        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = Convert.ToInt32(tboxPosition.Text);
                lettres.Insert(pos, (chiffres[pos]));
                affiche();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.ToString());

            }
        }

        private void btnHaut_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = Convert.ToInt32(tboxPosition.Text);
                chiffres.Insert(pos, (lettres[pos]));
                affiche();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.ToString());

            }
        }



        private void btnEchange_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = Convert.ToInt32(tboxPosition.Text);
                chiffres.Insert(pos, (lettres [pos]));
                lettres.Insert(pos, (chiffres[pos + 1]));
                chiffres.RemoveAt(pos + 1);
                lettres.RemoveAt(pos + 1);
            }
            catch
            {
                MessageBox.Show("Position invalide");
                return;
            }

            affiche();
        }
    }
}
