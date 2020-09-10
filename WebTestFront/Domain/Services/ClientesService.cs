using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ClientesService : ServiceBase<ClientesModel>, IClientesService
    {
        private readonly IClientesRepository _repository;

        public ClientesService(IClientesRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome)
        {
            return await _repository.GetByNameAsync(Nome);
        }
    }
}
