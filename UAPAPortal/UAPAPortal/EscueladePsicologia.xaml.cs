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
    public partial class EscueladePsicologia : ContentPage
    {
        public EscueladePsicologia()
        {
            InitializeComponent();
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
    }
}