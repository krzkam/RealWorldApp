﻿using RealWorldApp.Models;
using RealWorldApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealWorldApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public ObservableCollection<ShoppingCartItem> ShoppingCartCollection;
        public CartPage()
        {
            InitializeComponent();
            ShoppingCartCollection = new ObservableCollection<ShoppingCartItem>();
            GetShoppingCartItems();

        }

        private async void GetShoppingCartItems()
        {
            var shoppingCartItems = await ApiService.GetShoppingCartItems(Preferences.Get("userId",0));
            foreach (var shoppingCart in shoppingCartItems)
            {
                ShoppingCartCollection.Add(shoppingCart);
            }
            LvShoppingCart.ItemsSource = ShoppingCartCollection;
        }

        private void BtnProceed_Clicked(object sender, EventArgs e)
        {

        }

        private void TapClearCart_Tapped(object sender, EventArgs e)
        {

        }

        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}