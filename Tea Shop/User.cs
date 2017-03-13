using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Shop
{
    class User
    {
        private string _login;
        private string _name;
        private string _password;
        private bool _hasEditAccess;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool HasEditAccess
        {
            get { return _hasEditAccess; }
            set { _hasEditAccess = value; }
        }
    }
}
