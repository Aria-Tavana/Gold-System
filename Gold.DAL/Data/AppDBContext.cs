using Gold.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Gold.DAL.Data
{
    internal class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ARIA-PC\MYSQLSERVER;Initial Catalog=Gold-System-DB;User ID=sa;Password=Aria.1385");
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.UserInfo).WithOne(i => i.User).HasForeignKey<User>(u => u.UserId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
