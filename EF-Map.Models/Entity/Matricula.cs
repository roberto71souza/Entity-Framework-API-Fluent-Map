using System;
using System.Collections.Generic;

namespace EF_Map.Models.Entity
{
    public class Matricula
    {
        public int Id { get; set; }
        public bool Concluido { get; set; }
        public double Media { get; set; }
        public DateTime? DataConclusao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataCadastro { get; private set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<EstudanteNota> EstudanteNotas { get; set; }

        public Matricula(int id, bool concluido, double media, int estudanteId, int cursoId)
        {
            Id = id;
            Concluido = concluido;
            Media = media;
            EstudanteId = estudanteId;
            CursoId = cursoId;
        }

    }
}
