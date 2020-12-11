using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            f
        }
        private void labelTampilan_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            
            if (textBoxInput.Text == "DELETE")
            {
                textBoxInput.Text = "[EMPTY]";
            }
            else if (textBoxInput.Text == "BLUE")
            {
                labelTampilan.ForeColor = Color.Blue;
            }
            else if (textBoxInput.Text == "RED")
            {
                labelTampilan.ForeColor = Color.Red;
            }
            else if (textBoxInput.Text == "GREEN")
            {
                labelTampilan.ForeColor = Color.Green;
            }
            else if (textBoxInput.Text == "HIDE")
            {
                labelTampilan.Visible = false;
            }
            else if (textBoxInput.Text == "SHOWN")
            {
                labelTampilan.Visible = true;
            }
            else
            {
                labelTampilan.ForeColor = Color.Black;
                labelTampilan.Text = textBoxInput.Text;
            }
            textBoxInput.Clear();
        }

        private void buttonProcess_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
