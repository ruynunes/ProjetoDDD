using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Repository.Context;
using ProjetoDomain.Repository.Interfaces;

namespace ProjetoDomain.Repository.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ProjetoDDDContext _projetoDDDEntities;

        public CustomerRepository(ProjetoDDDContext context) : base(context)
        {
            _projetoDDDEntities = context;
        }

        public IEnumerable<Customer> GetBestCustomers(int amountOfCustomers)
        {
            return _projetoDDDEntities.Customer.OrderByDescending(x => x.Revenue).Take(amountOfCustomers).ToList();
        }

        public IEnumerable<Customer> GetFullInformation()
        {
            return _projetoDDDEntities.Customer.Include(x => x.Endereco).ToList();
        }

        public IEnumerable<Customer> GetOnlyEntityInformation()
        {
            return _projetoDDDEntities.Customer.ToList();
        }

        public Customer GetFullInformationById(int id)
        {
            return _projetoDDDEntities.Customer.Include(x => x.Endereco).Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}
