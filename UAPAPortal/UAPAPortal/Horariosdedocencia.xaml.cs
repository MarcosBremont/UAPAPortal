﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UAPAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horariosdedocencia : ContentPage
    {
        public Horariosdedocencia()
        {
            InitializeComponent();
          

        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            Opacity = 0.5;

            await Navigation.PopModalAsync();
            Opacity = 1;
        }
    }
}