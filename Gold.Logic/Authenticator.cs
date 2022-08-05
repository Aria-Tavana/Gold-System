using Gold.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Logic
{
    public class Authenticator
    {
        private static Authenticator _instance;
        public static Authenticator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Authenticator();
                return _instance;
            }
        }

        public int UserID { get; private set; }

        public bool CheckUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;
            string hashPassword = DataHelper.Instance.HashText(password);
            User findUser = GetQuery.Instance.UsersList().FirstOrDefault(u => u.Username == username && u.Password == hashPassword);
            if (findUser != null)
            {
                UserID = findUser.Id;
                return true;
            }
            else
                return false;
        }
    }
}
