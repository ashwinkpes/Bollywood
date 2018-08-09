using Bollywood.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bollywood.DataAccess.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovies();
        Task<Movie> GetMovieById(int id);
    }
}
