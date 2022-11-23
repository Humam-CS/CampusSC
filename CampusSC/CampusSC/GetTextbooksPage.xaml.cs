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
    public partial class GetTextbooksPage : ContentPage
    {
        public GetTextbooksPage()
        {
            InitializeComponent();

            Label Header = new Label
            {
                Text = "Get my Textbooks",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://bookstore.umaine.edu/adoption-search"
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

            // Accomodate iPhone state bar.

            this.Padding = new Thickness(10, (Device.RuntimePlatform == Device.iOS ? 20 : 5), 10, 5);

            // Build the page.

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