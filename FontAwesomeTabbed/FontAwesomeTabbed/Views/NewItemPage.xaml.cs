using FontAwesomeTabbed.Models;
using FontAwesomeTabbed.ViewModels;
using Xamarin.Forms;

namespace FontAwesomeTabbed.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}