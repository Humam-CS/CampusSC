using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace CampusSC.Droid
{
    internal class FullScreenClient : WebChromeClient

    {
        readonly FrameLayout.LayoutParams matchParentLayout = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 
            ViewGroup.LayoutParams.MatchParent);

        readonly ViewGroup content;
        readonly ViewGroup parent;
        View customeView;

        public FullScreenClient(ViewGroup parent, ViewGroup content)
        {
            this.parent = parent;
            this.content = content;
        }

        [Obsolete]
        public override void OnShowCustomView(View view, [GeneratedEnum] ScreenOrientation requestedOrientation, ICustomViewCallback callback)
        {
            customeView = view;
            view.LayoutParameters = matchParentLayout;
            parent.AddView(view);
            content.Visibility = ViewStates.Gone;
            MainActivity hideBar = (MainActivity)Platform.CurrentActivity;
            hideBar.Window.AddFlags(WindowManagerFlags.Fullscreen);
        }

    }
}