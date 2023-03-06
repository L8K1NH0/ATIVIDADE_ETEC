using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antecessor_e_Sucessor
{
    public partial class Form1 : Form
    {
        double Suc, Ant, Resultado;

        private void BtnSucessor_Click(object sender, EventArgs e)
        {
            Suc = double.Parse(TxtNum.Text);
            Resultado = Suc + 1;
            TxtResultado.Text = Resultado.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAntecessor_Click(object sender, EventArgs e)
        {
            Ant = double.Parse(TxtNum.Text);
            Resultado = Ant - 1;
            TxtResultado.Text = Resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNum.Clear();
            TxtNum.Focus();
            TxtResultado.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
