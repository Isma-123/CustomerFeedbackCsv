using Microsoft.EntityFrameworkCore;
using ReadClientsComments.cs.Models.Context;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

namespace ReadClientsComments.cs.Models.Repository
{
    public class ProductRepository : IProductsRepository
    {

        private readonly StockContext _stockcontext;

        public ProductRepository(StockContext stockcontext)
        {
            _stockcontext = stockcontext;
        } 

        public async Task<IEnumerable<ViuwProducts>> GetAllAsync()
        {
           return await _stockcontext.products.ToArrayAsync();
        }

        public async Task<ViuwProducts> GetValueById(int id)
        {
            return (await _stockcontext.products.FirstOrDefaultAsync(a => a.IdProducto == id))!;   
        }

        public async Task<ViuwProducts> PostValuesAsnyc(ViuwProducts value)
        {
            var request = _stockcontext.products.Add(value);    
            await _stockcontext.SaveChangesAsync();
            return request.Entity; 

        }
    }
}
