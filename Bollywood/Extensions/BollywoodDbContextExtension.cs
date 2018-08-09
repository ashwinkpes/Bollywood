using Bollywood.DataAccess;
using Bollywood.Utilities;
using System.Linq;
using System.Threading.Tasks;

namespace Bollywood.Extensions
{
    public static class BollywoodDbContextExtension
    {
        public static async Task EnsureSeedData(this BollywoodDbContext db)
        {
            if (!db.Movies.Any())
            {
                db.Movies.AddRange(new DbUtility().GetMovies());
                await db.SaveChangesAsync().ConfigureAwait(false);
            }
        }
    }
}
