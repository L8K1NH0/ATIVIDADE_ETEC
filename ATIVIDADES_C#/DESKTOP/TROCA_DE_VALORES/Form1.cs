using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TROCA_DE_VALORES
{
    public partial class FrmTrocaDeValores : Form
    {
        string auxiliar;
        public FrmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auxiliar = TxtNumeroB.Text;
            TxtNumeroB.Text = TxtNumeroA.Text;
            TxtNumeroA.Text = auxiliar;

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumeroA.Text = "";
            TxtNumeroB.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
