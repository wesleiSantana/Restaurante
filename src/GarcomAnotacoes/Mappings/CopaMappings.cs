using GarcomAnotacoes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarcomAnotacoes.Mappings
{
    public class CopaMappings : IEntityTypeConfiguration<Copa>
    {
        public void Configure(EntityTypeBuilder<Copa> builder)
        {
            builder
                 .ToTable("Copas");

            builder
                .HasKey(copa => copa.Id);

        }
    }
}
