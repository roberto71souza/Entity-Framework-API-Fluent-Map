using System;

namespace EF_Map.Models.Entity
{
    public class EstudanteNota
    {
        public int Id { get; set; }
        public double Nota { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataLancamento { get; private set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }

        public EstudanteNota(int id, double nota, string observacao, int materiaId, int matriculaId)
        {
            Id = id;
            Nota = nota;
            Observacao = observacao;
            MateriaId = materiaId;
            MatriculaId = matriculaId;
        }

    }
}
