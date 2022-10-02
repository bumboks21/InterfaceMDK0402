using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAuthInterface
{
    public class AuthHelper
    {
        //public bool AuthHelp(string login, string password)
        //{
        //    if (login == "qwerty" && password == "123456")
        //        return true;
        //    else return false;
        //}
        public string Login { get; set; }
        public string Password { get; set; }
        public string ShowPassword { get; set; }

        public static ObservableCollection<AuthHelper> GetUserList()
        {
            var userList = new ObservableCollection<AuthHelper>()
            {
                 new AuthHelper()
                 {
                    Login="qwerty",
                    Password="123456"
                 },
                 new AuthHelper()
                 {
                     Login="Chupep",
                     Password="Uzbekiston"
                 },
                 new AuthHelper()
                 {
                     Login="Mercedes",
                     Password="c180"
                 }
            };
            return userList;
        }
        public bool AuthHelp(string Login, string Password)
        {
            foreach (var user in GetUserList())
            {
                if (user.Login == Login && user.Password == Password)
                    return true;
            }
            return false;
        }
    }
}
