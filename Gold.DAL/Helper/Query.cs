using Gold.Common.Models;
using Gold.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.DAL.Helper
{
    public class Query
    {
        public IQueryable<User> GetUsers()
        {
            try
            {
                AppDBContext appDBContext = new();
                {
                    return appDBContext.Users.Where(u => u.DeleteDate == null);
                }
            }
            catch (Exception) { return null; }
        }
    }
}
