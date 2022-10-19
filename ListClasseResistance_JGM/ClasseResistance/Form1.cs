using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; //pour decimal separator (cultureinfo)
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseResistance
{
    public partial class Form1 : Form
    {
        const int NBRESMAX = 20; 
        Resistance[] m_tabOblRes = new Resistance[NBRESMAX];    // instanciation d'un tableau de resistance
        int m_nbRes = 0;

        public Form1()
        {
            InitializeComponent();
            m_tabOblRes[0] = new Resistance(1000);    // instanciation d'une resistance de 1k
            tbVolt.Value = 5;
            lblVolt.Text = tbVolt.Value.ToString() + " Volts";
            majAffichage();
        }

        private void bAjouteR_Click(object sender, EventArgs e)
        {
            bool spaceleft = true;
            for (int i = 0; i < m_tabOblRes.Length; i++)
            {
                if (m_tabOblRes[i] == null && spaceleft)
                {
                    spaceleft = false;
                    m_tabOblRes[i] = new Resistance(Convert.ToInt32(textBoxR.Text));
                }
            }
            majAffichage();
        }


        private void majAffichage()
        {
            majList();

            lbListeRes.Items.Clear();
            for (int i = 0; i < m_tabOblRes.Length; i++)
            {
                if(m_tabOblRes[i] != null)
                    lbListeRes.Items.Add("R"+ Convert.ToString(i+1) + " = " + Convert.ToString(m_tabOblRes[i].m_valRes) + "Ohms, " + Convert.ToString(m_tabOblRes[i].geti(tbVolt.Value)) + "mA");
            }
        }


      
        private void lbListeRes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox resToDel = (ListBox)sender;
            if(resToDel.SelectedIndex >= 0)
                m_tabOblRes[resToDel.SelectedIndex] = null;
            majAffichage();
        }


        private void textBoxR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)ConsoleKey.Backspace)
            {
                e.Handled = true;
            }
        }

        private void tbVolt_ValueChanged(object sender, EventArgs e)
        {
            lblVolt.Text = tbVolt.Value.ToString() + " Volts";
            majAffichage();

        }


        //Se produit au moment où l'usager relâche la souris du curseur du potentiometre
        private void tbVolt_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void majList()
        {
            for (int i = 0; i < m_tabOblRes.Length-1; i++)
            {
                if (m_tabOblRes[i] == null)
                    if (m_tabOblRes[i + 1] != null)
                    {
                        m_tabOblRes[i] = m_tabOblRes[i + 1];
                        m_tabOblRes[i + 1] = null;
                    }   

            }
        }

        private void btnMetAJour_Click(object sender, EventArgs e)
        {
            majAffichage();
        }
    }
}
