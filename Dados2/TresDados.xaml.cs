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
    public partial class TresDados : ContentPage
    {
        ClaseDado Dado;
        int contador = 0;
        public TresDados()
        {
            InitializeComponent();
            Dado = new ClaseDado();
        }

        private void BtTirar(object sender, EventArgs e)
        {
            int Aleatorio;
            int Aleatorio2;
            int Aleatorio3;
            contador++;

            Incremento.Text = contador.ToString();
            Aleatorio = Dado.GeneraAleatorio(1);
            LabelAleatorioUno.Text = Aleatorio.ToString();
            Aleatorio2 = Dado.GeneraAleatorio(1);
            LabelAleatorioDos.Text = Aleatorio2.ToString();
            Aleatorio3 = Dado.GeneraAleatorio(1);
            LabelAleatorioTres.Text = Aleatorio3.ToString();
            LabelSuma.Text = (Aleatorio + Aleatorio2 + Aleatorio3).ToString();
        }
    }
}