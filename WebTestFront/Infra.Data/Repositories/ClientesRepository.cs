using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ClientesRepository : RepositoryBase<ClientesModel>, IClientesRepository
    {
        public ClientesRepository(BaseDBContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<ClientesModel>> GetByNameAsync(string Nome)
        {
            return await _context.Clientes.Where(x => x.Nome.Contains(Nome)).ToListAsync();
        }
    }
}
