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
    public partial class ParkingLotStatus : ContentPage
    {
        public ParkingLotStatus()
        {
            this.ToolbarItems.Add(new ToolbarItem
            {
                Command = new Command(() => Navigation.PushAsync(new MainPage()))
            });

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://sousa.umerl.maine.edu:444/parkinglotstatus/parkingstatus.aspx"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Accommodate iPhone status bar.

            this.Padding = new Thickness(10, Device.RuntimePlatform == Device.iOS ? 20 : 5, 10, 5);

            // Build this page.

            this.Content = new StackLayout
            {
                Children =
                {
                    webView
                },
                
            };
        }
    }
}