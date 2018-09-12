using CapVerify.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CapVerify.Data.Mappings
{
    public class TituloCapitalizacaoMap : IEntityTypeConfiguration<TituloCapitalizacao>
    {
        public void Configure(EntityTypeBuilder<TituloCapitalizacao> builder)
        {
            builder.ToTable("TitulosCapitalizacao");

            builder.HasKey(t => t.TituloCaptalizacaoId);

            builder.Property(t => t.TituloCaptalizacaoId)
                .HasColumnName("Id");

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
