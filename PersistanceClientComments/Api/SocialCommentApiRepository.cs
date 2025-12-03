using ApplicacionClientComments.cs.Repository;
using Damain.ClientComments.cs.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace PersistanceClientComments.Api
{
    public class SocialCommentApiRepository : ISocialComments
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<SocialCommentApiRepository> _logger;
        private readonly string _url = string.Empty;
        private readonly IHttpClientFactory _httpfactory;

        public SocialCommentApiRepository(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            ILogger<SocialCommentApiRepository> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _url = _configuration.GetValue<string>("ApiSettings:BaseUrl")!;

            _httpfactory = httpClientFactory;
        }

        public async Task<IEnumerable<SocialComments>> GetAllCommentsAsync()
        {

            var ls = new List<SocialComments>();
            try
            {
                var client = _httpfactory.CreateClient();
                client.BaseAddress = new Uri(_url);
                var request = await client.GetAsync("comments"); // algo temporal

                if (request.IsSuccessStatusCode)
                {
                    var content = await request.Content.ReadFromJsonAsync<List<SocialComments>>();
                    if (content != null) { ls = content.ToList(); }
                    _logger.LogInformation("Social Comment succefully list it ");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting comments: {ex.Message}");
                 ls = null!;
            }

            return ls;
        }
    }
}
