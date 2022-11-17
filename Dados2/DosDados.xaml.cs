using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dados2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DosDados : ContentPage
    {
        ClaseDado Dado;
        int contador = 0;
        public DosDados()
        {
            InitializeComponent();
            Dado = new ClaseDado();
        }

        private void BtTirar(object sender, EventArgs e)
        {
            int Aleatorio;
            int Aleatorio2;
            contador++;

            Incremento.Text = contador.ToString();
            Aleatorio = Dado.GeneraAleatorio(1);
            LabelAleatorioUno.Text = Aleatorio.ToString();
            Aleatorio2 = Dado.GeneraAleatorio(1);
            LabelAleatorioDos.Text = Aleatorio2.ToString();
            LabelSuma.Text = (Aleatorio + Aleatorio2).ToString();
        }
    }
    
}