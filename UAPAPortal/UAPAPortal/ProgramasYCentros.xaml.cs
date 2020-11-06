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
    public partial class ProgramasYCentros : ContentPage
    {
        public ProgramasYCentros()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnConvivencia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PYCcatedraconvivencia());
        }

        private async void BtnPasc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PYCPasc());
        }

        private async void BtnProfundo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PYCProfundo());
        }

        private async  void BtnPuse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PyCPUSE());
        }

        private async void BtnSait_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PyCSait());
        }

        private async void BtnCuice_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PyCCuice());

        }

        private async void BtnCude_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PyCCuce());
        }

        private async void BtnCingep_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PyCCINGEP());
        }
    }
}