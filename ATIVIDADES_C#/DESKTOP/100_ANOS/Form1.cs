using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_ANOS
{
    public partial class FrmIdade : Form
    {
        double Resultado;
        public FrmIdade()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Resultado = 100 - double.Parse(TxtIdade.Text);
            if (double.Parse(TxtIdade.Text) >= 100)
            {
                LblResultado.Text = "Pode ir pro \ncaixão kkkk";
            }
            else
            {
                LblResultado.Text = Resultado.ToString() + " anos";
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtIdade.Clear();
            LblResultado.Text = "";
            TxtIdade.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
