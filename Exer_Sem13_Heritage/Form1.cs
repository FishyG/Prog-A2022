using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer_Sem13_Heritage
{
    public partial class Form1 : Form
    {
        List<Etudiant> m_etudiantList = new List<Etudiant>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_etu_Click(object sender, EventArgs e)
        {
            if (tb_number.Text != null)
            {
                m_etudiantList.Add(new Etudiant(tb_name.Text, Convert.ToInt32(tb_number.Text)));
                listBox1.Items.Clear();
                foreach (Etudiant etudiant in m_etudiantList)
                {
                    listBox1.Items.Add(etudiant);
                }
            }
        }
    }
}