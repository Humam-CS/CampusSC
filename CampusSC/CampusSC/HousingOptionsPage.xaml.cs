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
    public partial class HousingOptionsPage : ContentPage
    {
        private Task<bool> result;
        private Task<bool> openExternalAppService;

        public HousingOptionsPage()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){Title = "Image 1", Url = "https://umaine.edu/housing/wp-content/uploads/sites/154/2019/07/Hancock-rec-room-300x199.jpg"},
                new Image(){Title = "Image 2", Url = "https://umaine.edu/housing/wp-content/uploads/sites/154/2019/10/For-laundryview-explore-umaine-button-only-300x300.jpg"},
                new Image(){Title = "Image 3", Url = "https://umaine.edu/housing/wp-content/uploads/sites/154/2019/05/MaineCard-in-door-close-up-300x300.jpg"}
            };

            Carousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HousingServicesPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LaundryViewPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HousingLogonPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HousingFAQPage());
        }

        private void Stream2App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "tv.accedo.apogee.stream2";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id1272481498";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
        }

        private void GetConnected_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GetConnected());
        }
    }
}