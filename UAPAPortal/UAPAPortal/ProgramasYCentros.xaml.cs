﻿using System;
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
    }
}