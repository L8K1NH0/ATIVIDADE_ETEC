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
    public partial class FrmCalculadora : Form
    {
        Double N1, N2, Resultado;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "")
            {
                N1 = double.Parse(TxtN1.Text);
                N2 = double.Parse(TxtN2.Text);
                Resultado = N1 - N2;
                TxtResultado.Text = Resultado.ToString();
            }
            
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "")
            {
                N1 = double.Parse(TxtN1.Text);
                N2 = double.Parse(TxtN2.Text);
                Resultado = N1 * N2;
                TxtResultado.Text = Resultado.ToString();
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "")
            {
                N1 = double.Parse(TxtN1.Text);
                N2 = double.Parse(TxtN2.Text);
                Resultado = N1 / N2;
                TxtResultado.Text = Resultado.ToString();
            }
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "")
            {
                N1 = double.Parse(TxtN1.Text);
                N2 = double.Parse(TxtN2.Text);
                Resultado = N1 + N2;
                TxtResultado.Text = Resultado.ToString();
            }
            
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
            TxtN1.Clear();
            TxtN2.Clear();
            TxtN1.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
