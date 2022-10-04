namespace EF_Map.Models.Entity
{
    public class ProfessorMateria
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

        public ProfessorMateria(int professorId, int materiaId)
        {
            ProfessorId = professorId;
            MateriaId = materiaId;
        }
    }
}
