/**
 * @file   frmPrincipale.cs
 * @author 
 * @date   
 * @brief  Petite démo sur l'utilisation de la classe Encrypte 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoClasseEncrypte
{    
    public partial class frmPrincipale : Form
    {
        private Encrypte m_objSecret01;   //un objet

        public frmPrincipale()
        {
            InitializeComponent();
            m_objSecret01 = new Encrypte(Int32.Parse(codeText.Text));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            m_objSecret01.setChaine(chaineText.Text);
            m_objSecret01.fixeEncryptage(Convert.ToInt32(codeText.Text));
            resultatLabel.Text = m_objSecret01.getChaine();
        }
    }
}
