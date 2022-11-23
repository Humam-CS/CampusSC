using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Button = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.Button;

namespace CampusSC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiningServiesWeb : ContentPage
    {
        public DiningServiesWeb()
        {
            //Label Header = new Label
            //{
            //    Text = "Dining Services Website",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    HorizontalOptions = LayoutOptions.Center
            //};

            //ToolbarItem item = new ToolbarItem();
            //item.IconImageSource = "home_white_24dp.png";
            //item.Priority = 0;
            //item.Order = ToolbarItemOrder.Primary;
            //item.Clicked += Item_Home_Clicked;

            // Adding the Home button and giving it a command
            this.ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "home_white_24dp.png",
                Command = new Command (() => Navigation.PushAsync(new MainPage()))
            });

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://umaine.edu/dining/"
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

            // Build this page.

            this.Content = new StackLayout
            {
                Children =
                {
                    //Header,
                    webView
                }
            };
        }
    }
}