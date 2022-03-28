using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MoviesAPI.Entities;
using MoviesAPI.Filter;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly ILogger<GenresController> _logger;

        public GenresController(ILogger<GenresController> logger)
        {
            _logger = logger;
        }

        [HttpGet] // api/genres
        public async Task<ActionResult<List<Genre>>> Get()
        {
            _logger.LogInformation("Getting all the genres");
            return new List<Genre>() { new Genre() { Id = 1, Name = "Drama"}};
        }

        // api/genres/{id}
        [HttpGet("{id:int}", Name="getGenre")]
        public ActionResult<Genre> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genre genre)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genre genre)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
