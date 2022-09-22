using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAuthInterface
{
    class Person
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static void CheckLoginPassword(Person person)
        {

        }
        public Person(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public void CheckPassword()
        {
            if (Login == "qwerty" && Password == "123456")
            {
                //MessageBox.Show("Вход успешно выполнен!", "", MessageBoxButton.OK);
                FIO fio = new FIO();
                fio.Show();
                //Hide();
            }
            else
            {

            }
        }
    }
}
