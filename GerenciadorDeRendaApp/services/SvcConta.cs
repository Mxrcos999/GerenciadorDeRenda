using GerenciadorDeRendaApp.Interfaces;
using GerenciadorDeRendaDomain.Entidades;
using GerenciadorDeRendaDomain.Interfaces;

namespace GerenciadorDeRendaApp.services
{
    public class SvcConta : ISvcConta
    {
        private readonly IRepositoryConta _repositoryConta;

        public SvcConta(IRepositoryConta repositoryConta)
        {
            _repositoryConta = repositoryConta;
        }


        public void AdicionaSaldo(Conta conta)
        {
            var result = conta.Entradas.Valor + conta.Saldo;
            var _conta = new Conta(conta.Entradas.Descricao, conta.Entradas.Valor, result);
            _repositoryConta.Add(_conta);

        }
    }
}
