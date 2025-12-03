using ApplicacionClientComments.cs.Repository;
using Damain.ClientComments.cs.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceClientComments.Api
{
    public class ProductApiRepository : IProductsApiRepository
    {
        private readonly IConfiguration _configuaration;
        private readonly ILogger<ProductApiRepository> _logger; 
        private readonly string _url = string.Empty;    
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductApiRepository(IConfiguration configuaration,
            ILogger<ProductApiRepository> logger,
            IHttpClientFactory httpClientFactory)
        {
            _configuaration = configuaration;
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _url = _configuaration["ApiSettings:BaseUrl"]!;
        }
        public async Task<IEnumerable<Products>> GetAllProductsAsync()
        {  
            var products = new List<Products>();

            _logger.LogInformation("Getting the Products from the Api");
            try
            {
                var client = _httpClientFactory.CreateClient("ProductApi");
                client.BaseAddress = new Uri(_url);
                var request = await client.GetAsync("api/ProductApi/GetAllProducts");
                if(request.IsSuccessStatusCode)
                {
                    var content = await request.Content.ReadFromJsonAsync<List<Products>>();
                    if(content != null) { products = content.ToList(); }
                }

                _logger.LogInformation("products are sucefully done ");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error type {ex.Message.ToString()} ");
                products = null!;
            } 


            return products;
        }
    }
}
