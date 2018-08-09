using Bollywood.Models;
using System.Collections.Generic;
using static Bollywood.Enums.BollywoodEnums;

namespace Bollywood.Utilities
{
    public class DbUtility
    {
        public IList<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie
            {
                MovieId = 1,
                MovieName = "Hungama",
                Genre = Genre.Comedy,
                BoxOffice = 12345.65789M,
                ImgSrc = "assets/images/Hungama.jpg",
                ReleaseYear = 1992,
                Description = Constants
                 .MOVIEDESCRIPTION_HUNGAMA,
                Verdict = Verdict.Hit
            });

            movies.Add(new Movie
            {
                MovieId = 2,
                MovieName = "JollyLLB2",
                Genre = Genre.Drama,
                BoxOffice = 1233345.65789M,
                ImgSrc = "assets/images/JollyLLB.jpg",
                ReleaseYear = 1992,
                Description = Constants
                .MOVIEDESCRIPTION_JOLLYLLB,
                Verdict = Verdict.SuperHit
            });

            return movies;
        }
    }
}
