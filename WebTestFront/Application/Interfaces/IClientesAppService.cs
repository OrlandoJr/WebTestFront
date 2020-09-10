using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClientesAppService : IAppServiceBase<ClientesModel>
    {
        Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome);
    }
}
