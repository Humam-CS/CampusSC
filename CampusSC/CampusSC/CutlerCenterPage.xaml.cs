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
    public partial class CutlerCenterPage : ContentPage
    {
        public CutlerCenterPage()
        {
            

            Label Header = new Label
            {
                Text = "Cutler Health Center",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            
            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = "https://northernlighthealth.org/Our-System/Eastern-Maine-Medical-Center/Locations/Primary-Care-UMaine",

                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
               
            };

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    webView.On<Android>()
            //        .EnableZoomControls(true);
            //    webView.On<Android>()
            //        .DisplayZoomControls(true);
            //}

            // Accommodate iPhone state bar.
            this.Padding = new Thickness(10, Device.RuntimePlatform == Device.iOS ? 20 : 5, 10, 5);

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