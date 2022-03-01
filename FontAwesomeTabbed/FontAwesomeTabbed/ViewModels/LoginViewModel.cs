using FontAwesomeTabbed.Views;
using System;
using System.Collections.Generic;
using System.Text;
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
