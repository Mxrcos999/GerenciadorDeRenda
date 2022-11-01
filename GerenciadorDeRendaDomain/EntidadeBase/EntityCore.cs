using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeRendaDomain.EntidadeBase
{
    public class EntityCore
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
