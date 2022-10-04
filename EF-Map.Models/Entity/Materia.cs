using System;
using System.Collections.Generic;

namespace EF_Map.Models.Entity
{
    public class Materia
    {
        public int Id { get; set; }
        public string NomeMateria { get; set; }
        public DateTime? DataCadastro { get; private set; }
        public List<CursoMateria> CursoMaterias { get; set; }
        public List<ProfessorMateria> ProfessorMaterias { get; set; }
        public List<EstudanteNota> EstudanteNotas { get; set; }

        public Materia(int id, string nomeMateria)
        {
            Id = id;
            NomeMateria = nomeMateria;
        }
    }
}
