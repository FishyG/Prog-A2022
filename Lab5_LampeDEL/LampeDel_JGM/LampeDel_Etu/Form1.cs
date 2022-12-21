using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LampeDel_Etu
{
    public partial class Form1 : Form
    {
        /********** variables membres ***********/
        private TrackBar[] m_LumTrackBar = new TrackBar[Constantes.NB_DEL];  // Tableau de TrackBar pour les lumières (DEL et Halogènes)
        private TextBox[] m_LumTextBox = new TextBox[Constantes.NB_DEL];     // Tableau de TextBox pour les lumières (DEL et Halogènes)
        List<Recette> objRecette = new List<Recette>(); //on devra instancier 48 objets recettes.

        public Form1()
        {
            InitializeComponent(); 

            // Création d'une liste de 48 objets recettes
            for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
            {
                objRecette.Add(new Recette(Constantes.NB_DEL));
            }

            #region Assign Tag
            Control ctrlSuivant;        // Déclaration d'un objet Control
            ctrlSuivant = lumierePanel; // Le point de départ de la recherche sera le Pannel du contrôle des DELs

            // Boucle pour le tableau de TrackBar
            for (int i = 0; i < Constantes.NB_DEL; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_LumTrackBar[i] = (TrackBar)ctrlSuivant;           // Casting de l'objet Control trouvé (ctrlSuivant) en TrackBar
                m_LumTrackBar[i].Tag = i;                           // Assigne le tag
            }
            // Boucle pour le tableau de TextBox
            for (int i = 0; i < Constantes.NB_DEL; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);    // Passe au control suivant
                m_LumTextBox[i] = (TextBox)ctrlSuivant;             // Casting de l'objet Control trouvé (ctrlSuivant) en TrackBar
                m_LumTextBox[i].Tag = i;                            // Assigne le tag
                m_LumTextBox[i].Text = "0";                         // Met le texte à 0
            }
            #endregion // Assign Tag

            #region Graphique

            // Efface la série et l'area présente par défaut dans les propriétés de l'objet Chart
            //**** Cette section peut aussi se faire via l'éditeur de l'objet chart****
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            //Pour le grah du haut 
            chart1.Titles.Add("Recette pour chaque DEL");
            chart1.ChartAreas.Add("DEL");

            //Ajout des courbes
            for (int i = 1; i < Constantes.NB_DEL; i++)
            {
                chart1.Series.Add("DEL" + i.ToString());
                chart1.Series["DEL" + i.ToString()].ChartType = SeriesChartType.Line; //type xy
            }
            chart1.Series.Add("HALO");
            chart1.Series["HALO"].ChartType = SeriesChartType.Line; //type xy

            chart1.ChartAreas["DEL"].AxisX.Minimum = 0;
            chart1.ChartAreas["DEL"].AxisX.Maximum = 48;
            chart1.ChartAreas["DEL"].AxisX.Interval = 4;
            chart1.ChartAreas["DEL"].AxisY.Minimum = 0;
            chart1.ChartAreas["DEL"].AxisY.Maximum = 100;
            chart1.ChartAreas["DEL"].AxisY.Interval = 20;
            chart1.Series.Add("Bogus");
            chart1.Series["Bogus"].Points.AddXY(0,0);
            
            #endregion
        }

        //#region 
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
                if (trackBar.Value >= 90)
                    trackBar.Value = 100;
                else
                    trackBar.Value += 10;

                m_LumTextBox[(int)trackBar.Tag].Text = Convert.ToString(trackBar.Value);
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
                if (trackBar.Value <= 10)
                    trackBar.Value = 0;
                else
                    trackBar.Value -= 10;

                m_LumTextBox[(int)trackBar.Tag].Text = Convert.ToString(trackBar.Value);
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

                    textBox.SelectionStart = textBox.Text.Length;   // Remet le curseur de la textBox à droite
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

            for (int i = 0; i < Constantes.NB_DEL; i++)
            {
                m_LumTrackBar[i].Value = objRecette[tempsTrackBar.Value].del[i];
            }
        }

        private void enregistrerButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Constantes.NB_DEL; i++)
            {
                objRecette[tempsTrackBar.Value].del[i] = m_LumTrackBar[i].Value;
            }

            objRecette[tempsTrackBar.Value].pointEnr = true;
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int value = 0;
            string[] ligne = new string[Constantes.NB_DEL];
            StreamReader srFile;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sus files (*.csv)|*.csv|text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.DefaultExt = ".csv";    // The file must be a ".csv"

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                srFile = File.OpenText(openFileDialog.FileName);
                srFile.ReadLine();
                srFile.ReadLine();
                try
                {
                    for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
                    {
                        ligne = srFile.ReadLine().Split(';');

                        if (ligne[1] == "")
                        {
                            for (int j = 0; j < Constantes.NB_DEL; j++)
                            {
                                objRecette[i].del[j] = 0;
                            }
                            objRecette[i].pointEnr = false;
                        }
                        else
                        {
                            for (int j = 0; j < Constantes.NB_DEL; j++)
                            {
                                value = Convert.ToInt32(ligne[j + 1]);
                                if (value > 100 || value < 0)
                                    throw new System.FormatException();
                                else
                                    objRecette[i].del[j] = value;
                            }
                            objRecette[i].pointEnr = true;
                        }
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Donnée invalide dans le fichier","Erreur de lecture",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    remetAZero();
                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Impossible de lire le fichier", "Erreur de lecture", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    remetAZero();
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible de lire le fichier", "Erreur dangereuse", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    remetAZero();
                }
            }
            tempsTrackBar_ValueChanged(null, EventArgs.Empty);      // Ajuste les trackBars automatiquement lorsqu'un nouveau fichier est chargé
            tabPTableau_Enter(null, EventArgs.Empty);// Ajuste le dataGridView automatiquement lorsqu'un nouveau fichier est chargé
            tabPGraph_Enter(null, EventArgs.Empty);
            //srFile.Close();
        }

        /// <summary>
        /// Charge le dataGridView avec les nouvelles données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPTableau_Enter(object sender, EventArgs e)
        {
            initializeDataGridView();

            for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
            {
                if (objRecette[i].pointEnr)
                {
                    for (int j = 0; j < Constantes.NB_DEL; j++)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = objRecette[i].del[j];
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                }
                else
                {
                    for (int j = 0; j < Constantes.NB_DEL; j++)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = objRecette[i].del[j];
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPGraph_Enter(object sender, EventArgs e)
        {
            setAllChecked(true);
            for (int i = 1; i < Constantes.NB_DEL; i++)
            {
                chart1.Series["DEL" + i.ToString()].Points.Clear();
                

                for (int j = 0; j < Constantes.NB_DEMI_HRE; j++)
                {
                    if (true)
                    {
                        chart1.Series["DEL" + i.ToString()].Points.AddXY(j, objRecette[j].del[i]);
                    }
                }
                
            }
            chart1.Series["HALO"].Points.Clear();
        }

        /// <summary>
        /// Initalise le dataGridView1 en ajoutant l'heure et met les valeurs des autres rangées à 0
        /// </summary>
        private void initializeDataGridView()
        {
            string heure = "Test";
            
            dataGridView1.Rows.Clear(); // Clear the rows of the dataGridView

            for (int i = 1; i < Constantes.NB_DEMI_HRE + 1; i++)
            {
                heure = Convert.ToString((Constantes.NB_DEMI_HRE - i) / 2);  // Affichage tu temps à l'heure précise

                // Ajout précision aux 30 minutes
                if (i % 2 != 0)     // Si on doit afficher les 30 minutes
                    heure += "H30";
                else                // Si on ne doit PAS afficher les 30 minutes
                    heure += "H00";

                dataGridView1.Rows.Insert(0, heure);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void remetAZero()
        {
            for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
            {
                for (int j = 0; j < Constantes.NB_DEL; j++)
                {
                    objRecette[i].del[j] = 0;
                }
                objRecette[i].pointEnr = false;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Met tous les checkbox à l'état demandé.
        /// </summary>
        /// <param name="state"> État de</param>
        private void setAllChecked(bool state) 
        {
            // Active toutes les checked box
            for (int i = 0; i < checkedListBoxDEL.Items.Count; i++)
            {
                checkedListBoxDEL.SetItemChecked(i, state);
                chart1.Series[i].Enabled = state;
            }
        }

        private void checkedListBoxDEL_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = (int)e.Index;

            if(e.NewValue == CheckState.Checked)
                chart1.Series[i].Enabled = true;
            else
                chart1.Series[i].Enabled = false;        
        }

        private void btnHideAll_Click(object sender, EventArgs e)
        {
            setAllChecked(false);
        }

        private void btnInterpol_Click(object sender, EventArgs e)
        {
            int x1 = 0;
            int x2 = 0; 
            int nbpoints = 0;
            int firstPoint = 0;
            int testDel2 = 0;
            int testDel1 = 0;

            for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
            {
                if (objRecette[i].pointEnr)
                {
                    if (nbpoints == 0)
                    {
                        x1 = i;
                        firstPoint = x1;
                    }
                    else if (nbpoints == 1)
                    {
                        x2 = i;
                        InterpolSection(x1, x2);
                    }
                    else
                    {
                        x1 = x2;
                        x2 = i;
                        InterpolSection(x1, x2);
                    }

                    nbpoints++;
                }
            }
            if (nbpoints == 1)
            {
                for (int i = 0; i < Constantes.NB_DEMI_HRE; i++)
                {
                    for (int j = 0; j < Constantes.NB_DEL; j++)
                    {
                        objRecette[i].del[j] = objRecette[x1].del[j];   // Set all the points to the same
                    }
                }
            }
            else if (nbpoints > 1)
            {
                for (int i = x2; i < (Constantes.NB_DEMI_HRE + firstPoint); i++)
                {
                    for (int j = 0; j < Constantes.NB_DEL; j++)
                    {
                        testDel1 = objRecette[x2].del[j];
                        testDel2 = objRecette[firstPoint].del[j];

                        if (i >= Constantes.NB_DEMI_HRE)
                            objRecette[i - Constantes.NB_DEMI_HRE].del[j] = InterpolLineaire(i, x2, Constantes.NB_DEMI_HRE + firstPoint, testDel1, testDel2);
                        else
                            objRecette[i].del[j] = InterpolLineaire(i, x2, Constantes.NB_DEMI_HRE + firstPoint, testDel1, testDel2);
                    }
                }

            }
            tabPTableau_Enter(null, EventArgs.Empty);   // Ajuste le dataGridView automatiquement après l'interpolation
        }

        //Fait l'interpolation de tous les points x (demi-heure) entre deux points enregistrés (x1 et x2). 
        //Utilisera la méthode InterpolLineaire
        private void InterpolSection(int x1, int x2)
        {
            for (int i = x1; i < x2; i++)
            {
                for (int j = 0; j < Constantes.NB_DEL; j++)
                {
                    //Exemple d'appel à InterpolLineaire
                    objRecette[i].del[j] = InterpolLineaire(i, x1, x2, objRecette[x1].del[j], objRecette[x2].del[j]);
                }
            }
        }


        //Permet de trouver la valeur y à partir de l'équation y=mx+b. Les points x_Start, x_Fin, y_Start et y_Fin sont utilisés pour trouver 
        //les valeurs de m et de b
        private int InterpolLineaire(int x, int x_Start, int x_Fin, int y_Start, int y_Fin)
        {
            float m = 0;    // Float au lieu de int pour une meilleur précision
            float b = 0;    // Float au lieu de int pour une meilleur précision
            int retour = 0;


            m = (float)(y_Fin - y_Start) / (float)(x_Fin - x_Start);
            b = (float)(y_Start - m * x_Start);

            retour = Convert.ToInt16((m * x) + b);
            
            return retour;
        }
    }
}