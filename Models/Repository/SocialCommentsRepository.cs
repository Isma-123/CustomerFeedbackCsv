using Microsoft.EntityFrameworkCore;
using ReadClientsComments.cs.Models.Context;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

namespace ReadClientsComments.cs.Models.Repository
{
    public class SocialCommentsRepository : ISocialCommentsRepository
    {

        private readonly StockContext _stockcontext;

        public SocialCommentsRepository(StockContext stockcontext)
        {
            _stockcontext = stockcontext;
        }
        public async Task<IEnumerable<ViuwSocialComments>> GetAllAsync()
        {
            return await _stockcontext.socialComments.ToArrayAsync();

        }
        public async Task<ViuwSocialComments> GetValueById(int id)
        {
            return (await _stockcontext.socialComments.FirstOrDefaultAsync(a => a.IdComment == id))!;
        }

        public async Task<ViuwSocialComments> PostValuesAsnyc(ViuwSocialComments value)
        {
            var request = _stockcontext.socialComments.Add(value);  
            await _stockcontext.SaveChangesAsync();
            return request.Entity;   

        }
    }
}
