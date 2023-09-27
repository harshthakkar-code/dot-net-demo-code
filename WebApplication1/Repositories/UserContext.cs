using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<UsersHobbiesModel> UsersHobbies { get; set; }
        public DbSet<GenderModel> Gender { get; set; }
        public DbSet<HobbyModel> Hobby { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-0STO2FF\SQLEXPRESS;initial catalog=UserDb;Trusted_Connection=Yes;TrustServerCertificate=True");
        }
    }
}
