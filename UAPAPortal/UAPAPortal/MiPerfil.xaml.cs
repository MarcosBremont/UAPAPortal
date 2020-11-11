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
    public partial class MiPerfil : ContentPage
    {
        public MiPerfil()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnMaterias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Materias());
        }

        private async void BtnRecordatorio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MRecordatorio());
        }
    }
}