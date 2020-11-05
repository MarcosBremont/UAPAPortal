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
    public partial class PYCcatedraconvivencia : ContentPage
    {
        public PYCcatedraconvivencia()
        {
            InitializeComponent();
            var list = new List<string>
            {
                "Hey",
                "Did you check the",
                "The CarouselView",
                "In Xamarin.Forms?"
            };
            TheCarousel.ItemsSource = list;
        }
    }
}