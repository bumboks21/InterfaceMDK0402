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
using System.Collections.ObjectModel;

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
            _showFIO = new ObservableCollection<ShowFIO>();
        }
        ShowFIO showFIO;
        private ObservableCollection<ShowFIO> _showFIO;
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameBox.Text == "" || NameBox.Text == "" || PatronymicBox.Text == "")
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
            else
            {
                string Surname = SurnameBox.Text;
                string Name = NameBox.Text;
                string Patronymic = PatronymicBox.Text;
                showFIO = new ShowFIO(Surname, Name, Patronymic);
                _showFIO.Add(showFIO);
                FIO_List.ItemsSource = _showFIO;
                FIO_List.DisplayMemberPath = "FIO";
                SurnameBox.Text = ""; NameBox.Text = ""; PatronymicBox.Text = "";
            }
        }
    }
}
