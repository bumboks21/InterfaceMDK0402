using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAuthInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowPswrdBox_Checked(object sender, RoutedEventArgs e)
        {
            PswrdBox.Visibility = Visibility.Hidden;
            PswrdBoxx.Visibility = Visibility.Visible;
            PswrdBoxx.Text = PswrdBox.Password;
        }
        private void ShowPswrdBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PswrdBox.Visibility = Visibility.Visible;
            PswrdBoxx.Visibility = Visibility.Hidden;
            PswrdBox.Password = PswrdBoxx.Text;
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            string Login, Password, ShowPassword;
            Login = LoginBox.Text;
            Password = PswrdBox.Password;
            ShowPassword = PswrdBoxx.Text;
            User user = new User();
            bool result = user.CheckingUser(Login, Password, ShowPassword);
            if (result == true)
            {
                FIO fio = new FIO();
                fio.Show();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка аутентификации","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            string Login, Password;
            Login = LoginBox.Text;
            Password = PswrdBox.Password;
            MessageBox.Show("Логин: " + Login + "\tПароль: " + Password, "Регистрация прошла успешно!", MessageBoxButton.OK);
            FIO fio = new FIO();
            fio.Show();
            this.Close();
        }
    }
}