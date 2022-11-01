using GerenciadorDeRendaDomain.Entidades;
using GerenciadorDeRendaDomain.Interfaces;
using GerenciadorDeRendaInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeRendaInfra.Repository
{
    public class RepositoryConta : IRepositoryConta
    {
        private readonly AppDbContext _Context;
        private DbSet<Conta> _Conta;
        public RepositoryConta(AppDbContext context, DbSet<Conta> conta)
        {
            _Context = context;
            _Conta = conta;
        }

        public void Add(Conta conta)
        {
            try
            {
                _Conta.Add(conta);
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
