
using Microsoft.EntityFrameworkCore;
using EFCore_MVC_Assignment.Entity;


namespace EFCore_MVC_Assignment.Database
{
    public class AppContextDb : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( "Data Source=swathi\\SQLEXPRESS;Initial Catalog=EFCoreDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
            );
        }
    }
}