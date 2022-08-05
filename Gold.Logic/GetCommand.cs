using Gold.Common.Models;
using Gold.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Logic
{
    public class GetCommand
    {
        private static GetCommand _instance;
        public static GetCommand Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GetCommand();
                return _instance;
            }
        }

        public bool AddUser(User user)
        {
            return new Command().AddUser(user);
        }
    }
}
