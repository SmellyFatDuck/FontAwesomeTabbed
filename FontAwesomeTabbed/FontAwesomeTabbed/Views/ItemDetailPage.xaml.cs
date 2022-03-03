using FontAwesomeTabbed.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeTabbed.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}