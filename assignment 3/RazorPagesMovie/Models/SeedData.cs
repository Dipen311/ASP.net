using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Bahubali 2",
                        ReleaseDate = DateTime.Parse("2018-4-20"),
                        Genre = "Drama Action",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Caption America",
                        ReleaseDate = DateTime.Parse("2017-5-10"),
                        Genre = "Action",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Thor",
                        ReleaseDate = DateTime.Parse("2010-8-20"),
                        Genre = "Action Drama",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}