using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAuthInterface
{
    class ShowFIO
    {
        public string FIO { get; set; }

        public ShowFIO(string Surname, string Name, string Patronymic)
        {
            FIO = Surname + " " + Name[0] + ". " + Patronymic[0] + ".";
        }
    }
}
