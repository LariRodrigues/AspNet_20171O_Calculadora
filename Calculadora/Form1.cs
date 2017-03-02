using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string op = "";
        double acumula = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }       

        //Zero
        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        //Um
        private void btnUm_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        //Dois
        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        //Tres
        private void btnTres_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        //Quatro
        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        //Cinco
        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        //Seis
        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        //Sete
        private void btnSete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        //Oito
        private void btnOito_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        //Nove
        private void btnNove_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        //Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(op == "+")
            {
                acumula += double.Parse(txtDisplay.Text);
                txtDisplay.Text = acumula.ToString();
            }
            else if(op == "-")
            {
                acumula -= double.Parse(txtDisplay.Text);
                txtDisplay.Text = acumula.ToString();
            }
            else if(op == "*")
            {
                acumula *= double.Parse(txtDisplay.Text);
                txtDisplay.Text = acumula.ToString();
            }
            else if(op == "x²")
            {
                acumula = double.Parse(txtDisplay.Text);
                txtDisplay.Text = acumula.ToString();
            } 
            else if(op == "/")
            {
                if(double.Parse(txtDisplay.Text) != 0)
                {
                    acumula /= double.Parse(txtDisplay.Text);
                    txtDisplay.Text = acumula.ToString();
                }
                else
                {
                    txtDisplay.Text = "Dividido por zero";
                }
            }
            
        }

        //Ponto
        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }

        //se as operações forem diferentes de - / * então a operação é + 
        //valor "acumulado" sera diminuido
        //Soma
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(op == "-" || op == "/" || op == "*")
            {
                op = "+";
            }
            else
            {
                acumula += double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                op = "+";
            }
        }

        //Subtração
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(op == "+" || op == "/" || op == "*")
            {
                op = "-";
            }
            else
            {
                acumula += double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                op = "-";
            }
        }

        //Multiplicação
        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if(op == "+" || op == "-" || op == "/")
            {
                op = "*";
            }
            else
            {
                acumula += double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                op = "*";
            }
        }

        //Divisor
        private void btnDivisor_Click(object sender, EventArgs e)
        {
            if(op == "+" || op == "-" || op == "*")
            {
                op = "/";
            }
            else
            {
                acumula += double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                op = "/";
            }
        }

        //numero x recebe a raiz quadrada do numero x
        // e o txtDisplay é igual ao x raiz
        //Raiz
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);
            if(x < 0)
            {
                txtDisplay.Text = "Este valor não é valido";
            }
            else
            {
                x = Math.Sqrt(x);
                txtDisplay.Text = x.ToString();
            }
        }

        //Potencia
        //Potencia não esta pegango 100%
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double y = double.Parse(txtDisplay.Text);
            double x = double.Parse(txtDisplay.Text);

            if (op == "+" || op == "-" || op == "/" || op == "*")
            {
                op = "x²";
            }
            else
            {
                acumula = Math.Pow(x, y);
              //  Math.Pow (x,y);
                txtDisplay.Text = "";
                op = "x²";
                
            }
        }

        //Limpa
        private void btnC_Click(object sender, EventArgs e)
        {
            acumula = 0;
            txtDisplay.Text = "";
        }

    }
}
