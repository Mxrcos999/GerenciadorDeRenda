using GerenciadorDeRendaDomain.EntidadeBase;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class EntradaConta : EntityCore
    {
        public DateTime? DataEntrada { get; set; }
        public string Descricao { get; set; }
        public Categorias Categoria { get; set; }
        public decimal? Valor { get; set; }
        public string EntidadeCoParticipativa { get; set; }
        public string Tipo { get; set; }

    }
}