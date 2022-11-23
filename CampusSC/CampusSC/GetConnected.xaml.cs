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
    public partial class GetConnected : ContentPage
    {
        public GetConnected()
        {
            InitializeComponent();

            Label header = new Label
            {
                Text = "Get Connected",
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
                    Url = "https://umaine.edu/campuscable/get-connected/"
                },

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Accomodate iPhone state bar.

            this.Padding = new Thickness(10, Device.RuntimePlatform == Device.iOS ? 20 : 5, 10, 5);

            // Build the page.

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView
                }
            };
        }
    }
}