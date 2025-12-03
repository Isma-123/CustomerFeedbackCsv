using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadClientsComments.cs.Models.Entities;
using ReadClientsComments.cs.Models.Interfaces;

namespace ReadClientsComments.cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialController : ControllerBase
    {
        private readonly ISocialCommentsRepository _socialcomments;

        public SocialController(ISocialCommentsRepository socialcomments)
        {
            _socialcomments = socialcomments;
        }

        [HttpGet("GetAllComments")]

        public async Task<IActionResult> Get()
        {

            var request = await _socialcomments.GetAllAsync();
            if (request is not null) return Ok(request);
            return BadRequest(request);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = await _socialcomments.GetValueById(id);
            if (request is not null) return Ok(request);
            return BadRequest(request);
        }

        [HttpPost("PostSocialComment")]
        public async Task<IActionResult> Post([FromBody] ViuwSocialComments obj)
        {
            var request = await _socialcomments.PostValuesAsnyc(obj);
            if (request is not null) return Ok(request);
            return BadRequest(request);
        }
    }
}
