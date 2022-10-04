namespace EF_Map.Models.Entity
{
    public class CursoMateria
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

        public CursoMateria(int cursoId, int materiaId)
        {
            CursoId = cursoId;
            MateriaId = materiaId;
        }
    }
}
