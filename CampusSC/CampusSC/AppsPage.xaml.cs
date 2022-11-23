using CampusSC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampusSC
{
    public interface IAppHandler
    {
        Task<bool> LaunchApp(String uri);
    }
    public partial class AppsPage : ContentPage
    {
        private Task<bool> result;
        private Task<bool> openExternalAppService;

        public AppsPage()
        {
            InitializeComponent();
        }

        private void Black_Bear_Safe_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.cutcom.apparmor.umaine";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }
            if(Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id1478305175";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
           
        }

        private void Black_Bear_Nation_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.sidearmsports.umaine";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id1521886316";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
            
        }

        private void GrubHub_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.grubhub.android";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id302920553";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
        }

        private void Navigate_Student_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.eab.se";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id950433229";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
        }

        private void Stream_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "tv.accedo.apogee.stream2";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id1272481498";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
        }

        private void Transact_eAccounts_App_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string appName = "com.blackboard.transact.android.v2&hl=en_US";
                result = DependencyService.Get<IAppHandler>().LaunchApp(appName);
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                string appID = "id1493974212";
                openExternalAppService = DependencyService.Get<IOpenExternalAppService>().LaunchApp(appID);
            }
        }
    }
}