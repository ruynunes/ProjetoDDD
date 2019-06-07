using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Service.Interfaces;

namespace ProjetoDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        // GET api/customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customerService.ListCustomers().ToList();
        }

        // GET api/customer/GetBestCustomers/amountOfCustomers
        [HttpGet("GetBestCustomers/{amountOfCustomers}")]
        public ActionResult<IEnumerable<Customer>> GetBestCustomers(int amountOfCustomers)
        {
            return _customerService.GetBestCustomers(amountOfCustomers).ToList();
        }

        // GET api/customer/GetFullInformation
        [HttpGet("GetFullInformation")]
        public ActionResult<IEnumerable<Customer>> GetFullInformation()
        {
            return _customerService.GetFullInformation().ToList();
        }

        // GET api/customer/GetOnlyEntityInformation
        [HttpGet("GetOnlyEntityInformation")]
        public ActionResult<IEnumerable<Customer>> GetOnlyEntityInformation()
        {
            return _customerService.GetOnlyEntityInformation().ToList();
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _customerService.ListCustomerById(id);
        }

        // POST api/customer
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customerService.AddCustomer(customer);
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customer =_customerService.GetFullInformationById(id);
            _customerService.DeleteCustomer(customer);
        }
    }
}
