using ProjetoDDD.Domain.Domain;
using ProjetoDomain.Repository.Context;
using ProjetoDomain.Repository.Interfaces;

namespace ProjetoDomain.Repository.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private readonly ProjetoDDDContext _projetoDDDEntities;

        public EnderecoRepository(ProjetoDDDContext context) : base(context)
        {
            _projetoDDDEntities = context;
        }
    }
}
