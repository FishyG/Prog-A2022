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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_RemoveSpace(object sender, EventArgs e)
        {
            resultTextBox.Text = inputTextBox.Text.Replace(" ","");
        }

        private void button_InvertChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)
            {
                resultTextBox.Text = c + resultTextBox.Text;
            }
        }

        private void button_DoubleChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)
            {
                resultTextBox.Text = resultTextBox.Text + c + c;
            }
        }

        private void button_SkipOneChar(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            int i = 0;
            foreach (char c in inputTextBox.Text)
            {
                i++;
                if (i % 2 == 1)
                    resultTextBox.Text = resultTextBox.Text + c;
            }
        }

        private void button5_MajMin(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            int i = 0;
            foreach (char c in inputTextBox.Text)
            {
                i++;
                if (i % 2 == 1)
                {
                    resultTextBox.Text = resultTextBox.Text + c.ToString().ToUpper();
                }
                else
                {
                    resultTextBox.Text = resultTextBox.Text + c.ToString().ToLower();
                }
            }
        }

        private void button_Password(object sender, EventArgs e)
        {

        }

        private void button_OnlyOneSpace(object sender, EventArgs e)
        {
            char oldC = '\0';

            resultTextBox.Text = "";    // Empty the string 

            foreach (char c in inputTextBox.Text.Trim())
            {
                if (oldC == ' ' && c == ' ')
                    resultTextBox.Text = resultTextBox.Text;    // Do nothing
                else
                    resultTextBox.Text = resultTextBox.Text + c.ToString();
                oldC = c;
            }
        }

        private void button_InvertWord(object sender, EventArgs e)
        {

        }

        private void button_CountWord(object sender, EventArgs e)
        {
            int i = 1;

            button7.PerformClick(); // Call to remove the " "

            if (resultTextBox.Text.Trim().Length == 0)
            {
                i = 0;
            }
            else
            {
                foreach (char c in resultTextBox.Text)
                {
                    if (c == ' ')
                    {
                        i++;
                    }
                }
            }

            resultTextBox.Text = inputTextBox.Text + Convert.ToString(i);
        }

        private void button_Rotate(object sender, EventArgs e)
        {

        }

        private void button_Ascii(object sender, EventArgs e)
        {
            resultTextBox.Text = "";    // Vide la string 

            foreach (char c in inputTextBox.Text)
            {
                resultTextBox.Text = resultTextBox.Text + Convert.ToString(Convert.ToUInt64(c)) + " ";
            }
        }
        
        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
