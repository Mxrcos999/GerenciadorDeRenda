using GerenciadorDeRendaDomain.EntidadeBase;

namespace GerenciadorDeRendaDomain.Entidades
{
    public class Categorias : EntityCore
    {
        public string? NomeCategoria { get; set; }
        public string? Descricao { get; set; }
        public List<string>? Compras { get; set; }

    }
}
