using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampusSC.MarkupExtensions
{
    [ContentProperty("ContentLayout")]
    public class ButtonContentLayoutExtension : IMarkupExtension

    {
        public string AndroidPosition { get; set; }
        public double AndroidSpacing { get; set; }
        public string IOSPosition { get; set; }
        public double IOSpacing { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            string position = null;
            double? spacing = null;

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    position = AndroidPosition;
                    spacing = AndroidSpacing;
                    break;
                case Device.iOS:
                    position = IOSPosition;
                    spacing = IOSpacing;
                    break;
            }

            if (string.IsNullOrEmpty(position))
            {
                position = "Left";
            }
            if (spacing == null)
            {
                spacing = 0;
            }

            var converter = new Button.ButtonContentTypeConverter();
            return converter.ConvertFromInvariantString(string.Format("{0},{1}", position, spacing));
        }
    }
}
