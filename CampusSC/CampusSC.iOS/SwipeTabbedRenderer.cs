﻿using CampusSC.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(SwipeTabbedRenderer))]
namespace CampusSC.iOS
{
    
    class SwipeTabbedRenderer : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NativeView.AddGestureRecognizer(new UISwipeGestureRecognizer(() => SelectNextTab(1)) { Direction = UISwipeGestureRecognizerDirection.Left, ShouldRecognizeSimultaneously = ShouldRecognizeSimultaneously });
            NativeView.AddGestureRecognizer(new UISwipeGestureRecognizer(() => SelectNextTab(-1)) { Direction = UISwipeGestureRecognizerDirection.Right, ShouldRecognizeSimultaneously = ShouldRecognizeSimultaneously });
        }

        private void SelectNextTab(int direction)
        {
            int nextIndex = TabbedPage.GetIndex(Tabbed.CurrentPage) + direction;
            if (nextIndex < 0 || nextIndex >= Tabbed.Children.Count) return;
            var nextPage = Tabbed.Children[nextIndex];
            UIView.Transition(Platform.GetRenderer(Tabbed.CurrentPage).NativeView, Platform.GetRenderer(nextPage).NativeView, 0.15, UIViewAnimationOptions.TransitionCrossDissolve, null);
            Tabbed.CurrentPage = nextPage;
        }

        static bool ShouldRecognizeSimultaneously(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer) => gestureRecognizer != otherGestureRecognizer;
    }
}