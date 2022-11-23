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
    public partial class PostalTabbedPage : TabbedPage
    {
        public PostalTabbedPage()
        {
            this.ToolbarItems.Add(new ToolbarItem
            {
                IconImageSource = "",
                Command = new Command(() => Navigation.PushAsync(new MainPage()))
            });

            InitializeComponent();
        }
    }
}