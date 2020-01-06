using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace RSDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginViewModel;

        public ShellViewModel(LoginViewModel loginViewModel)
        {
            // set via DI
            _loginViewModel = loginViewModel;
            
            // Caliburn Micro looks up for LoginView and displays it
            ActivateItem(_loginViewModel);
        }
    }
}
