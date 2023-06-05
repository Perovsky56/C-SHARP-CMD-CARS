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
    public partial class FormOkno1 : Form
    {
        public FormOkno1()
        {
            InitializeComponent();

        }

        private void FormOkno1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPodsumuj_Click(object sender, EventArgs e)
        {
            int sprOdp = 0;
            int stanSamopoczucia = 0;

            if (radioButtonOdp1a.Checked == true || radioButtonOdp1b.Checked == true || radioButtonOdp1c.Checked == true || radioButtonOdp1d.Checked == true)
            {
                sprOdp++;
            }
            if (radioButtonOdp2a.Checked == true || radioButtonOdp2b.Checked == true || radioButtonOdp2c.Checked == true || radioButtonOdp2d.Checked == true)
            {
                sprOdp++;
            }
            if (radioButtonOdp3a.Checked == true || radioButtonOdp3b.Checked == true || radioButtonOdp3c.Checked == true || radioButtonOdp3d.Checked == true)
            {
                sprOdp++;
            }
            if (radioButtonOdp4a.Checked == true || radioButtonOdp4b.Checked == true || radioButtonOdp4c.Checked == true || radioButtonOdp4d.Checked == true)
            {
                sprOdp++;
            }

            if (sprOdp != 4)
            {
                MessageBox.Show("Musisz odpowiedzieć na wszystkie pytania, aby sprawdzić odpowiedzi.", "BŁĄD");
            } else
            {
                /*1*/
                if (radioButtonOdp1a.Checked == true)
                {
                    stanSamopoczucia += 2;
                } else if (radioButtonOdp1b.Checked == true)
                {
                    stanSamopoczucia += 1;
                }
                else if (radioButtonOdp1c.Checked == true)
                {
                    stanSamopoczucia -= 1;
                }
                else if (radioButtonOdp1d.Checked == true)
                {
                    stanSamopoczucia -= 2;
                }
                /*2*/
                if (radioButtonOdp2a.Checked == true)
                {
                    stanSamopoczucia += 2;
                }
                else if (radioButtonOdp2b.Checked == true)
                {
                    stanSamopoczucia += 1;
                }
                else if (radioButtonOdp2c.Checked == true)
                {
                    stanSamopoczucia -= 1;
                }
                else if (radioButtonOdp2d.Checked == true)
                {
                    stanSamopoczucia -= 2;
                }
                /*3*/
                if (radioButtonOdp3a.Checked == true)
                {
                    stanSamopoczucia += 2;
                }
                else if (radioButtonOdp3b.Checked == true)
                {
                    stanSamopoczucia += 1;
                }
                else if (radioButtonOdp3c.Checked == true)
                {
                    stanSamopoczucia -= 1;
                }
                else if (radioButtonOdp3d.Checked == true)
                {
                    stanSamopoczucia -= 2;
                }
                /*4*/
                if (radioButtonOdp4a.Checked == true)
                {
                    stanSamopoczucia += 2;
                }
                else if (radioButtonOdp4b.Checked == true)
                {
                    stanSamopoczucia += 1;
                }
                else if (radioButtonOdp4c.Checked == true)
                {
                    stanSamopoczucia -= 1;
                }
                else if (radioButtonOdp4d.Checked == true)
                {
                    stanSamopoczucia -= 2;
                }

                FormOkno2 okno2 = new FormOkno2(stanSamopoczucia);
                okno2.ShowDialog();
            }
        }
    }
}
