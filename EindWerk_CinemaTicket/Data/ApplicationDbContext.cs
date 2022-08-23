using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EindWerk_CinemaTicket.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData
                (
                new Genre { GenreId = 1, GenreName = "Action"},
                new Genre { GenreId = 2, GenreName = "Comedy"},
                new Genre { GenreId = 3, GenreName = "Drama"},
                new Genre { GenreId = 4, GenreName = "Fantasy"},
                new Genre { GenreId = 5, GenreName = "Horror"},
                new Genre { GenreId = 6, GenreName = "Thriller"},
                new Genre { GenreId = 7, GenreName = "Western"},
                new Genre { GenreId = 8, GenreName = "Romantic"},
                new Genre { GenreId = 9, GenreName = "Family"},
                new Genre { GenreId = 10, GenreName = "Cartoon"}
                );
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaSeat> CinemaSeats { get; set; }
        public DbSet<TicketOrder> TicketOrders { get; set; }
        public DbSet<Timetable> Timetables { get; set; }

    }
}
