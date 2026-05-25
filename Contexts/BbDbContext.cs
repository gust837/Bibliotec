using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Contexts
{
    public class BbDbContext : DbContext
    {
        public BbDbContext(DbContextOptions<BbDbContext> options) : base(options){}
            
        public DbSet<Usuario> Usuario { get; set; } =null!;

        public DbSet<Cateogria> Categoria { get; set; } =null!;

        public DbSet<Cateogria> Livro { get; set; } =null!;

        public DbSet<LivroCategoria> LivroCategoria { get; set; } =null!;

        public DbSet<Reserva> Reserva { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroCategoria>().HasKey(lc => new {lc.LivroId, lc.CategoriaId});
        }
    }
}