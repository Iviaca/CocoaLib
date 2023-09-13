using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CocoaLib.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        string _username;
        SecureString _password;
        string errorMsg;
        bool _isVisible = true;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }
        public SecureString Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }
        public string ErrorMsg
        {
            get => errorMsg;
            set { errorMsg = value; OnPropertyChanged(); }
        }
        public bool IsVisible
        {
            get => _isVisible;
            set { _isVisible = value; OnPropertyChanged(); }
        }
    }
}
