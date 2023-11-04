using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class User
    {
        public void createUser1(string fn, string ln, string sn, string pa, string vi)
        {
            Public.Lastname = ln;
            Public.Firstname = fn;
            Public.Passport = pa;
            Public.Secondname = sn;
            Public.Vibor = vi;
        }
        public string getInfo1()
        {
            return Public.Firstname + " " + Public.Lastname + " " + Public.Secondname + " " + Public.Passport + " " + Public.Vibor;
        }
    }
}
