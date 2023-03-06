using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class FrmMedia : Form
    {
        double N1, N2, N3, N4, Resultado;

        public FrmMedia()
        {
            InitializeComponent();
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text != "" && TxtN2.Text != "" && TxtN3.Text != "" && TxtN4.Text != "")
            {
                N1 = double.Parse(TxtN1.Text);
                N2 = double.Parse(TxtN2.Text);
                N3 = double.Parse(TxtN3.Text);
                N4 = double.Parse(TxtN4.Text);
                Resultado = (N1 + N2 + N3 + N4) / 4;
                TxtResultado.Text = Resultado.ToString();
            }
            if (Resultado >= 9)
            {
                PctrImagem.Visible = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN1.Focus();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtN4.Clear();
            TxtResultado.Clear();
            PctrImagem.Visible = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
