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
    public partial class Admisiones : ContentPage
    {
        public Admisiones()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;
            await Navigation.PopModalAsync();
            Opacity = 1;
        }

        private async void BtnModalidades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync( new Modalidadesdeestudio());
        }
    }
}