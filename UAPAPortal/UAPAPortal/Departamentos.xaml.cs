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
    public partial class Departamentos : ContentPage
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnEscuelas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Escuelas());
        }

        private async void BtnDepartamentos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListadeDepartamentos());
        }

        private async void btnProgramasYCentros_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProgramasYCentros());
        }
    }
}