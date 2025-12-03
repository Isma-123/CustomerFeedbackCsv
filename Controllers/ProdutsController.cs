using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

namespace ReadClientsComments.cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutsController : ControllerBase
    {

        private readonly IProductsRepository _productrepository;
        public ProdutsController(IProductsRepository productrepository)
        {
            _productrepository = productrepository;
        }


        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> Get()
        {
            var request = await _productrepository.GetAllAsync();
            if (request is null) return BadRequest(request);
            return Ok(request);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var request = await _productrepository.GetValueById(id);
            if (request is null) return BadRequest(request);
            return Ok(request);
        }

        [HttpPost("PostProduct")]
        public async Task<IActionResult> Post([FromBody] ViuwProducts product)
        {
            var request = await _productrepository.PostValuesAsnyc(product);
            if (request is null) return BadRequest(request);
            return Ok(request);

        }

    }
}
