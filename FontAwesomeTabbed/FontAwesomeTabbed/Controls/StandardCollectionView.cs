using FontAwesomeTabbed.Models;
using System.Diagnostics;
using Xamarin.Forms;

namespace FontAwesomeTabbed.Controls
{
    public class StandardCollectionView : CollectionView
    {
        public static BindableProperty ScrollToItemProperty =
            BindableProperty.Create(nameof(ScrollToItem), typeof(Icon), typeof(StandardCollectionView), propertyChanged: ScrollIndexChanged);

        public Icon ScrollToItem
        {
            get => (Icon)GetValue(ScrollToItemProperty);
            set => SetValue(ScrollToItemProperty, value);
        }

        private static void ScrollIndexChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Debug.WriteLine("Property Changed!");
            if (newValue == null)
                return;

            Debug.WriteLine("Has new value!");
            if (bindable is StandardCollectionView current)
                if (newValue is Icon scrollToItem)
                    current.ScrollTo(scrollToItem);

            Debug.WriteLine("Should be scrolling to item...");
        }
        /*public static BindableProperty ScrollToItemProperty =
            BindableProperty.Create(nameof(ScrollToItem), 
                                    typeof(Icon), 
                                    typeof(StandardCollectionView),
                                    typeof(Icon),
                                    BindingMode.Default,
                                    propertyChanged: ScrollIndexChanged);

        public Icon ScrollToItem
        {
            get => (Icon)GetValue(ScrollToItemProperty);
            set => SetValue(ScrollToItemProperty, value);
        }

        private static void ScrollIndexChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;

            if (bindable is StandardCollectionView current)
                if (newValue is Icon scrollToItem)
                    current.ScrollTo(scrollToItem);
        }*/

    }
}