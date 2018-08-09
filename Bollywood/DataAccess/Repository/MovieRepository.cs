using Bollywood.DataAccess.Interfaces;
using Bollywood.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bollywood.DataAccess.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private BollywoodDbContext _bollywoodDbContext;

        public MovieRepository(BollywoodDbContext bollywoodDbContext)
        {
            _bollywoodDbContext = bollywoodDbContext;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await _bollywoodDbContext.Movies.ToListAsync().ConfigureAwait(false); 
        }
    }
}
