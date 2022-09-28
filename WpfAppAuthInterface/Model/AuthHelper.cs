using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAuthInterface
{
    public class AuthHelper
    {
        public bool AuthHelp(string login, string password)
        {
            if (login == "qwerty" && password == "123456")
                return true;
            else return false;
        }
    }
}
