using Damain.ClientComments.cs.Api;
using ReadClientsComments.cs.Models.Entities;


namespace ApplicacionClientComments.cs.Repository
{
    public interface IRepositoryApiClient
    {
        public Task<IEnumerable<Client>> GetAllClientAsync();

    } 
}
