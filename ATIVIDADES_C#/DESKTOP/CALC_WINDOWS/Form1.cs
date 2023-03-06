using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class FrmCalculadora : Form
    {
        double visor;
        string operacao;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 0;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 8;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtVisor.Text = TxtVisor.Text + 9;
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            {
                visor = double.Parse(TxtVisor.Text);
                TxtVisor.Clear();
                //TxtVisor.Focus();
                operacao = "somar";
            }
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            {
                visor = double.Parse(TxtVisor.Text);
                TxtVisor.Clear();
                //TxtVisor.Focus();
                operacao = "subtracao";
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            {
                visor = double.Parse(TxtVisor.Text);
                TxtVisor.Clear();
                //TxtVisor.Focus();
                operacao = "multiplicar";
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            {
                visor = double.Parse(TxtVisor.Text);
                TxtVisor.Clear();
                //TxtVisor.Focus();
                operacao = "dividir";
            }
        }
        private void BtnPorcentagem_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            {
                visor = double.Parse(TxtVisor.Text);
                TxtVisor.Clear();
                //TxtVisor.Focus();
                operacao = "porcentagem";
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "somar")
            {
                TxtVisor.Text = (double.Parse(TxtVisor.Text) + visor).ToString();
            }
            else if (operacao == "subtracao")
            {
                TxtVisor.Text = (visor - double.Parse(TxtVisor.Text)).ToString();
            }
            else if (operacao == "multiplicar")
            {
                TxtVisor.Text = (double.Parse(TxtVisor.Text) * visor).ToString();
            }
            else if (operacao == "dividir")
            {
                TxtVisor.Text = (visor / double.Parse(TxtVisor.Text)).ToString();
            }
            else if (operacao == "porcentagem")
            {
                double porcentagem;
                porcentagem = double.Parse(TxtVisor.Text) / 100 + 1 ;
                TxtVisor.Text = (visor * porcentagem).ToString();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtVisor.Clear();
            TxtVisor.Clear();
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            TxtVisor.Text += ",";
        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {
            if (TxtVisor.Text != "")
            //{
            //    int quantidade = TxtVisor.Text.Length;
            //    TxtVisor.Text = TxtVisor.Text.Substring(0, quantidade - 1);
            //}
        }

        
    }
}
