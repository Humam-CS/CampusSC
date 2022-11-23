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
    public partial class PrintingWebPage : ContentPage
    {
        public PrintingWebPage()
        {
            Label Header = new Label
            {
                Text = "Printing & Mailing Services",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://umaine.edu/printingandmailing/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    webView.On<Android>()
            //        .EnableZoomControls(true);
            //    webView.On<Android>()
            //        .DisplayZoomControls(true);
            //}

            // Accomadate iPhone state bar.
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