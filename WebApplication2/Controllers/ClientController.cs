using ApplicacionClientComments.cs.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ClientController : Controller
    {

        private readonly IRepositoryApiClient _repositoryApiClient; 

        public ClientController(IRepositoryApiClient repositoryApiClient)
        {
            _repositoryApiClient = repositoryApiClient;
        }

        [HttpGet]   
        public async Task<IActionResult> Index()
        {
            var request = _repositoryApiClient.GetAllClientAsync();
            return View(request);
        }
    }
}

