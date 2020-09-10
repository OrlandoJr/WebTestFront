
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClientesAppService : AppServiceBase<ClientesModel>, IClientesAppService
    {
        private readonly IClientesService _serviceBase;

        public ClientesAppService(IClientesService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome)
        {
            return await _serviceBase.GetByNameAsync(Nome);
        }
    }
}
