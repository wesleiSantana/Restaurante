using GarcomAnotacoes.Models;
using GarcomAnotacoes.Mappings;
using Microsoft.EntityFrameworkCore;

namespace GarcomAnotacoes.Data
{
    public class Context : DbContext
    {
        public Context()
        {}

        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Copa> Capas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cozinha> Cozinhas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CopaMappings());
            modelBuilder.ApplyConfiguration(new PedidoMappings());
            modelBuilder.ApplyConfiguration(new CozinhaMappings());
        }
    }
}
