using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");

            builder.Property(c => c.NomeCurso).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Ativo).HasColumnType("bit");
            builder.Property(c => c.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");

            builder.HasData(new Curso[] {
                new Curso(1,"Informatica para iniciantes",true),
                new Curso(2,"Logistica",true),
                new Curso(3,"Administração",true)
            });
        }
    }
}
