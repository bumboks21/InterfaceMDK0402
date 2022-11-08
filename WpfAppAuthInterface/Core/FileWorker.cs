using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace WpfAppAuthInterface
{
    class FileWorker
    {
        public async Task<ObservableCollection<User>> UserWork()
        {
            var userList = new ObservableCollection<User>();
            using (StreamReader userReader = new StreamReader(@"..\..\Assets\Files\user.txt"))
            {
                var userReaderAwait = await userReader.ReadToEndAsync();
                foreach (var item in userReaderAwait.Split('\n'))
                {
                    var arrayString = item.Split(';');
                    {
                        var user = new User()
                        {
                            Login = arrayString[0],
                            Password = arrayString[1],
                            Name = arrayString[2],
                            Surname = arrayString[3]
                        };
                        userList.Add(user);
                    }
                }
                return userList;
            }
        }
        
        public async Task <ObservableCollection<Teacher>> TeacherWork()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader teacherReader = new StreamReader(@"..\..\Assets\Files\Teachers.txt"))
            {
                var teacherReaderAwait = await teacherReader.ReadToEndAsync();
                foreach (var item in teacherReaderAwait.Split('\n'))
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
        public async Task<ObservableCollection<Subject>> SubjectWork()
        {
            var subjectList = new ObservableCollection<Subject>();
            using (StreamReader subjectReader = new StreamReader(@"..\..\Assets\Files\Lesson.txt"))
            {
                var subjectReaderAwait = await subjectReader.ReadToEndAsync();
                foreach (var item in subjectReaderAwait.Split('\n'))
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
        /*public ObservableCollection<Teacher> TeacherWork()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader teacherReader = new StreamReader(@"..\..\Assets\Files\Teachers.txt"))
            {
                foreach (var item in teacherReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0] != "ID")
                    {
                        var teacher = new Teacher()
                        {
                            ID = int.Parse(arrayString[0]),
                            FirstName = arrayString[1],
                            LastName = arrayString[2],
                            Login = arrayString[3],
                            Password = arrayString[4]
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
        }*/
    }
}
