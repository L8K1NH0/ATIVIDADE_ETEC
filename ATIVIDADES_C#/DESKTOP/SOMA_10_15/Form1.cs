using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOMA_10_15
{
    public partial class Form1 : Form
    {
        double numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            numero = double.Parse(TxtNumero.Text);
            if(numero >= 10)
            {
                LblResultado.Text = (numero + 10).ToString();
            }
            else
            {
                LblResultado.Text = (numero + 15).ToString();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumero.Clear();
            TxtNumero.Focus();
            LblResultado.Text = "-------------";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
