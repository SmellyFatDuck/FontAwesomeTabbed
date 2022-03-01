using CoreGraphics;
using FontAwesomeTabbed.Controls;
using FontAwesomeTabbed.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchBar), typeof(iOSCustomSearchBarRenderer))]

namespace FontAwesomeTabbed.iOS.Renderers
{
    public sealed class iOSCustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBar ElementV2 => Element as CustomSearchBar;

        protected override void SetBackgroundColor(Color color)
        {
            base.SetBackgroundColor(color);

            if (Control == null) return;

            Control.BarTintColor = UIColor.Clear;
            Control.BackgroundColor = UIColor.Clear;
            Control.Translucent = true;

            if (Control.ValueForKey(new NSString("searchField")) is UITextField textField)
            {
                textField.BackgroundColor = ElementV2.BackgroundColor.ToUIColor();
                Control.Layer.CornerRadius = ElementV2.CornerRadius;
                Control.Layer.BorderWidth = ElementV2.BorderThickness;
                Control.Layer.BorderColor = ElementV2.BorderColor.ToCGColor();

                var clearButton = Control.SearchTextField.ValueForKey((NSString)"clearButton") as UIButton;
                Control.SearchTextField.LeftView.TintColor = ElementV2.IconColor.ToUIColor();
                clearButton.TintColor = ElementV2.IconColor.ToUIColor();
            }

            UpdateCancelButton();
        }
    }
}
