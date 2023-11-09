using billsbuddy.Models;
using Microsoft.EntityFrameworkCore;

namespace billsbuddy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Net_salary> Net_Salary { get; set; }
        public DbSet<Amount_target> Amount_target { get; set; }
        public DbSet<Amount_enter> Amount_enter { get; set; }
        public DbSet<Amount_result> AmountResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users { Id_user = 1, email = "nuratkz93@gmail.com", password = "1234", phone = "0133130589", Date = DateTime.Parse("2023-11-09 15:30:45") },
                new Users { Id_user = 2, email = "toyaleran93@gmail.com", password = "1234", phone = "01159881106", Date = DateTime.Parse("2023-11-09 15:36:45") }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
