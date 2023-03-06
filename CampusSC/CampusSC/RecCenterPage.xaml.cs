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
    public partial class RecCenterPage : ContentPage
    {
        public RecCenterPage()
        {
            this.ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "home_white_24dp.png",
                Command = new Command(() => Navigation.PushAsync(new MainPage()))
            });

            Label header = new Label
            {
                Text = "The Recreation Center",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://umaine.edu/campusrecreation/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            // Accomodate iPhone status bar.

            this.Padding = new Thickness(10, Device.RuntimePlatform == Device.iOS ? 20 : 5, 10, 5);

            // Build this page.

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