using GerenciadorDeRendaDomain.EntidadeBase;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class Entrada : EntityCore
    {
        public DateTime DataEntrada { get; set; }
        public string? Descricao { get; set; }
        public Decimal? Valor { get; set; }
        public Conta Conta { get; set; }
    }
}