using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WeaponHandoverSystem.Core.Domain.Entities;
namespace WeaponHandoverSystem.Infrastructure.dbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<WeaponHandover> WeaponHandovers { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Officer> Officers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities here
            base.OnModelCreating(modelBuilder);
        }
    }
}
