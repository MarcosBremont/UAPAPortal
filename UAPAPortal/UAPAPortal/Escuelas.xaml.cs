using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UAPAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Escuelas : ContentPage
    {
        public Escuelas()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnEscuelaDeCiencias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ESCUELADECIENCIAS());
        }

        private async void BtnEscuelaEducacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ESCUELAEDUCACION());

        }
    }
}