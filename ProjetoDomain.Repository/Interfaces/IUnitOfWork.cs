using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }

        int Complete();
    }
}
