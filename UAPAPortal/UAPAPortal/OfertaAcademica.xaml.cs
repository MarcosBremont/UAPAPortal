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
    public partial class OfertaAcademica : ContentPage
    {
        public OfertaAcademica()
        {
            InitializeComponent();
        }

        private async void BtnPregado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pregado());
        }

        private async void BtnGrado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Grado());
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnPostgrado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Postgrado());
        }

        private async void BtnEducacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EducacionContinuada());

        }
    }
}