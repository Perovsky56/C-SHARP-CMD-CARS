using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad4KZat
{
    public partial class FormOkno2 : Form
    {
        int stanSamopoczucia;
        public FormOkno2(int a)
        {
            this.stanSamopoczucia = a;
            InitializeComponent();

        }

        public void FormOkno2_Load(object sender, EventArgs e)
        {
            if (stanSamopoczucia > 5)
            {
                pictureBoxWynik.Image = Zad4KZat.Properties.Resources.vhappy;
                labelWynikTxt.Text = "JESTEŚ SZCZĘŚLIWY!";
            }
            else if (stanSamopoczucia <= 5 && stanSamopoczucia > 0)
            {
                pictureBoxWynik.Image = Zad4KZat.Properties.Resources.happy;
                labelWynikTxt.Text = "JESTEŚ RADOSNY!";
            }
            else if (stanSamopoczucia == 0)
            {
                pictureBoxWynik.Image = Zad4KZat.Properties.Resources.neutral;
                labelWynikTxt.Text = "JESTEŚ NEUTRALNY!";
            }
            else if (stanSamopoczucia < 0 && stanSamopoczucia >= -5)
            {
                pictureBoxWynik.Image = Zad4KZat.Properties.Resources.sad;
                labelWynikTxt.Text = "JESTEŚ SMUTNY!";
            }
            else if (stanSamopoczucia < -5)
            {
                pictureBoxWynik.Image = Zad4KZat.Properties.Resources.vsad;
                labelWynikTxt.ForeColor = Color.Red;
                labelWynikTxt.Text = "JESTEŚ BARDZO SMUTNY!\n(lepiej zasięgnij opieki specjalisty)";
            }
        }

        private void pictureBoxWynik_Click(object sender, EventArgs e)
        {
        }
    }
}
