using Microsoft.EntityFrameworkCore;
using MVC_first_app.Data;

namespace MVC_first_app.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVC_first_appContext(serviceProvider.GetRequiredService<DbContextOptions<MVC_first_appContext>>()))
            {
                if (context.Movie.Any()) return;

                context.Movie.AddRange
                (
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "dumb shit"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "hopeless shit"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "shit"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "fucking shit"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
