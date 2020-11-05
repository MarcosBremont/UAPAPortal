using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace UAPAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DVicerrectoriadeInnovacionyDesarrollo : ContentPage
    {
        public DVicerrectoriadeInnovacionyDesarrollo()
        {
            InitializeComponent();
            webview.Source = "https://www.youtube.com/embed/n3_4yHT-4wY";
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}