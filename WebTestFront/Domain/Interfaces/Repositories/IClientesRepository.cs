
using Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IClientesRepository : IRepositoryBase<ClientesModel>
    {
        Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome);
    }
}
