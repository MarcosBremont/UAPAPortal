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
    public partial class Admisiones : ContentPage
    {
        public Admisiones()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;

            await Navigation.PushModalAsync(new MainPage());
            Opacity = 1;
        }

        private async void BtnModalidades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync( new Modalidadesdeestudio());
        }

        private async void BtnSolicitaMasInf_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SolicitaMasInformacion());

        }

        private async void BtnCostosEInformacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CostosEInformacion());

        }

        private async void BtnHorariosDeDocencia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Horariosdedocencia());

        }

        private async void BtnRequisitos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Requisitosdeadmision());

        }
    }
}