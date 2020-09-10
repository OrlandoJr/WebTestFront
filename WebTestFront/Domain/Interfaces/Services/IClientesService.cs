using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IClientesService : IServiceBase<ClientesModel>
    {
        Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome);
    }
}
