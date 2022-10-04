using System;
using System.Collections.Generic;

namespace EF_Map.Models.Entity
{
    public class Professor
    {
        public int Id { get; set; }
        public string NomeProfessor { get; set; }
        public DateTime? DataCadastro { get; private set; }
        public string Curriculo { get; set; }
        public List<ProfessorCurso> ProfessorCursos { get; set; }
        public List<ProfessorMateria> ProfessorMaterias { get; set; }

        public Professor(int id, string nomeProfessor, string curriculo)
        {
            Id = id;
            NomeProfessor = nomeProfessor;
            Curriculo = curriculo;
        }
    }
}
