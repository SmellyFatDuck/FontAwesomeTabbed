using FontAwesomeTabbed.Models;
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
            if (newValue == null)
                return;

            if (bindable is StandardCollectionView current)
                if (newValue is Icon scrollToItem)
                    current.ScrollTo(scrollToItem);
        }
    }
}
