using System;
using System.Collections.Generic;
using System.IO;
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

        public User(string login, string name, string password, bool hasEditAccess)
        {
            _login = login;
            _name = name;
            _password = password;
            _hasEditAccess = hasEditAccess;
        }


        public static bool IsAdmin = false;
        public static string UserFile = "../../data/u.txt";
        public static List<User> UserList;
        public static List<User> ReadUsers(string _fileName)
        {

            List<User> _userList = new List<User>();
            using (var sr = new StreamReader(_fileName))
            {
                while (sr.EndOfStream == false)
                {
                    var row = sr.ReadLine();
                    var words = row.Split(':');
                        User u = new User(words[0], words[1], words[2], bool.Parse(words[3]));
                        _userList.Add(u);
                        

                }
                
            }


            return _userList;
        }

        public static void SaveData(string _fileName, List<User> _userList)
        {
            using (var sw = new StreamWriter(_fileName))
            {
                foreach (var user in _userList)
                {
                    sw.WriteLine($"{user.Login}:{user.Name}:{user.Password}:{user.HasEditAccess}");
                }
            }
        }
    }
}
