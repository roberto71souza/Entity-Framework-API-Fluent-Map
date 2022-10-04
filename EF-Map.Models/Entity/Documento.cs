using EF_Map.Models.Enum;

namespace EF_Map.Models.Entity
{
    public class Documento
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DocumentoTipo documento { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }

        public Documento(int id, string numero, DocumentoTipo documento, int estudanteId)
        {
            Id = id;
            Numero = numero;
            this.documento = documento;
            EstudanteId = estudanteId;
        }

    }
}
