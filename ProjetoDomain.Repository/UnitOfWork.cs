using ProjetoDomain.Repository.Context;
using ProjetoDomain.Repository.Interfaces;
using ProjetoDomain.Repository.Repositories;

namespace ProjetoDomain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjetoDDDContext _context;
        public ICustomerRepository Customers { get; }
        public IEnderecoRepository Endereco { get; }

        public UnitOfWork(ProjetoDDDContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Endereco = new EnderecoRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
