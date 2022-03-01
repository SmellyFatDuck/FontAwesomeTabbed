using Android.App;
using Android.Content;
using Android.Util;
using Android.Widget;
using AndroidX.Core.Widget;
using FontAwesomeTabbed.Controls;
using FontAwesomeTabbed.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(StandardLabel), typeof(StandardLabelRenderer))]

namespace FontAwesomeTabbed.Droid.Renderers
{
    public class StandardLabelRenderer : LabelRenderer
    {
        public StandardLabelRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            StandardLabel label = (StandardLabel)e.NewElement;
            TextView textView = Control;
            int max = label.MaximumFontSize;
            int min = label.MinimumFontSize;

            if (Control == null || min > max)
                return;

            textView.SetAutoSizeTextTypeUniformWithConfiguration(min, max, 1, (int)ComplexUnitType.Sp);
        }
    }
}