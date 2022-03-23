using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    public class InMemoryRepository : IRepository
    {
        private readonly ILogger<InMemoryRepository> _logger;
        private List<Genre> _genreList;

        public InMemoryRepository(ILogger<InMemoryRepository> logger)
        {
            _logger = logger;
            _genreList = new List<Genre>()
            {
                new Genre()
                {
                    Id = 1,
                    Name = "Comedy"
                },
                new Genre()
                {
                    Id = 2,
                    Name = "Action"
                }
            };
        }

        public async Task<List<Genre>> GetAllGenres()
        {
            _logger.LogInformation("Executing GetAllGenres");
            await Task.Delay(1);
            return _genreList;
        }

        public Genre GetGenreById(int id)
        {
            return _genreList.FirstOrDefault(x => x.Id == id);
        }

        public void AddGenre(Genre genre)
        {
            genre.Id = _genreList.Max(x => x.Id) + 1;
            _genreList.Add(genre);
        }
    }
}
