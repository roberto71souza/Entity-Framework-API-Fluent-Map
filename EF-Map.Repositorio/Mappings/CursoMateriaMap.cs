using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class CursoMateriaMap : IEntityTypeConfiguration<CursoMateria>
    {
        public void Configure(EntityTypeBuilder<CursoMateria> builder)
        {
            builder.ToTable("CursoMateria");

            builder.HasKey(cm => new { cm.CursoId, cm.MateriaId });

            builder.HasOne(c => c.Curso)
                   .WithMany(cm => cm.CursoMaterias)
                   .HasForeignKey(c => c.CursoId)
                   .IsRequired();

            builder.HasOne(m => m.Materia)
                   .WithMany(cm => cm.CursoMaterias)
                   .HasForeignKey(m => m.MateriaId)
                   .IsRequired();

            builder.HasData(new CursoMateria[]{
                new CursoMateria(1,1),
                new CursoMateria(2,2),
                new CursoMateria(1,3),
                new CursoMateria(3,4),
                new CursoMateria(2,5),
                new CursoMateria(3,6),
                new CursoMateria(1,7)
            });
        }
    }
}
