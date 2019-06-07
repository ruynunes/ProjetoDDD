using System.Collections.Generic;
using ProjetoDDD.Domain.Domain;

namespace ProjetoDomain.Repository.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetBestCustomers(int amountOfCustomers);
        IEnumerable<Customer> GetFullInformation();
        IEnumerable<Customer> GetOnlyEntityInformation();
    }
}
