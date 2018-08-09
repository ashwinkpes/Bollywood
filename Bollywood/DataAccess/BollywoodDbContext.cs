using Bollywood.Models;
using Microsoft.EntityFrameworkCore;

namespace Bollywood.DataAccess
{
    public sealed class BollywoodDbContext : DbContext
    {
        public BollywoodDbContext(DbContextOptions<BollywoodDbContext> options)
          : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
