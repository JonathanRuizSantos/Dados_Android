using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dados2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtUnDado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnDado());
        }

        private async void BtDosDados(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DosDados());
        }

        private async void TresLados(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TresDados());
        }
    }
}
