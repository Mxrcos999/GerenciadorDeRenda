using GerenciadorDeRendaDomain.Interfaces;
using GerenciadorDeRendaInfra.Context;

namespace GerenciadorDeRendaInfra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var sucess = (await _context.SaveChangesAsync()) > 0;
            return sucess;
        }

        public void Dispose() =>
       _context.Dispose();

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
