using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web_API.Entities;
using Web_API.Repositories;

namespace Web_API.Controllers
{
    [Route("api/genres")]
    public class GenresController: ControllerBase
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult< List<Genre>> GetAllGenres()
        {
            return repository.GetAllGenres();
        }

        [HttpGet("{id}")]
        public ActionResult<Genre> GetGenreById(int id)
        {
            var genre = repository.GetGenreById(id);

            if(genre == null)
            {
                return NotFound();
            }
            return genre;
        }
    }
}
