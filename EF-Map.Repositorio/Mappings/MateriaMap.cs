using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class MateriaMap : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("Materia");

            builder.Property(m => m.NomeMateria).HasColumnType("varchar(60)").IsRequired();
            builder.Property(m => m.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");

            builder.HasData(new Materia[] {
                            new Materia(1,"INFO-1"),
                            new Materia(2,"LOG-1") ,
                            new Materia(3,"INFO-2"),
                            new Materia(4,"ADM-1"),
                            new Materia(5,"LOG-2"),
                            new Materia(6,"ADM-2"),
                            new Materia(7,"INFO-3")
                        });
        }
    }
}
