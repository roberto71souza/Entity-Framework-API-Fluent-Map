using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class ProfessorCursoMap : IEntityTypeConfiguration<ProfessorCurso>
    {
        public void Configure(EntityTypeBuilder<ProfessorCurso> builder)
        {
            builder.ToTable("ProfessorCurso");

            builder.HasKey(pc => new { pc.ProfessorId, pc.CursoId });

            builder.HasOne(p => p.Professor)
                   .WithMany(pc => pc.ProfessorCursos)
                   .HasForeignKey(p => p.ProfessorId)
                   .IsRequired();

            builder.HasOne(c => c.Curso)
                   .WithMany(pc => pc.ProfessorCursos)
                   .HasForeignKey(c => c.CursoId)
                   .IsRequired();

            builder.HasData(new ProfessorCurso[]{
                        new ProfessorCurso(1, 1),
                        new ProfessorCurso(2, 1),
                        new ProfessorCurso(3, 1),
                        new ProfessorCurso(4, 1),
                        new ProfessorCurso(2, 2),
                        new ProfessorCurso(1, 3),
                        new ProfessorCurso(5, 3)
                    });
        }
    }
}
