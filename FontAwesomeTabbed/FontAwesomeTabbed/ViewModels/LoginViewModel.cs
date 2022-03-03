using System;
using Xamarin.Forms;

namespace FontAwesomeTabbed.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private void OnLoginClicked(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
