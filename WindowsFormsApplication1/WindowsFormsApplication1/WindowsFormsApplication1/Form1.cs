using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double acumula = 0;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";
            
                        
         }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void button13_Click(object sender, EventArgs e)
        {
           

            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";

            }

            else
            {


                acumula += double.Parse(textBox1.Text);
                textBox1.Text = "";
                operacao = "+";


             }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {

                acumula += double.Parse(textBox1.Text);
                textBox1.Text = acumula.ToString();

            }

            else if (operacao == "-")
            {

                acumula -= double.Parse(textBox1.Text);
                textBox1.Text = acumula.ToString();

            }

            else if (operacao == "*")
            {

                acumula *= double.Parse(textBox1.Text);
                textBox1.Text = acumula.ToString();

            }

            else if (operacao == "/")
            {

                if (double.Parse(textBox1.Text) != 0)
                {
                    acumula /= double.Parse(textBox1.Text);
                    textBox1.Text = acumula.ToString();
                }

                else
                {
                    MessageBox.Show ( "Número não pode ser dividido por zero");
                    textBox1.Clear();
                }
            }



        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";

            }

            else
            {
                acumula += double.Parse(textBox1.Text);
                textBox1.Text = "";
                operacao = "-";


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operacao == "+" || operacao == "-" || operacao == "/")
            {
                operacao = "*";

            }

            else
            {
                acumula += double.Parse(textBox1.Text);
                textBox1.Text = "";
                operacao = "*";


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "+")
            {
                operacao = "/";

            }

            else
            {
                acumula += double.Parse(textBox1.Text);
                textBox1.Text = "";
                operacao = "/";


            }
        }
    }
}
