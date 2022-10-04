﻿namespace EF_Map.Models.Entity
{
    public class ProfessorCurso
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public ProfessorCurso(int professorId, int cursoId)
        {
            ProfessorId = professorId;
            CursoId = cursoId;
        }
    }
}
