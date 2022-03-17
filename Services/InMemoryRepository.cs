﻿using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genreList;

        public InMemoryRepository()
        {
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

        public List<Genre> GetAllGenres()
        {
            return _genreList;
        }

        public Genre GetGenreById(int id)
        {
            return _genreList.FirstOrDefault(x => x.Id == id);
        }
    }
}