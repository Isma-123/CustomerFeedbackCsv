using Microsoft.AspNetCore.Mvc;
using ReadClientsComments.cs.Models.Context;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadClientsComments.cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientControllers : ControllerBase
    {

        private readonly IClientRepository _clientRepository;  // inyecto mi repositorio a mi api

        public ClientControllers(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet("GetAllClients")]
        public async Task<IActionResult> Get()
        {
           var request = await _clientRepository.GetAllAsync();
           if (request is not null) return Ok(request);
           return BadRequest(request);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = await _clientRepository.GetValueById(id);
            if (request is not null) return Ok(request);
            return BadRequest(request);

        }


        [HttpPost("PostClient")]
        public async Task<IActionResult> Post([FromBody] ViuwClient client)
        {   

            var request = await _clientRepository.PostValuesAsnyc(client);
            if(request is null) return BadRequest(request);
            return Ok(request);

        }


    }
}
