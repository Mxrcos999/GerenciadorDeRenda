using GerenciadorDeRendaDomain.EntidadeBase;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class Previsao : EntityCore
    {
        public DateTime? ProxEntrada { get; set; }
        public DateTime? ProxSaida { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
    }
}
