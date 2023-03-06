using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APP_CALC
{
    public partial class MainPage : ContentPage
    {
        double Resultado, Num1, Num2;

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN1.Focus();
            TxtN2.Text = "";
            //TxtResultado.Text = "";
            LblResultado.Text = "";
        }

        private void BtnSubtrair_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(TxtN1.Text);
            Num2 = double.Parse(TxtN2.Text);
            Resultado = Num1 - Num2;
            //TxtResultado.Text = Resultado.ToString();
            LblResultado.Text = Resultado.ToString();
        }

        private void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(TxtN1.Text);
            Num2 = double.Parse(TxtN2.Text);
            Resultado = Num1 * Num2;
            //TxtResultado.Text = Resultado.ToString();
            LblResultado.Text = Resultado.ToString();
        }

        private void BtnDivir_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(TxtN1.Text);
            Num2 = double.Parse(TxtN2.Text);
            Resultado = Num1 / Num2;
            //TxtResultado.Text = Resultado.ToString();
            LblResultado.Text = Resultado.ToString();
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(TxtN1.Text);
            Num2 = double.Parse(TxtN2.Text);
            Resultado = Num1 + Num2;
            //TxtResultado.Text = Resultado.ToString();
            LblResultado.Text = Resultado.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
