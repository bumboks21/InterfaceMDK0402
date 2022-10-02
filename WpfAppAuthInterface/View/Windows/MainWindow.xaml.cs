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
        private readonly MainWindowViewModel _mainViewModel;
        Binding binding = new Binding();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainViewModel = new MainWindowViewModel();
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

        //private void SignInBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    (DataContext as MainWindowViewModel).Auth();
        //    AuthHelper AH = new AuthHelper();
        //    bool result = AH.AuthHelp(LoginBox.Text, PswrdBoxx.Text);
        //    if (result == true)
        //        this.Close();
        //}

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Логин: " + LoginBox.Text + "\tПароль: " + PswrdBoxx.Text, "Регистрация прошла успешно!", MessageBoxButton.OK);
            this.Close();
        }
    }
}