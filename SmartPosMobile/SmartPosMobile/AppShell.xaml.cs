using SmartPosMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartPosMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Register();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void Register()
        {
            Routing.RegisterRoute("itemsDetails", typeof(ItemsDetails));
        }
    }
}
