using System.Collections.Generic;
using ProjetoDDD.Domain.Domain;

namespace ProjetoDomain.Service.Interfaces
{
    public interface IEnderecoService
    {
        void AddEndereco(Endereco customer);
        void DeleteEndereco(Endereco customer);
        IEnumerable<Endereco> ListEndereco();
        Endereco ListEnderecoById(int id);
    }
}
