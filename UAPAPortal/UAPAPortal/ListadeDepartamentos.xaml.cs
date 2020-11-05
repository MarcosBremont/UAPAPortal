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
    public partial class ListadeDepartamentos : ContentPage
    {
        public ListadeDepartamentos()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DRegistro());
        }

        private async void BtnCiclo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DCicloBasico());

        }

        private async void BtnInvestigacionYDivulga_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DInvestigacionyDivulgacion());

        }

        private async void BtnExtensionU_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DExtensionUni());
        }

        private async void BtnSociedadE_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DSociedadEcologica());
        }

        private async void BtnPublicaciones_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DPublicaciones());
        }

        private async void BtnVoluntariado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DVoluntariado());
        }

        private async void BtnInnovacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DVicerrectoriadeInnovacionyDesarrollo());
        }
    }
}