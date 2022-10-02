using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfAppAuthInterface
{
    class FileWorker
    {   
        public ObservableCollection<Teacher> TeacherWork()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader teacherReader = new StreamReader(@"..\..\Assets\Files\Teachers.txt"))
            {
                foreach (var item in teacherReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0]!="ID")
                    {
                        var teacher = new Teacher()
                        {
                            ID = int.Parse(arrayString[0]),
                            FirstName = arrayString[1],
                            LastName=arrayString[2],
                            Login=arrayString[3],
                            Password=arrayString[4]
                        };
                        teacherList.Add(teacher);
                    }
                }
                return teacherList;
            }
        }
        public ObservableCollection<Subject> SubjectWork()
        {
            var subjectList = new ObservableCollection<Subject>();
            using (StreamReader subjectReader = new StreamReader(@"..\..\Assets\Files\Lesson.txt"))
            {
                foreach (var item in subjectReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split('?');
                    if (arrayString[0] != "ID")
                    {
                        var subject = new Subject()
                        {
                            ID = int.Parse(arrayString[0]),
                            Lesson = arrayString[1]
                        };
                        subjectList.Add(subject);
                    }
                }
                return subjectList;
            }
        }
    }
}
