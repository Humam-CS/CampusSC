using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CampusSC.Services;

namespace CampusSC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParkingOptionsPage : ContentPage
    {
        public ParkingOptionsPage()
        {
            InitializeComponent();
        }

        private void Parking_Web_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParkingWebPage());
        }

        private void Public_transportation_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                Navigation.PushAsync(new PublicTransportationPage());
            }
            if (Device.RuntimePlatform == Device.Android)
            {
                Uri uri = new Uri("https://umaine.edu/parking/public-transportation/");
                new OpenBrowser(uri);
            }
            
        }

        private void Perschase_Permit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PurchasePermit());
        }

        private void Campus_Map_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CampusMap());
        }

        private void FAQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParkingFAQ());
        }

        private void EVCharging_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EVCharging());
        }
    }
}