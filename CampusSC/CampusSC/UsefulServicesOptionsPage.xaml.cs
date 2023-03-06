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

            List<Image> images = new List<Image>()
            {
                new Image(){Title = "Image 1", Url = "https://new.umaine.edu/housing/wp-content/uploads/sites/663/2022/11/default-og-image-1024x538.png"},
                new Image(){Title = "Image 2", Url = "https://new.umaine.edu/housing/wp-content/uploads/sites/663/2022/12/Black-Modern-Restaurant-Open-Instagram-Post-1024x1024.png"},
                new Image(){Title = "Image 3", Url = "https://new.umaine.edu/housing/wp-content/uploads/sites/663/2022/12/White-and-Blue-Did-You-Know-Interesting-Fact-Instagram-Post.png"},
                new Image(){Title = "Image 4", Url = "https://new.umaine.edu/housing/wp-content/uploads/sites/663/2022/12/Apply-for-your-1024x1024.png"}
            };

            Carousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            });
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