using CampusSC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CampusSC
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DiningOptionsPage : ContentPage
    {
        private Task<bool> result;
        private Task<bool> openExternalAppService;

        public bool SoundEffectsEnabled { get; private set; }

        public DiningOptionsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
            Task.Run(AnimatedBG);

            // Accomondate iPhone state bar.

            this.Padding = new Thickness(10, Device.RuntimePlatform == Device.iOS ? 20 : 5, 10, 5);
        }

        private void DiningServicesWeb_Clicked(object sender, EventArgs e)
        {
            SoundEffectsEnabled = true;
            Navigation.PushAsync(new DiningServiesWeb());
        }

        private void Menus_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dining());
        }

        private void EverydayApp_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.dynamify.sodexo";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID1 = "everyday";
                string appID2 = "id1338702323";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID1, appID2);
            }
            
            // Should add a display message to warn users about the device used if none of the above.
            
        }

        private void DiningHours_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiningHours());
        }

        private void DiningFAQs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiningFAQs());
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private async void AnimatedBG()
        {
            Action<double> forward = input => bdGradient.AnchorX = input;
            Action<double> backward = input => bdGradient.AnchorX = input;

            while (true)
            {
                bdGradient.Animate(name: "goForward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinInOut);
                await Task.Delay(5000);
                bdGradient.Animate(name: "goBackward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinInOut);
                await Task.Delay(5000);
            }
        }
    }
}