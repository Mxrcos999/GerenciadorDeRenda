using GerenciadorDeRendaDomain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GerenciadorDeRendaInfra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Previsao> Previsao { get; set; }


    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql("User ID = postgres;Password=12345;Host=localhost;Port=5432;Database=postgres");

            return new AppDbContext(optionsBuilder.Options);
        }

    
    }

}
