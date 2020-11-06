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
    public partial class Nosotros : ContentPage
    {
        public Nosotros()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnMensaje_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NMensajeDelRector());
        }

        private void BtnMision_Clicked(object sender, EventArgs e)
        {

        }
    }
}