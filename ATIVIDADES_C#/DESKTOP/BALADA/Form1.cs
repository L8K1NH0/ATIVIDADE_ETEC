using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BALADA
{
    public partial class FrmBalada : Form
    {
        public FrmBalada()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if((double.Parse(TxtIdade.Text) >= 18 )) 
            {
                LblResultado.Text = "Entrada Permitida.\n\nPermitido venda de bibidas.";
            }
            else
            {
                LblResultado.Text = "ENTRADA ROIBIDA!!";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtIdade.Clear();
            TxtIdade.Focus();
            LblResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
