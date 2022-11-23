using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using CampusSC.Services;
namespace CampusSC
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Dining_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiningOptionsPage());
        }

        private void MaineCard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaineCardOptionsPage());
        }

        private void Housing_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HousingOptionsPage());
        }

        private void BookStore_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BookstoreTabbedPage());
        }

        private void Postal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PostalTabbedPage());
        }

        private void Parking_Clicked(object sender, EventArgs e)
        {
                Navigation.PushAsync(new ParkingOptionsPage());
        }

        private void Printing_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrintTabbedPage());
        }

        private void UsefulApps_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppsPage());
        }

        private void Necessities_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BearNecessitiesPage());
        }

        private void HeathCenter_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                 Navigation.PushAsync(new CutlerCenterPage());
            }
            if (Device.RuntimePlatform == Device.Android)
            {
                Uri uri = new Uri("https://northernlighthealth.org/Our-System/Eastern-Maine-Medical-Center/Locations/Primary-Care-UMaine");
                new OpenBrowser(uri);
            }
        }

        private void MyCampusPortal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CampusPortalPage());
        }

        private void UsefulSerivces_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsefulServicesOptionsPage());
        }
    }
}
