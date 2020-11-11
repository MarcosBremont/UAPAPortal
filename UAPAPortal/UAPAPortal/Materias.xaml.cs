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
    public partial class Materias : ContentPage
    {
        public IList<MateriasM> materias { get; private set; }
        public Materias()
        {
            InitializeComponent();
            materias = new List<MateriasM>();

            materias.Add(new MateriasM
            {
                NombreM = "Lengua Español"
            });
            materias.Add(new MateriasM
            {
                NombreM = "Matematicas"
            });

            BindingContext = this;
        
        }

      

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}