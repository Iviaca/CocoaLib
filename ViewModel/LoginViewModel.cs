using CocoaLib.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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

        #region Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }
        #endregion

        #region ctor
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCmdAsync, CanExecuteLogin);//李氏转换 构造函数给几个command接口赋值实例化的viewmodelCommand
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverCmd("", ""));
        }

        private void ExecuteRecoverCmd(string username, string email)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void ExecuteLoginCmdAsync(object obj)
        {
            UserRepository usrRepo =  new UserRepository();
            bool usrValid = usrRepo.AuthenticateUser(new NetworkCredential(Username, Password));
            if (!usrValid)
            {
                MessageBox.Show("卟卟！");
            }
            else
            {
                MessageBox.Show("可爱捏");
            }
        }

        private bool CanExecuteLogin(object obj)
        {
            bool dataValid;
            if (string.IsNullOrEmpty(Username) || Username.Length < 5 || Password == null || Password.Length < 5)
                dataValid = false;
            else
                dataValid = true;

            return dataValid;
        }
    }
}
