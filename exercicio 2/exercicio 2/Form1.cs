using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2

{

    public partial class Form1 : Form
    {
        int J_voto = 0, C_voto = 0, M_voto = 0, F_voto = 0, nb_voto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nb_voto += 1;

            bnresult.Text = Convert.ToString(nb_voto);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void Cresult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "45")
            {

                pictureBox2.Image = Properties.Resources.joaodoria;

            }

            else if (textBox1.Text == "13")
            {
                pictureBox2.Image = Properties.Resources.haddad_entrevista_epoca;

            }

            else if (textBox1.Text == "10")
            {
                pictureBox2.Image = Properties.Resources.photo;

            }
            else if (textBox1.Text == "15")
            {
                pictureBox2.Image = Properties.Resources.marta_suplicy_FELIPE_RAU_ESTADaO;

            }

            //if (textBox1.Text != "45" || textBox1.Text != "10" || textBox1.Text != "13" || textBox1.Text != "15" )
            //{
               
                

          // }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.images;
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "45")
            {
                J_voto += 1;

                Jresult.Text = Convert.ToString(J_voto);

            }

            else if (textBox1.Text == "10")

            {
                C_voto += 1;
                Cresult.Text = Convert.ToString(C_voto);

            }

            else if (textBox1.Text == "13")
            {
                F_voto += 1;
                Fresult.Text = Convert.ToString(F_voto);


            }

            else if (textBox1.Text == "15")
            {
                M_voto += 1;
                Mresult.Text = Convert.ToString(M_voto);

            }

            else if (textBox1.Text != "45" || textBox1.Text != "10" || textBox1.Text != "13" || textBox1.Text != "15")
                {

                nb_voto += 1;

                bnresult.Text = Convert.ToString(nb_voto);


                }


            textBox1.Clear();
            pictureBox2.Image = Properties.Resources.images;
        }
    }
}
