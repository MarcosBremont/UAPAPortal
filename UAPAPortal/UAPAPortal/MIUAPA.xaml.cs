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
    public partial class MIUAPA : ContentPage
    {
        public MIUAPA()
        {
            InitializeComponent();
        }

        private async void BtnCampusVirtual_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CampusVirtual());
        }

        private async void BtnServiciosEnLinea_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ServiciosEnLinea());
        }

        private async void BtnBibliotecaVirtual_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BibliotecaVirtual());
        }

        private async void BtnCalendarioAcademico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CalendarioAcademico());

        }

        private async void BtnDirectorioTelefononico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DirectorioTelefonico());
        }

        private async void BtnCorreoElectronico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CorreoElectronico());
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;
            await Navigation.PopModalAsync();
            Opacity = 1;

        }
    }
}