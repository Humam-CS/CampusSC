using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CampusSC;
using CampusSC.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]
namespace CampusSC.Droid
{
    class MyButtonRenderer : ButtonRenderer
    {
        public MyButtonRenderer(Context context) : base(context)
        { }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Element.ContentLayout.Position == Xamarin.Forms.Button.ButtonContentLayout.ImagePosition.Left)
            {
                const int imageMargin = 50; // This might need to multiplied by teh screen, not sure yet.
                float imageOffset = Control.TotalPaddingLeft - imageMargin;
                
                
            }
        //if (e.OldElement == null)
        //{
        //    button = (Xamarin.Forms.Button)e.NewElement;
        //    var gradientDrawable = new GradientStrokeDrawable();
        //    gradientDrawable.
        //}
        }
    }
    
}