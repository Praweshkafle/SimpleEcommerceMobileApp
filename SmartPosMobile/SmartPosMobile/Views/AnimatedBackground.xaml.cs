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
    public partial class AnimatedBackground : ContentPage
    {
        public AnimatedBackground()
        {
            InitializeComponent();
            Task.Run(AnimationColor);
        }

        private async Task AnimationColor()
        {
            Action<double> forward = a => boxBackground.AnchorX = a;
            Action<double> backward = a => boxBackground.AnchorY = a;
            while (true)
            {
                boxBackground.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                boxBackground.Animate(name: "Backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
    }
}