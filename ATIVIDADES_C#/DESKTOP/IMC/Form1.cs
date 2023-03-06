using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class FrmIMC : Form
    {
        double Resultado;
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            Resultado = (double.Parse(TxtPeso.Text) / ((double.Parse(TxtAltura.Text)) * (double.Parse(TxtAltura.Text))));
            if(Resultado <= 25)
            {
                LblResultado.Text = "Peso Normal.";
                LblIndice.Text = Resultado.ToString("N2");
            }
            else 
            {
                LblResultado.Text = "SOBRE PESO!";
                LblIndice.Text = Resultado.ToString("N2");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblResultado.Text = "";
            TxtAltura.Clear();
            TxtPeso.Focus();
            TxtPeso.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {

        }
    }
}
