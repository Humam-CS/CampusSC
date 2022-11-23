using CampusSC;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(CampusSC.iOS.MyButtonRenderer))]
namespace CampusSC.iOS
{
    class MyButtonRenderer : ButtonRenderer
    {
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            // Left allign the image and center the text
            if (Element.ContentLayout.Position == Button.ButtonContentLayout.ImagePosition.Left)
            {
                const int imageMargin = 10; // This might need to be multiplied by the screen, not sure yet.  I'll update this later if it does.
                nfloat imageOffset = Control.ImageView.Frame.Left - imageMargin;
                Control.ImageEdgeInsets = new UIEdgeInsets(0, -imageOffset, 0, imageOffset);

                nfloat imageWidth = 15;
                nfloat textOffset = Control.TitleLabel.Frame.Left - (imageWidth + Control.Frame.Width - Control.TitleLabel.Frame.Width) / 2;
                Control.TitleEdgeInsets = new UIEdgeInsets(0, -textOffset, 0, textOffset);
            }
        }
    }
}