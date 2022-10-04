using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class ProfessorMateriaMap : IEntityTypeConfiguration<ProfessorMateria>
    {
        public void Configure(EntityTypeBuilder<ProfessorMateria> builder)
        {
            builder.HasKey(pm => new { pm.ProfessorId, pm.MateriaId });

            builder.HasOne(p => p.Professor)
                   .WithMany(pm => pm.ProfessorMaterias)
                   .HasForeignKey(p => p.ProfessorId)
                   .IsRequired();

            builder.HasOne(m => m.Materia)
                   .WithMany(pm => pm.ProfessorMaterias)
                   .HasForeignKey(m => m.MateriaId)
                   .IsRequired();

            builder.HasData(new ProfessorMateria[]{
                        new ProfessorMateria(1,2),
                        new ProfessorMateria(1,6),
                        new ProfessorMateria(2,1),
                        new ProfessorMateria(2,2),
                        new ProfessorMateria(2,5),
                        new ProfessorMateria(3,1),
                        new ProfessorMateria(3,2),
                        new ProfessorMateria(3,3),
                        new ProfessorMateria(3,4),
                        new ProfessorMateria(3,5),
                        new ProfessorMateria(3,6),
                        new ProfessorMateria(4,5),
                        new ProfessorMateria(4,4),
                        new ProfessorMateria(5,5),
                        new ProfessorMateria(6,1),
                        new ProfessorMateria(6,4),
                        new ProfessorMateria(6,2)
                    });
        }
    }
}
