using Microsoft.EntityFrameworkCore;

namespace FridgeManager.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fridge> Fridges { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=fridgedb;Trusted_Connection=true;TrustServerCertificate=true;");
        //}

    }
}
