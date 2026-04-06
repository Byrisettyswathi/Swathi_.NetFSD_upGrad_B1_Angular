using Microsoft.EntityFrameworkCore;

namespace MVC_Assignment_2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=swathi\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}