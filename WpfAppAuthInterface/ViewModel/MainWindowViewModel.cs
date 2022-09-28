using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppAuthInterface
{
    class MainWindowViewModel : BaseViewModel
    {
        private readonly AuthHelper _authHelper;
        private string _login;
        private string _password;

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
        public MainWindowViewModel()
        {
            _authHelper = new AuthHelper();
        }
        public void Auth()
        {
            if (string.IsNullOrEmpty(Login)||string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Заполните все поля!","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            if (_authHelper.AuthHelp(Login,Password))
            {
                MessageBox.Show("Вы успешно авторизовались","Вход",MessageBoxButton.OK);
                TimeTable TimeTbl = new TimeTable();
                TimeTbl.Show();
                //MainWindow mw = new MainWindow();
                //mw.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует.\nПожалуйста, проверьте введенные данные","Ошибка",MessageBoxButton.OK,MessageBoxImage.Hand);
            }
        }
    }
}
