using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace CampusSC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampusMap : ContentPage
    {
        public CampusMap()
        {
            InitializeComponent();

            Label Header = new Label
            {
                Text = "Campus Map",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            this.ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "home_white_24dp.png",
                Command = new Command(() => Navigation.PushAsync(new MainPage()))
            });

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://umaine.edu/campus-map/"
                },

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            //if(Device.RuntimePlatform == Device.Android)
            //{
            //    webView.On<Android>()
            //        .EnableZoomControls(true);
            //    webView.On<Android>()
            //        .DisplayZoomControls(true);
            //}

            // Accommodate iPhone state bar.

            this.Padding = new Thickness(10, (Device.RuntimePlatform == Device.iOS ? 20 : 5), 10, 5);

            // Build this page.

            this.Content = new StackLayout
            {
                Children =
                {
                    Header,
                    webView
                }
            };
        }
    }
}