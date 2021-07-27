using SmartPosMobile.Helper;
using SmartPosMobile.Models;
using SmartPosMobile.ViewModels;
using SmartPosMobile.ViewModels.HomeViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            BindingContext =new ItemsViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ItemsViewModel model = new ItemsViewModel();
            model.ItemCount = SqlDb.GetAll().Count;
        }
        private void scrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (e.ScrollY> -100)
            {
                collection.IsVisible = true;
                Categoriestitle.IsVisible = true;
            }
            else
            {
                collection.IsVisible = false;
                Categoriestitle.IsVisible = false;
            }
        }

       
    }
}