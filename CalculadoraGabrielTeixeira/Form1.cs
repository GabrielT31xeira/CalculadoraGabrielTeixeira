using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGabrielTeixeira
{
    public partial class Form1 : Form
    {

        double ultimo_resultado, primeiro_valor, segundo_valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "1";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ultimo_resultado > 0) {
                primeiro_valor = ultimo_resultado;
                label1.Text = Convert.ToString(primeiro_valor) + "+";
            } else { label1.Text = Convert.ToString(primeiro_valor) + "+"; }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Dica de um amigo, isso aqui deve ser o ultimo_resultado caso tenha um. tente somar um valor depois multiplicar o mesmo q perceberá o erro 
            //Eu sei cara kkkk tava tarde e deixei esse negocio quieto mas vlw
            label1.Text = Convert.ToString(primeiro_valor) + "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(primeiro_valor) + "/";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = null;
            ultimo_resultado = 0;
            primeiro_valor = 0; 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(primeiro_valor) + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "2";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else {
                label1.Text = label1.Text + "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "3";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "4";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "5";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "6";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "7";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "8";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] valor = null;
            char[] valores_separacao = { '+', '-', 'x', '/' };
            string soma = "+";
            string subtracao = "-";
            string multiplicacao = "x";
            string divisao = "/";
            bool contem_soma = label1.Text.Contains(soma);
            bool contem_subtracao = label1.Text.Contains(subtracao);
            bool contem_multiplicacao = label1.Text.Contains(multiplicacao);
            bool contem_divisao = label1.Text.Contains(divisao);
            valor = label1.Text.Split(valores_separacao);
            if (contem_soma)
            {
                for (int i = 0; i <= valor.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        primeiro_valor = Convert.ToDouble(valor[i]);
                    }
                    else {
                        segundo_valor = Convert.ToDouble(valor[i]);
                    }
                    
                }
                ultimo_resultado = primeiro_valor + segundo_valor;
                label1.Text = Convert.ToString(ultimo_resultado);
            }
            if (contem_subtracao) {
                for (int i = 0; i <= valor.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        primeiro_valor = Convert.ToDouble(valor[i]);
                    }
                    else
                    {
                        segundo_valor = Convert.ToDouble(valor[i]);
                    }

                }
                ultimo_resultado = primeiro_valor - segundo_valor;
                label1.Text = Convert.ToString(ultimo_resultado);
            }
            if (contem_multiplicacao) {
                for (int i = 0; i <= valor.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        primeiro_valor = Convert.ToDouble(valor[i]);
                    }
                    else
                    {
                        segundo_valor = Convert.ToDouble(valor[i]);
                    }

                }
                ultimo_resultado = primeiro_valor * segundo_valor;
                label1.Text = Convert.ToString(ultimo_resultado);
            }
            if (contem_divisao) {
                for (int i = 0; i <= valor.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        primeiro_valor = Convert.ToDouble(valor[i]);
                    }
                    else
                    {
                        segundo_valor = Convert.ToDouble(valor[i]);
                    }

                }
                ultimo_resultado = primeiro_valor / segundo_valor;
                label1.Text = Convert.ToString(ultimo_resultado);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(primeiro_valor) + "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "9";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (primeiro_valor == 0)
            {
                label1.Text = label1.Text + "0";
                primeiro_valor = Convert.ToDouble(label1.Text);
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }
    }
}
