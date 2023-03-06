using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta
{
    public partial class Form1 : Form
    {
        int Resultado, A, B, C;

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            A = int.Parse(TxtA.Text);
            B = int.Parse(TxtB.Text);
            C = int.Parse(TxtC.Text);

            Resultado = B * B - 4 * A * C;
            TxtResultado.Text = Resultado.ToString();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtA.Clear();
            TxtA.Focus();
            TxtB.Clear();
            TxtC.Clear();
            TxtResultado.Clear();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
