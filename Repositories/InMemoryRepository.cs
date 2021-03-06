using System.Collections.Generic;
using System.Linq;
using Web_API.Entities;

namespace Web_API.Repositories
{
    public class InMemoryRepository: IRepository
    {
        private List<Genre> _genres;

        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id = 1, Name = "Comedy"},
                new Genre(){Id = 2, Name = "Action"}
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int id)
        {
            return _genres.FirstOrDefault(x => x.Id == id);
        }
    }
}
