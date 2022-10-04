using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class DocumentoMap : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("Documento");

            builder.HasOne(e => e.Estudante)
                    .WithMany(ed => ed.Documentos)
                    .HasForeignKey(ed => ed.EstudanteId);

            builder.HasIndex(c => c.Numero).IsUnique();
        }
    }
}
