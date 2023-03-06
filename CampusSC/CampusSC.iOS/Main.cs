using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Foundation;
using UIKit;
using Xamarin.Forms;
using CampusSC.iOS;
using CampusSC.Services;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(OpenExternalAppService))]
namespace CampusSC.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }

    public class OpenExternalAppService : IOpenExternalAppService
    {
        public Task<bool> LaunchApp(string uri1, string uri2)
        {
            try
            {
                var canOpen = UIApplication.SharedApplication.CanOpenUrl(new NSUrl(uri1 + "://"));
                if (!canOpen)
                    TryLaunchingApp(uri2);
                return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl(uri1 + "://")));
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        private Task TryLaunchingApp(string uri)
        {
            string Url = "https://apps.apple.com/us/app/app-store/";
            return Launcher.TryOpenAsync(
                new Uri(Url + uri));
        }
    }

}
