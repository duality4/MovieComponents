using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BergstedtMovie.Models
{
    public class BergstedtMovieContext : DbContext
    {
        public BergstedtMovieContext (DbContextOptions<BergstedtMovieContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie { Id = 1, Title = "Titanic", Genre = Genre.Drama, ReleaseDate = DateTime.Parse("1997-05-30"), Rating = 3.0F },
                    new Movie { Id = 2, Title = "Scream", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("2005-07-25"), Rating = 2.3F },
                    new Movie { Id = 3, Title = "The Shining", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("1979-01-30"), Rating = 4.9F }
                );
        }

        public DbSet<BergstedtMovie.Models.Movie> Movie { get; set; }
    }
}
