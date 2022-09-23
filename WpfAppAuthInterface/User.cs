using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfAppAuthInterface
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ShowPassword { get; set; }

        public static ObservableCollection<User> GetUserList()
        {
            var userList = new ObservableCollection<User>()
            {
                 new User()
                 {
                    Login="qwerty",
                    Password="123456"
                 }
            };
            return userList;
        }
        public bool CheckingUser(string Login, string Password, string ShowPassword)
        {
            foreach (var user in GetUserList())
            {
                if (user.Login == Login && (user.Password == Password || user.ShowPassword == ShowPassword))
                    return true;
                else return false;
            }
            return false;
        }
    }
}
