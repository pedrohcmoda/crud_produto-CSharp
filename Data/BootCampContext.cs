using BootCamp.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp.Data
{
    public class BootCampContext : DbContext
    {
        public BootCampContext(DbContextOptions<BootCampContext> options) : base(options) { }

        public DbSet<Produto> GoldenPenProdutos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18, 2)");
        }

    }
    
}
