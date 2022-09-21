using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine4_Exer1
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        Button btn1 = new Button();
        const int NB_TBOX = 5;
        const int NB_LETTRE = 5;

        public Form1()
        {
            TextBox[] textBoxes = new TextBox[NB_TBOX];
            Button[] buttons = new Button[NB_LETTRE];

            for (int i = 0; i < NB_TBOX; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Location = new Point(i * 50, 250);
                Controls.Add(buttons[i]);
                textBoxes[i].Text = i.ToString();
            }

            label1.Text = "TEST";
            label1.Location = new Point(10,10);
            Controls.Add(label1);

            btn1.Text = "HELLOOOOOOO";
            btn1.Location = new Point(10, 40);
            btn1.Size = new Size(200, 50);
            Controls.Add(btn1);

            btn1.Click += new EventHandler(this.btn1_Click);

            InitializeComponent();

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "test !!";
        }
    }
}
