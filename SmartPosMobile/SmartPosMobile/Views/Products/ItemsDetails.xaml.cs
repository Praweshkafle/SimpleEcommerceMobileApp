using SmartPosMobile.Models;
using SmartPosMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsDetails : ContentPage
    {
        public ItemsDetails(Items item)
        {
            InitializeComponent();
            BindingContext =new DetailsViewModel(item);
        }
        long count = 0;
        protected override void OnAppearing()

        {
            base.OnAppearing();
            var shell = new Shell();
            shell.Title = itemName.Text.ToString();
            IncDecData.Text = count.ToString();
        }
        private void Increase_Clicked(object sender, EventArgs e)
        {
            count++;
            IncDecData.Text = count.ToString();
        }

        private void Decrease_Clicked(object sender, EventArgs e)
        {
            count--;
            if (count >= 0)
                IncDecData.Text = count.ToString();
        }
    }
}