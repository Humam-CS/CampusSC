using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Essentials;

namespace CampusSC.Services
{
    public class OpenBrowser
    {
        public OpenBrowser(Uri uri)
        {
            Browser.OpenAsync(uri, new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.FromArgb(0, 50, 99),
                PreferredControlColor = Color.FromArgb(176, 215, 255)

            });
        }
        
 
    }
}
