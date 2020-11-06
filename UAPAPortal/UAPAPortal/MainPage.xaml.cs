using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UAPAPortal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnMiUapa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MIUAPA());
        }

        private async void BtnAdminisiones_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Admisiones());
        }

        private async void BtnOfertaAcademica_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new OfertaAcademica());
        }

        private async void BtnDepartamentos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Departamentos());
        }

        private async void BtnNosotros_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Nosotros());
        }

        private async void BtnMiPerfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MiPerfil());
        }
    }
}
