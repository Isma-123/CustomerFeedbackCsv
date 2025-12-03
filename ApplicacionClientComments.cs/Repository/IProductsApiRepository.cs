

using Damain.ClientComments.cs.Api;

namespace ApplicacionClientComments.cs.Repository
{
    public interface IProductsApiRepository 
    {
     public Task<IEnumerable<Products>> GetAllProductsAsync();

    }
}
