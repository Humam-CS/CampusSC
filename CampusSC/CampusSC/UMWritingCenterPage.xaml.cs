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
    public partial class UMWritingCenterPage : ContentPage
    {
        public UMWritingCenterPage()
        {
            Label header = new Label
            {
                Text = "The Writing Center",
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
                    Url = "https://umaine.edu/wcenter/"
                },
                VerticalOptions = LayoutOptions.FillAndExpand,
                
            };
            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            Application.Current.RequestedThemeChanged += (s, a) =>
            {

            };
            
            // Accomodate iPhone Status bar.

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