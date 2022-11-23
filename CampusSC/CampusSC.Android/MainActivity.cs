using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Android.Content;
using CampusSC.Droid;
using Android.Views;
using Android.Widget;
using CampusSC;
using Xamarin.Forms;
using Xamarin.Essentials;
using static Java.Text.Normalizer;

[assembly: Xamarin.Forms.Dependency(typeof(OpenAppAndroid))]
namespace CampusSC.Droid
{
    [Activity(Label = "CampusKickStart", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Sensor)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //ToolbarResource = Resource.Layout.toolbar_top;
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }

    public class OpenAppAndroid : IAppHandler
    {
        readonly string Url = "market://details?id=";
        public Task<bool> LaunchApp(string packageName)
        {
            bool result = false;
            
            try
            {
                PackageManager pm = Android.App.Application.Context.PackageManager;

                if (IsAppInstalled(packageName))
                {
                    Intent intent = pm.GetLaunchIntentForPackage(packageName);
                    if (intent != null)
                    {
                        intent.SetFlags(ActivityFlags.NewTask);
                        Android.App.Application.Context.StartActivity(intent);
                    }
                }
                else
                {
                    Intent intent = pm.GetLaunchIntentForPackage("com.android.vending");

                    if (intent != null)
                    {
                        Launcher.TryOpenAsync(Url + packageName);
                    }
                }
            }

            catch (ActivityNotFoundException)
            {
                result = false;
            }

            return Task.FromResult(result);
        }

        private bool IsAppInstalled(string packageName)
        {
            PackageManager pm = Android.App.Application.Context.PackageManager;
            bool installed;
            try
            {
                pm.GetPackageInfo(packageName, PackageInfoFlags.Activities);
                installed = true;
            }
            catch (PackageManager.NameNotFoundException)
            {
                installed = false;
            }
            return installed;
        } 
    }
}