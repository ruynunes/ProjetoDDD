using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Service.Interfaces;

namespace ProjetoDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController()
        {
            _enderecoService = new EnderecoService();
        }

        // GET api/customer
        [HttpGet]
        public ActionResult<IEnumerable<Endereco>> Get()
        {
            return _enderecoService.ListEndereco().ToList();
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<Endereco> Get(int id)
        {
            return _enderecoService.ListEnderecoById(id);
        }

        // POST api/customer
        [HttpPost]
        public void Post([FromBody] Endereco endereco)
        {
            _enderecoService.AddEndereco(endereco);
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var endereco = _enderecoService.ListEnderecoById(id);
            _enderecoService.DeleteEndereco(endereco);
        }
    }
}
