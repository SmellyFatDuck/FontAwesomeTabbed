using FontAwesomeTabbed.Controls;
using FontAwesomeTabbed.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StandardLabel), typeof(iOSStandardLabelRenderer))]

namespace FontAwesomeTabbed.iOS.Renderers
{
    public class iOSStandardLabelRenderer : LabelRenderer
    {
        public StandardLabel ElementV2 => Element as StandardLabel;

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            UILabel label = Control;
            int max = ElementV2.MaximumFontSize;
            int min = ElementV2.MinimumFontSize;

            if (label == null || min > max)
                return;

            label.AdjustsFontSizeToFitWidth = true;
            label.MinimumFontSize = (float)ElementV2.MinimumFontSize;
            label.Font = label.Font.WithSize((float)ElementV2.MaximumFontSize);
        }
    }
}