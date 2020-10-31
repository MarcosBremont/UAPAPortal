using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UAPAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SolicitaMasInformacion : ContentPage
    {
        public SolicitaMasInformacion()
        {
            InitializeComponent();
            Browser.Source = "https://www.uapa.edu.do/estudia/solicita-informacion/";

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }



        private void Front_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;
            await Navigation.PushModalAsync(new Admisiones());
            Opacity = 1;
        }
    }
}