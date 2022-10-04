using System;
using System.Collections.Generic;

namespace EF_Map.Models.Entity
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; private set; }
        public List<Matricula> Matriculas { get; set; }
        public List<CursoMateria> CursoMaterias { get; set; }
        public List<ProfessorCurso> ProfessorCursos { get; set; }

        public Curso(int id, string nomeCurso, bool ativo)
        {
            Id = id;
            NomeCurso = nomeCurso;
            Ativo = ativo;
        }
    }
}
