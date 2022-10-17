using GerenciadorDeRendaDomain.EntidadeBase;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class Conta : EntityCore
    {
        public decimal? Saldo { get; set; }
        public decimal? Saida { get; set; }
        public decimal? Entrada { get; set; }
    }
}
