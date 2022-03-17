using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository _repository;

        public GenresController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Genre> Get()
        {
            return _repository.GetAllGenres();
        }

        [HttpGet]
        public Genre Get(int id)
        {
            var genre = _repository.GetGenreById(id);

            if (genre == null)
            {
                //return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
