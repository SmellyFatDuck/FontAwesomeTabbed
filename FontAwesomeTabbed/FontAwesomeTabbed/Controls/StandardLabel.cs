using Xamarin.Forms;

namespace FontAwesomeTabbed.Controls
{
    public sealed class StandardLabel : Label
    {
        public static BindableProperty MinimumFontSizeProperty =
            BindableProperty.Create(nameof(MinimumFontSize), typeof(int), typeof(StandardLabel), 0);

        public static BindableProperty MaximumFontSizeProperty =
            BindableProperty.Create(nameof(MaximumFontSize), typeof(int), typeof(StandardLabel), 18);

        public int MinimumFontSize
        {
            get => (int)GetValue(MinimumFontSizeProperty);
            set => SetValue(MinimumFontSizeProperty, value);
        }

        public int MaximumFontSize
        {
            get => (int)GetValue(MaximumFontSizeProperty);
            set => SetValue(MaximumFontSizeProperty, value);
        }
    }
}
