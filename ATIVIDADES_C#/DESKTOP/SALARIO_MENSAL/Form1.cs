using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VALOR_HORA
{
    public partial class FrmValorHora : Form
    {
        double Resultado;
        public FrmValorHora()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtFilhos.Text  != "" && TxtHorasSemanas.Text != "" && TxtIdade.Text != "" && TxtNome.Text != "" && TxtValorHora.Text !="")
            {
                Resultado = double.Parse(TxtValorHora.Text) * (double.Parse(TxtHorasSemanas.Text) * 4.5);

                if (double.Parse(TxtIdade.Text) >= 50)
                {
                    Resultado = Resultado * 1.25;
                }
                if (double.Parse(TxtFilhos.Text) >= 1)
                {
                    Resultado += 500;
                }
                LblResultado.Text = "O seu salario mensal \né de R$" + Resultado.ToString("N2");


            }
            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtFilhos.Clear();
            TxtIdade.Clear();
            TxtHorasSemanas.Clear();
            TxtValorHora.Clear();
            TxtNome.Focus();
            LblResultado.Text = "";
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtIdade.Focus();
            }
        }

        private void TxtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtFilhos.Focus();
            }
        }

        private void TxtFilhos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtHorasSemanas.Focus();
            }
        }

        private void TxtHorasSemanas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtValorHora.Focus();
            }
        }

        private void TxtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnCalcular.PerformClick();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
