using System.Collections.Generic;
using Web_API.Entities;

namespace Web_API.Repositories
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
    }
}
