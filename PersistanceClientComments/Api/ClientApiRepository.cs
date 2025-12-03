
using ApplicacionClientComments.cs.Repository;
using Damain.ClientComments.cs.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ReadClientsComments.cs.Models.Entities;
using System.Net.Http.Json;
using System.Text.Json;

namespace PersistanceClientComments.Api
{
    public class ClientApiRepository : IRepositoryApiClient
    {

        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ClientApiRepository> _logger;
        private static string _url = string.Empty;


        public ClientApiRepository(
                 IConfiguration configuration,
                 IHttpClientFactory httpClientFactory,
                 ILogger<ClientApiRepository> logger)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _url = _configuration.GetValue<string>("ApiSettings:BaseUrl")!;
        }

        public async Task<IEnumerable<Client>> GetAllClientAsync()
        {
            List<Client> ls = new List<Client>();

            _logger.LogInformation("Looking for the Information");

            try
            {

               using var client = _httpClientFactory.CreateClient("ClientApi");
               client.BaseAddress = new Uri(_url);
               using var response = await client.GetAsync("api/ClientControllers/GetAllClients");
                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<Client>>();
                    if(content != null)
                    {
                        ls = content.ToList();
                        _logger.LogInformation("List of client done succefully!");

                    }
                }
              
            }
            catch (Exception ex)
            {

                ls = null!;
                _logger.LogError($"Error triying to get the value {ex.Message.ToLower()}");
            }
            

            return ls;
        }
    }
}
