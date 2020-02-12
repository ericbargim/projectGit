//From Eric Barrero

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try {
                int dni = Convert.ToInt32(textBoxDNINums.Text);
                if (textBoxDNINums.Text.Length == 8)
                {
                    char letter = calculateLetterDNI(dni);
                    textBoxDNILetter.Text = letter.ToString();
                } else
                {
                    MessageBox.Show("You must enter 8 numbers!");
                }
            } catch (FormatException)
            {
                MessageBox.Show("Only enter numbers!");
                textBoxDNINums.Text = "";
            }
        }

        private char calculateLetterDNI(int dni)
        {
            return "TRWAGMYFPDXBNJZSQVHLCKE"[dni % 23];
        }
    }
}
