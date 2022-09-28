using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAuthInterface
{
    class TimeTableShow
    {
        public string TimeTblShow { get; set; }
        public TimeTableShow(string FirstName, string _Subject)
        {
            TimeTblShow = FirstName + " : " + _Subject;
        }
    }
}
