using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampusSC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrintFAQsPage : ContentPage
    {
        public PrintFAQsPage()
        {
            InitializeComponent();

            Label Header = new Label
            {
                Text = "FAQs",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Xamarin.Forms.WebView webView = new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://umaine.edu/printingandmailing/faqs/"
                },

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            if (Device.RuntimePlatform == Device.Android)
                

            // Accommodate iPhone state bar.

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