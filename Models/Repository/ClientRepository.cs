using Microsoft.EntityFrameworkCore;
using ReadClientsComments.cs.Models.Context;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

namespace ReadClientsComments.cs.Models.Repository
{
    public class CLientRepository : IClientRepository
    {   

        private readonly StockContext _stockContext;

        public CLientRepository(StockContext stockContext)
        {

            _stockContext = stockContext;

        }

        public async Task<IEnumerable<ViuwClient>> GetAllAsync()
        {
            return await _stockContext.clientes.ToArrayAsync();
        }

        public async Task<ViuwClient> GetValueById(int id)
        {
            return (await _stockContext.clientes.FirstOrDefaultAsync(a => a.IdCliente == id))!;

        }

        public async Task<ViuwClient> PostValuesAsnyc(ViuwClient value)
        {
            var request = _stockContext.clientes.Add(value);
            await _stockContext.SaveChangesAsync();
            return request.Entity;

        }
    }
}
