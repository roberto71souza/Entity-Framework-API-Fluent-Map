using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(m => m.Id);
            builder.HasKey(m => new { m.Id, m.EstudanteId, m.CursoId });

            builder.HasOne(e => e.Estudante)
                   .WithMany(m => m.Matriculas)
                   .HasForeignKey(e => e.EstudanteId)
                   .IsRequired();

            builder.HasOne(c => c.Curso)
                   .WithMany(m => m.Matriculas)
                   .HasForeignKey(c => c.CursoId)
                   .IsRequired();

            builder.HasMany(m => m.EstudanteNotas)
                   .WithOne(en => en.Matricula)
                   .HasForeignKey(m => m.MatriculaId)
                   .HasPrincipalKey(pk => pk.Id)
                   .IsRequired();

            builder.Property(k => k.Id).UseIdentityColumn();

            builder.Property(m => m.Concluido).HasColumnType("bit").IsRequired();
            builder.Property(m => m.Media).HasColumnType("float").IsRequired();
            builder.Property(m => m.DataConclusao).HasColumnType("datetime");
            builder.Property(m => m.DataInicio).HasColumnType("datetime");
            builder.Property(m => m.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
        }
    }
}
