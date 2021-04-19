using MvcMovie.Models;
using System;
using System.Linq;

namespace MvcMovie.Data
{
    public class SeedData
    {
        private readonly MvcMovieContext _context;

        public SeedData(MvcMovieContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Movie.Any())
            {
                return;
            }

            _context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = 3.0,
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = 4.0,
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = 4.5,
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = 5.0,
                    Price = 3.99M
                }
            );

            _context.SaveChanges();
        }

    }
}
