using GerenciadorDeRendaDomain.EntidadeBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class Conta : EntityCore
    {
        public Conta(string descricao, decimal? valor, decimal? saldo)
        {
            var entrada = new List<Entrada>()
            {
                new Entrada
                {
                    Valor = valor,
                    Descricao = descricao,
                }
            };
            Saldo = saldo;
        }
        public Conta()
        {

        }
        public decimal? Saldo { get; set; }
        [ForeignKey("SaidaId")]
        public Saida Saidas { get; set; }
        public IEnumerable<Saida> Saida { get; set; }
        [ForeignKey("EntradaId")]

        public Entrada Entradas { get; set; }
        public IEnumerable<Entrada> Entrada { get; set; }
    }
}
