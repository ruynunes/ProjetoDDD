using System;

namespace ProjetoDomain.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IEnderecoRepository Endereco { get; }

        int Complete();
    }
}
