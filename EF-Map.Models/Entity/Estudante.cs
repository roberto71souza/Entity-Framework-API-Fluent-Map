using System;
using System.Collections.Generic;

namespace EF_Map.Models.Entity
{
    public class Estudante
    {
        public int Id { get; set; }
        public string NomeEstudante { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataCadastro { get; private set; }
        public List<Documento> Documentos { get; set; }
        public List<Matricula> Matriculas { get; set; }

        public Estudante(int id, string nomeEstudante, int idade, DateTime dataNascimento)
        {
            Id = id;
            NomeEstudante = nomeEstudante;
            Idade = idade;
            DataNascimento = dataNascimento;
        }
    }
}
