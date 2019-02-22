using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MySamurai.Domain;

namespace MySamurai.Data
{
    public class SamuraiContext: DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options) : base(options)
        {
        }

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }


        //Contectar con el proveedor
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(
        //         "Server = (localdb)\\mssqllocaldb; Database = SamuraiAppData; Trusted_Connection = True; ");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.SamuraiId, s.BattleId });

        }


    }
}
