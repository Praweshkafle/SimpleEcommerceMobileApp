using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
            //Map map = new Map(MapSpan.FromCenterAndRadius(
            //    new Position(36.8961, 10.1865),
            //    Distance.FromMiles(0.5)))
            //{
            //    IsShowingUser = true,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};
            //var p1 = new Position(36.8961, 10.1865);
            //var pin1 = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = p1,
            //    Label = "Surpass",
            //    Address = "BirtaMode"
            //};
            //map.Pins.Add(pin1);
        }
    }
}