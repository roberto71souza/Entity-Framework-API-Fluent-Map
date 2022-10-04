using EF_Map.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Map.Repositorio.Mappings
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.Property(p => p.NomeProfessor).HasColumnType("varchar(70)").IsRequired();
            builder.Property(p => p.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.Curriculo).HasColumnType("varchar(300)").IsRequired();

            builder.HasData(new Professor[] {
                new Professor(1,"Carlos Massa Lima","Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."),
                new Professor(2,"Melissa Carvalho","It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged."),
                new Professor(3,"Ana de Sezaro Salin","It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."),
                new Professor(4,"Beatriz Alves","It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."),
                new Professor(5,"Jose Olivares","There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable."),
                new Professor(6,"Cassandra Liza ALbuquerque","The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.")});
        }
    }
}
