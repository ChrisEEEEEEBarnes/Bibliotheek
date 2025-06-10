using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Login
    {
        private string _mail;
        private string _password;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Login()
        {
            Mail = "";
            Password = "";
        }
        public Login(string mail, string password)
        {
            Mail= mail;
            Password = password;
        }
    }
}
