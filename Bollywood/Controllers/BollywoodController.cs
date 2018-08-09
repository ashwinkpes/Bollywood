using Bollywood.DataAccess.Interfaces;
using Bollywood.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bollywood.Controllers
{
    [Produces("application/json")]
    [Route("api/Bollywood")]
    public class BollywoodController : Controller
    {
        private readonly IMovieRepository movieRepository;

        public BollywoodController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet]
        [Route("Movies")]
        public async Task<IActionResult> GetMovies()
        {
            var allMovies = await movieRepository.GetAllMovies();
            return Ok(allMovies);
        }

        [HttpGet]
        [Route("GetMovieById/{Id}")]
        public async Task<IActionResult> GetMovies([FromRoute] int Id)
        {

            var movie = await movieRepository.GetMovieById(Id);
            if (movie == null)
            {
                return NotFound($"Movie with {Id} not found!!!");
            }

            return Ok(movie);
        }
    }
}