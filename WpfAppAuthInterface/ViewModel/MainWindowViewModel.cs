using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppAuthInterface.ViewModel;

namespace WpfAppAuthInterface
{
    class MainWindowViewModel : BaseViewModel
    {     
        private string _login;
        private string _password;
        private readonly AuthHelper _authHelper;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand SignInButton
        {
            get;
        }
        public MainWindowViewModel()
        {
            _authHelper = new AuthHelper();
            SignInButton = new DelegateCommand(Auth);
        }
        private async void Auth(object obj)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
                if (await _authHelper.UserWork(Login, Password))
                {
                    TimeTable tt = new TimeTable();
                    tt.Show();
                    foreach (Window w in App.Current.Windows)
                    {
                        if (w.Title == "Login")
                            w.Close();
                    }
                }
            else MessageBox.Show("Введены некорректные данные");
        }
    }
}