using SmartPosMobile.ViewModels;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPosMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class practise : ContentPage
    {

        Stopwatch stopwatch = new Stopwatch();
        Timer timer = new Timer();
        QuizViewModel model;
        public practise()
        {
            InitializeComponent();
            model = new QuizViewModel();


          
            Task.Run(() =>
            {
                pancakes();
                Device.StartTimer(TimeSpan.FromSeconds(15), (Func<bool>)(() =>
                {
                    model.Swipe = true;
                    carouelAuto.Position = (carouelAuto.Position + 1) % model.Quizzes.Count;
                    if (carouelAuto.Position == 0)
                    {
                        // DisplayAlert("", "End reached", "ok");
                        // NavigationHelper.PushAsync(new Home());
                    }
                    model.Swipe = false;
                    return true;
                }));

                stopwatch.Start();
                time.Text = stopwatch.Elapsed.Seconds.ToString();
                Device.StartTimer(new TimeSpan(1), (Func<bool>)(() =>
                {
                    time.Text = stopwatch.Elapsed.Seconds.ToString();
                    return true;
                }));
            });
        }
        private async void pancakes()
        {
            //await pancake.ColorTo(Color.FromHex("#8845b8"),0,Easing.Linear);
            //await pancake.ColorTo(Color.FromHex("#f52e33"), Color.FromHex("#ff9e4f"), c => pancake.BackgroundGradientEndColor = c, 5000, Easing.Linear);
            //await pancake.ColorTo(Color.FromHex("#c23569"), Color.FromHex("#8845b8"), c => pancake.BackgroundGradientStartColor = c, 5000, Easing.Linear);
            //await pancake.ColorTo(Color.FromHex("#ff9e4f"), Color.FromHex("#f52e33"), c => pancake.BackgroundGradientEndColor = c, 5000, Easing.Linear);

        }
    }
}