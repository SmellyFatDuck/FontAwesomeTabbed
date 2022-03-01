using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FontAwesomeTabbed.Controls;
using FontAwesomeTabbed.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]

namespace FontAwesomeTabbed.Droid.Renderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context) : base(context)
        {
        }

        public CustomSearchBar ElementV2 => Element as CustomSearchBar;
        protected override SearchView CreateNativeControl()
        {
            var control = base.CreateNativeControl();
            UpdateBackground(control);
            return control;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == CustomSearchBar.CornerRadiusProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == CustomSearchBar.BorderThicknessProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == CustomSearchBar.BorderColorProperty.PropertyName)
            {
                UpdateBackground();
            }

            base.OnElementPropertyChanged(sender, e);
        }

        protected override void UpdateBackgroundColor() => UpdateBackground();

        protected void UpdateBackground(SearchView control)
        {
            if (control == null) return;

            var gd = new GradientDrawable();
            gd.SetColor(Element.BackgroundColor.ToAndroid());
            gd.SetCornerRadius(Context.ToPixels(ElementV2.CornerRadius));
            gd.SetStroke((int)Context.ToPixels(ElementV2.BorderThickness), ElementV2.BorderColor.ToAndroid());

            int searchPlateId = Resources.GetIdentifier("android:id/search_plate", null, null);
            var searchPlate = control.FindViewById(searchPlateId);
            if (searchPlate != null)
                searchPlate.SetBackgroundColor(Color.Transparent);

            control.SetBackground(gd);

            var searchIconId = control.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
            if (searchIconId > 0)
            {
                var searchPlateIcon = control.FindViewById(searchIconId);
                (searchPlateIcon as ImageView).SetColorFilter(ElementV2.IconColor.ToAndroid(), PorterDuff.Mode.SrcIn);
            }
        }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        protected void UpdateBackground()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            UpdateBackground(Control);
        }
    }
}