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
    public partial class UnDado : ContentPage
    {
        ClaseDado Dado;
        int contador = 0;
        public UnDado()
        {
            InitializeComponent();
            Dado = new ClaseDado();
        }

        private void BtTirar(object sender, EventArgs e)
        {
            int Aleatorio;
            contador++;

            Incremento.Text = contador.ToString();
            Aleatorio = Dado.GeneraAleatorio(1);
            LabelAleatorioUno.Text = Aleatorio.ToString();
        }

        private void BtTirarCar(object sender, EventArgs e)
        {

        }
    }
}