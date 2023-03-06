using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIA_BIMESTRE
{
    public partial class Form1 : Form
    {
        double Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "" && TxtNota1.Text !="" && TxtNota2.Text != "" && TxtNota3.Text != "" && TxtNota4.Text != "")
            {
                Resultado = (double.Parse(TxtNota1.Text) + double.Parse(TxtNota2.Text) + double.Parse(TxtNota3.Text) + double.Parse(TxtNota4.Text)) / 4;
                LblResultado.Text = LblNome.Text + ", sua média foi: " + Resultado.ToString("N2");
                if (Resultado >= 5)
                {
                    LblMenssagem.Text = "Parabens pela nota!!";
                }
                else
                {
                    LblMenssagem.Text = "Precisa estudar mais.\nFICOU RETIDO :(";
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtNome.Focus();
            TxtNota1.Clear();
            TxtNota2.Clear();
            TxtNota3.Clear();
            TxtNota4.Clear();
            LblResultado.Text = "--------------------------------------";
            LblMenssagem.Text = "--------------------------------------";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
