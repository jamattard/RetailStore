using Caliburn.Micro;
using RSDesktopUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username;
        private string _password;
        private IAPIHelper _apiHelper;
        public LoginViewModel(IAPIHelper apiHelper)
        {
            this._apiHelper = apiHelper;
        }

        // must use the same textbox name for textbox to bind to property
        public string Username
        {
            get { return _username; }
            set 
            { 
                _username = value;
                NotifyOfPropertyChange(() => Username);
                NotifyOfPropertyChange(() => CanLogIn);

            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                if (Username?.Length > 0 && Password?.Length > 0)
                    return true;

                return false;
            }
        }

        public async Task LogIn()
        {
            try
            {
                var result = await _apiHelper.Authenticate(Username, Password);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);            
            }

        }

    }
}
