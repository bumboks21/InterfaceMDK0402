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
using System.IO;

namespace WpfAppAuthInterface
{
    /// <summary>
    /// Логика взаимодействия для TimeTablePage.xaml
    /// </summary>
    public partial class TimeTablePage : Page
    {
        private readonly FileWorker worker;

        public TimeTablePage()
        {
            InitializeComponent();
            worker = new FileWorker();
            worker.TeacherWork();
            TeacherBox.ItemsSource = worker.TeacherWork();
            TeacherBox.DisplayMemberPath = "TeacherName";
            worker.SubjectWork();
            SubjectBox.ItemsSource = worker.SubjectWork();
            SubjectBox.DisplayMemberPath = "Lesson";
            _showTT = new ObservableCollection<TimeTableShow>();
        }
        TimeTableShow showTT;
        private ObservableCollection<TimeTableShow> _showTT;
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TeacherBox.Text) || string.IsNullOrEmpty(SubjectBox.Text))
                MessageBox.Show("Выберите учителя или предмет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                showTT = new TimeTableShow(TeacherBox.Text, SubjectBox.Text);
                _showTT.Add(showTT);
                SubjectTeacherListView.ItemsSource = _showTT;
                SubjectTeacherListView.DisplayMemberPath = "TimeTblShow";
            }
        }
    }
}
