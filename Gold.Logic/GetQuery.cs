using Gold.Common.Models;
using Gold.DAL.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Logic
{
    public class GetQuery
    {
        private static GetQuery _instance;
        public static GetQuery Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GetQuery();
                return _instance;
            }
        }

        public List<User> UsersList()
        {
            Query query = new();
            if (query.GetUsers() != null)
            {
                IQueryable<User> data = query.GetUsers();
                return data
                    .Include(u => u.UserInfo)
                    .ToList();
            }
            return null;
        }
    }
}
