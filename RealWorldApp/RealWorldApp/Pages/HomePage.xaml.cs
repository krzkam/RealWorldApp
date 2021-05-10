﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealWorldApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void TapCloseMenu_Tapped(object sender, EventArgs e)
        {
            await SlMenu.TranslateTo(-250, 0, 400, Easing.Linear);
            GridOverlay.IsVisible = false;
            
        }

        private void TapLogout_Tapped(object sender, EventArgs e)
        {

        }

        private void TapContact_Tapped(object sender, EventArgs e)
        {

        }

        private void TapCart_Tapped(object sender, EventArgs e)
        {

        }

        private void TapOrders_Tapped(object sender, EventArgs e)
        {

        }

        private void TapCartIcon_Tapped(object sender, EventArgs e)
        {

        }

        private async void ImgMenu_Tapped(object sender, EventArgs e)
        {
            GridOverlay.IsVisible = true;
            await SlMenu.TranslateTo(0,0,400,Easing.Linear);
        }

        private void CvProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}