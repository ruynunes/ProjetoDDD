using System.Collections.Generic;
using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Repository;
using ProjetoDomain.Repository.Context;

namespace ProjetoDomain.Service.Interfaces

{
    public class EnderecoService : IEnderecoService
    {
        public void AddEndereco(Endereco endereco)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                unitOfWork.Endereco.Add(endereco);
                unitOfWork.Complete();
            }
        }

        public void DeleteEndereco(Endereco endereco)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                unitOfWork.Endereco.Remove(endereco);
                unitOfWork.Complete();
            }
        }

        public Endereco ListEnderecoById(int id)
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Endereco.GetById(id);
            }
        }

        public IEnumerable<Endereco> ListEndereco()
        {
            using (var unitOfWork = new UnitOfWork(new ProjetoDDDContext()))
            {
                return unitOfWork.Endereco.GetAll();
            }
        }
    }
}
