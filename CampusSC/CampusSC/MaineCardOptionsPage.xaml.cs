using Android.Webkit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Windows.UI.Xaml.Controls;
using Xamarin.CommunityToolkit.Core;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;

namespace CampusSC
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaineCardOptionsPage : ContentPage
    {

        public MaineCardOptionsPage()
        {
            InitializeComponent();

        }



        private void MaineCard_Web_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaineCardPage());
        }

        private void MaineCard_Usage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaineCardUsagePage());
        }

        private void Add_Funds_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFundsPage());
        }

        private void FAQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaineCardFAQPage());
        }

    }
}