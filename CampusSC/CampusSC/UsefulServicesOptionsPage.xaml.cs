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
    public partial class UsefulServicesOptionsPage : ContentPage
    {
        public UsefulServicesOptionsPage()
        {
            InitializeComponent();
        }

        private void UMaine_Career_Center_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UMCC());
        }

        private void The_Writing_Center_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UMWritingCenterPage());
        }

        private void Rec_Center_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecCenterPage());
        }

        private void InvolveME_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InvolveMEPage());
        }
    }
}