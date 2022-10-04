using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class EstudanteNotaMap : IEntityTypeConfiguration<EstudanteNota>
    {
        public void Configure(EntityTypeBuilder<EstudanteNota> builder)
        {
            builder.ToTable("EstudanteNota");

            builder.HasOne(m => m.Materia)
                   .WithMany(en => en.EstudanteNotas)
                   .HasForeignKey(m => m.MateriaId)
                   .IsRequired();

            builder.Property(e => e.Nota).HasColumnType("float").IsRequired();
            builder.Property(e => e.Observacao).HasColumnType("varchar(250)");
            builder.Property(e => e.DataLancamento).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.MateriaId).IsRequired();
        }
    }
}
