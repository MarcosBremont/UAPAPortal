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
    }
}