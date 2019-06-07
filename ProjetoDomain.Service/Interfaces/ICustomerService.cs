using System.Collections.Generic;
using ProjetoDDD.Domain.Domain;

namespace ProjetoDomain.Service.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        IEnumerable<Customer> ListCustomers();
        Customer ListCustomerById(int id);
        IEnumerable<Customer> GetBestCustomers(int amountOfCustomers);
        IEnumerable<Customer> GetFullInformation();
        IEnumerable<Customer> GetOnlyEntityInformation();
    }
}
