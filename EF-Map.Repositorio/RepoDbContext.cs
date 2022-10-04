using EF_Map.Models.Entity;
using EF_Map.Repositorio.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EF_Map.Repositorio
{
    public class RepoDbContext : DbContext
    {
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<Estudante> Estudante { get; set; }
        public DbSet<EstudanteNota> EstudanteNota { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<CursoMateria> CursoMateria { get; set; }
        public DbSet<ProfessorCurso> ProfessorCurso { get; set; }
        public DbSet<ProfessorMateria> ProfessorMateria { get; set; }

        public RepoDbContext(DbContextOptions<RepoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MateriaMap());
            builder.ApplyConfiguration(new ProfessorMap());
            builder.ApplyConfiguration(new CursoMap());
            builder.ApplyConfiguration(new DocumentoMap());
            builder.ApplyConfiguration(new EstudanteMap());
            builder.ApplyConfiguration(new MatriculaMap());
            builder.ApplyConfiguration(new EstudanteNotaMap());
            builder.ApplyConfiguration(new CursoMateriaMap());
            builder.ApplyConfiguration(new ProfessorMateriaMap());
            builder.ApplyConfiguration(new ProfessorCursoMap());

        }

    }
}
