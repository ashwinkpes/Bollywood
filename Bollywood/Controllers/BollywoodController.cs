using Bollywood.DataAccess.Interfaces;
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

        public async Task<IActionResult> GetMovies()
        {
            var allMovies = await movieRepository.GetAllMovies();
            return Ok(allMovies);
        }
    }
}