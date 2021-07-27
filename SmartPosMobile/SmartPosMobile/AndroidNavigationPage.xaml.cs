using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AndroidNavigationPage : Xamarin.Forms.NavigationPage
    {
        public AndroidNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}