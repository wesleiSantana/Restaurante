using GarcomAnotacoes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarcomAnotacoes.Mappings
{
    public class PedidoMappings : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                 .ToTable("Pedidos");

            builder
                .HasKey(pedido => pedido.Id);

            builder
                .Property(pedido => pedido.NumeDaMesa)
                .HasColumnType("INT")
                .HasColumnName("Mesa")
                .IsRequired();

            builder.Property(pedido => pedido.NomeDocliente)
                .HasColumnType("VARCHAR(100)")
                .HasColumnName("Cliente")
                .IsRequired();

            builder.Property(pedido => pedido.NomeDoPrato)
                .HasColumnType("VARCHAR(100)")
                .HasColumnName("Prato");


            builder.Property(pedido => pedido.QuantidadeDePratos)
                .HasColumnType("INT")
                .HasColumnName("Qtd Pratos");


            builder.Property(pedido => pedido.NomeDaBabida)
                .HasColumnType("VARCHAR(100)")
                .HasColumnName("Bebida");


            builder.Property(pedido => pedido.QuantidaDeBebidas)
                .HasColumnType("INT")
                .HasColumnName("Qtd Bebidas");
                     
        }
    }
}
