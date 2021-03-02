using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovies.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }
                context.Movie.AddRange(
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romántica",
                    Price = 80M,
                    Rating = "https://i.imgur.com/KDlZx3G.jpg"
                },
                new Movie
                {
                    Title = "Iron Man",
                    ReleaseDate = DateTime.Parse("2008-5-2"),
                    Genre = "Acción",
                    Price = 90M,
                    Rating = "https://i.imgur.com/xdBB2H6.jpg"
                },
                new Movie
                {
                    Title = "Iron Man 2",
                    ReleaseDate = DateTime.Parse("2012-5-7"),
                    Genre = "Acción",
                    Price = 100M,
                    Rating = "https://i.imgur.com/eoAMNWH.jpg"
                },
                new Movie
                {
                    Title = "Django sin cadenas",
                    ReleaseDate = DateTime.Parse("2012-12-25"),
                    Genre = "Western",
                    Price = 85M,
                    Rating = "https://i.imgur.com/yoSbETN.jpg"
                },
                new Movie
                {
                    Title = "Madagascar",
                    ReleaseDate = DateTime.Parse("2005-5-27"),
                    Genre = "Animación",
                    Price = 45M,
                    Rating = "https://i.imgur.com/K7TohKr.jpg"
                },
                new Movie
                {
                    Title = "Rápido y Furioso",
                    ReleaseDate = DateTime.Parse("2001-6-22"),
                    Genre = "Acción",
                    Price = 67M,
                    Rating = "https://i.imgur.com/wVPeSN3.jpg"
                },
                new Movie
                {
                    Title = "Harry Potter y la piedra filosofal",
                    ReleaseDate = DateTime.Parse("2001-11-16"),
                    Genre = "Aventuras",
                    Price = 72M,
                    Rating = "https://i.imgur.com/2wPey1Z.jpg"
                },
                new Movie
                {
                    Title = "Cars",
                    ReleaseDate = DateTime.Parse("2006-6-9"),
                    Genre = "Animación",
                    Price = 49M,
                    Rating = "https://i.imgur.com/NCTfNjf.jpg"
                },
                new Movie
                {
                    Title = "Minions",
                    ReleaseDate = DateTime.Parse("2015-7-10"),
                    Genre = "Animación",
                    Price = 55M,
                    Rating = "https://i.imgur.com/vCgqwUz.jpg"
                }
                );
                context.SaveChanges();
            }
        }
    }
}
