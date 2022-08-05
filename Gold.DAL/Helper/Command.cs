using Gold.Common.Interfaces;
using Gold.Common.Models;
using Gold.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.DAL.Helper
{
    public class Command
    {
        public bool AddUser(IEntity entity)
        {
            AppDBContext ctxApp = new();
            try
            {
                ctxApp.Entry(entity).Entity.CreateDate = DateTime.Now;
                ctxApp.Entry(entity).Entity.DeleteDate = null;
                ctxApp.Entry(entity).State = EntityState.Added;
                if (typeof(User) == entity.GetType())
                {
                    UserInfo userInfo = ((User)entity).UserInfo;
                    ctxApp.Entry(userInfo).State = EntityState.Added;
                }
                ctxApp.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
