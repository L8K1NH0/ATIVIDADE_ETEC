using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadrado_Cubo
{
    public partial class Form1 : Form
    {
        int Quadrado, Cubo, Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCubo_Click(object sender, EventArgs e)
        {
            Cubo = int.Parse(TxtNumero.Text);
            Resultado = Cubo * Cubo * Cubo;
            TxtResultado.Text = Resultado.ToString();
        }

        private void BtnQuadrado_Click(object sender, EventArgs e)
        {
            Quadrado = int.Parse(TxtNumero.Text);
            Resultado = Quadrado * Quadrado;
            TxtResultado.Text = Resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumero.Clear();
            TxtNumero.Focus();
            TxtResultado.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
