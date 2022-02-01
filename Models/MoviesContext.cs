using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MoviesContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
            //Leave blank for now
        }

        public Microsoft.EntityFrameworkCore.DbSet<AddMovies> Responses { get; set; }

        //Seed the database with at least three of your favorite movies.
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovies>().HasData(

                new AddMovies
                {
                    MovieId = 1,
                    MovieName = "Wall Street",
                    Rating = "G",
                    Edit = "Yes",
                    LentTo = "Shaun",
                    Notes = "This Movie is the best."

                },
                new AddMovies
                {
                    MovieId = 2,
                    MovieName = "Spriderman: No way home",
                    Rating = "PG",
                    Edit = "Yes",
                    LentTo = "Shaun",
                    Notes = "This Movie is good."

                },
                new AddMovies
                {
                    MovieId = 3,
                    MovieName = "Fat Albert",
                    Rating = "PG",
                    Edit = "Yes",
                    LentTo = "Shaun",
                    Notes = "This Movie is fine."

                }
            );
        }
    }
}
