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
using System.Windows.Shapes;
using WpfAppAuthInterface.Core;

namespace WpfAppAuthInterface
{
    /// <summary>
    /// Логика взаимодействия для TimeTable.xaml
    /// </summary>
    public partial class TimeTable : Window
    {
        public TimeTable()
        {
            InitializeComponent();
            MainFrame.Navigate(new TimeTablePage());
            FIO.Text += UserEnteredData.EnteredUserFIO;
        }

        private void TimeTblButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TimeTablePage());
        }

        private void TeacherButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ImageWindow());
        }
    }
}
