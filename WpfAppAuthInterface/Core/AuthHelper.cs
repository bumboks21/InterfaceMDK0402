using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppAuthInterface.Core;

namespace WpfAppAuthInterface
{
    public class AuthHelper
    {
        public async Task<bool> UserWork(string Login, string Password)
        {
            using (StreamReader userReader = new StreamReader(@"..\..\Assets\Files\user.txt"))
            {
                var userAwait = await userReader.ReadToEndAsync();
                List<User> userList = new List<User>();

                foreach (var item in userAwait.Split('\n'))
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
                        if (user.Login.Contains(Login) && user.Password.Contains(Password))
                        {
                            UserEnteredData.EnteredUserFIO = " " + user.Name + " " + user.Surname;
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
