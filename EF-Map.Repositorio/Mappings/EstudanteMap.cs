using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante>
    {
        public void Configure(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("Estudante");

            builder.Property(e => e.NomeEstudante).HasColumnType("varchar(60)").IsRequired();
            builder.Property(e => e.Idade).HasColumnType("int").IsRequired();
            builder.Property(e => e.DataNascimento).HasColumnType("datetime").IsRequired();
            builder.Property(e => e.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
        }
    }
}
