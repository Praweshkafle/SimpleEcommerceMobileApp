using Rg.Plugins.Popup.Extensions;
using SmartPosMobile.Models;
using SmartPosMobile.ViewModels.Checkout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile.Views.CheckOut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartCheckout : ContentPage
    {
        public CartCheckout()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new PopupPage());
        }
    }
}