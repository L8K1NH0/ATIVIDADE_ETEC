using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHRENHEIT
{
    public partial class FrmTemperatura : Form
    {
        string tipo;
        public FrmTemperatura()
        {
            InitializeComponent();
        }

        private void ChkGrausC_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGrausC.Checked)
            {
                ChkGrausC.Enabled = true;
                tipo = "C";

                ChkGrausK.Enabled = false;
                ChkGrausF.Enabled = false;
            }
            else
            {
                ChkGrausK.Enabled = true;
                ChkGrausC.Enabled = true;
                ChkGrausF.Enabled = true;
                tipo = "";
            }
        }

        private void ChkGrausF_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGrausF.Checked)
            {
                ChkGrausF.Enabled = true;
                tipo = "F";

                ChkGrausC.Enabled = false;
                ChkGrausK.Enabled = false;
            }
            else
            {
                ChkGrausK.Enabled = true;
                ChkGrausC.Enabled = true;
                ChkGrausF.Enabled = true;
                tipo = "";
            }
        }

        private void ChkGrausK_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGrausK.Checked)
            {
                ChkGrausK.Enabled = true;
                tipo = "K";

                ChkGrausC.Enabled = false; 
                ChkGrausF.Enabled = false;

            }
            else
            {
                ChkGrausK.Enabled = true;
                ChkGrausC.Enabled = true;
                ChkGrausF.Enabled = true;
                tipo = "";

            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtGraus.Text != "")
            {
                if (tipo == "K")
                {
                    LblResultadoK.Text = TxtGraus.Text;

                    LblResultadoF.Text = ((double.Parse(TxtGraus.Text) - 273.15) * 9 / 5 + 32).ToString("N2");

                    LblResultadoC.Text = (double.Parse(TxtGraus.Text) - 273.15).ToString("N2");
                }
                else if (tipo == "C")
                {
                    LblResultadoC.Text = TxtGraus.Text;

                    LblResultadoF.Text = ((double.Parse(TxtGraus.Text) * 9 / 5) + 32).ToString("N2");

                    LblResultadoK.Text = (double.Parse(TxtGraus.Text) + 274.15).ToString("N2");
                }
                else if (tipo == "F")
                {
                    LblResultadoF.Text = TxtGraus.Text;

                    LblResultadoK.Text = ((double.Parse(TxtGraus.Text) - 32) * 5 / 9 + 273.15).ToString("N2");

                    LblResultadoC.Text = ((double.Parse(TxtGraus.Text) - 32) * 5 / 9).ToString("N2");
                }
                else
                {
                    MessageBox.Show("Selecione uma escala");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtGraus.Text = "";
            TxtGraus.Focus();
            tipo = "";
            LblResultadoC.Text = "---";
            LblResultadoF.Text = "---";
            LblResultadoK.Text = "---";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
