using GarcomAnotacoes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarcomAnotacoes.Mappings
{
    public class CozinhaMappings : IEntityTypeConfiguration<Cozinha>
    {
        public void Configure(EntityTypeBuilder<Cozinha> builder)
        {
            builder
                 .ToTable("Cozinhas");

            builder
                .HasKey(cozinha => cozinha.Id);

        }
    }
}
