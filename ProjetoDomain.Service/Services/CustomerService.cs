using System.Collections.Generic;
using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Repository;
using ProjetoDomain.Repository.Context;

namespace ProjetoDomain.Service.Interfaces

{
    public class CustomerService : ICustomerService
    {
        public void AddCustomer(Customer customer)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                unitOfWork.Customers.Add(customer);
                unitOfWork.Complete();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                unitOfWork.Customers.Remove(customer);
                unitOfWork.Complete();
            }
        }

        public Customer ListCustomerById(int id)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetById(id);
            }
        }

        public IEnumerable<Customer> ListCustomers()
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetAll();
            }
        }

        public IEnumerable<Customer> GetBestCustomers(int amountOfCustomers)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetBestCustomers(amountOfCustomers);
            }
        }

        public IEnumerable<Customer> GetFullInformation()
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetFullInformation();
            }
        }

        public IEnumerable<Customer> GetOnlyEntityInformation()
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetOnlyEntityInformation();
            }
        }

        public Customer GetFullInformationById(int id)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Customers.GetFullInformationById(id);
            }
        }
    }
}
