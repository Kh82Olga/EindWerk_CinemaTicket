﻿using EindWerk_CinemaTicket.Models;
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
            modelBuilder.Entity<CinemaSeat>().HasData
               (
               new CinemaSeat { SeatId = 1, SeatNumber = "1A"},
               new CinemaSeat { SeatId = 2, SeatNumber = "2A"},
               new CinemaSeat { SeatId = 3, SeatNumber = "3A"},
               new CinemaSeat { SeatId = 4, SeatNumber = "4A"},
               new CinemaSeat { SeatId = 5, SeatNumber = "5A"},
               new CinemaSeat { SeatId = 6, SeatNumber = "6A"},
               new CinemaSeat { SeatId = 7, SeatNumber = "7A"},
               new CinemaSeat { SeatId = 8, SeatNumber = "8A"},
               new CinemaSeat { SeatId = 9, SeatNumber = "9A"},
               new CinemaSeat { SeatId = 10, SeatNumber = "10A"},
               new CinemaSeat { SeatId = 11, SeatNumber = "1B"},
               new CinemaSeat { SeatId = 12, SeatNumber = "2B"},
               new CinemaSeat { SeatId = 13, SeatNumber = "3B"},
               new CinemaSeat { SeatId = 14, SeatNumber = "4B"},
               new CinemaSeat { SeatId = 15, SeatNumber = "5B"},
               new CinemaSeat { SeatId = 16, SeatNumber = "6B"},
               new CinemaSeat { SeatId = 17, SeatNumber = "7B"},
               new CinemaSeat { SeatId = 18, SeatNumber = "8B"},
               new CinemaSeat { SeatId = 19, SeatNumber = "9B"},
               new CinemaSeat { SeatId = 20, SeatNumber = "10B"},
               new CinemaSeat { SeatId = 21, SeatNumber = "1C"},
               new CinemaSeat { SeatId = 22, SeatNumber = "2C"},
               new CinemaSeat { SeatId = 23, SeatNumber = "3C"},
               new CinemaSeat { SeatId = 24, SeatNumber = "4C"},
               new CinemaSeat { SeatId = 25, SeatNumber = "5C"},
               new CinemaSeat { SeatId = 26, SeatNumber = "6C"},
               new CinemaSeat { SeatId = 27, SeatNumber = "7C"},
               new CinemaSeat { SeatId = 28, SeatNumber = "8C"},
               new CinemaSeat { SeatId = 29, SeatNumber = "9C"},
               new CinemaSeat { SeatId = 30, SeatNumber = "10C"}              
               );
            modelBuilder.Entity<Movie>().HasData
                (
                new Movie 
                { 
                    MovieId = 1, 
                    MovieName = "Fantastic Beasts: The Secrets of Dumbledore", 
                    Description = "Professor Albus Dumbledore must assign Newt Scamander and his fellow partners as Grindelwald begins to lead an army to eliminate all Muggles.", 
                    Img = "~/css/images/Fantastic_Beasts.jpg", 
                    GenreId = 4
                },
                new Movie 
                { 
                    MovieId = 2, 
                    MovieName = "Minions: The Rise of Gru", 
                    Description = "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.", 
                    Img = "~/css/images/Minions.jpg", 
                    GenreId = 10
                },
                new Movie 
                { 
                    MovieId = 3, 
                    MovieName = "Avatar: The Way of Water", 
                    Description = "Jake Sully lives with his newfound family formed on the planet of Pandora. " +
                    "Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their planet.", 
                    Img = "~/css/images/Avatar.jpg", 
                    GenreId = 1
                },
                new Movie 
                { 
                    MovieId = 4, 
                    MovieName = "Bullet Train", 
                    Description = "Five assassins aboard a fast moving bullet train find out their missions have something in common.", 
                    Img = "~/css/images/Bullet_Train.jpg",
                    GenreId = 6
                },
                new Movie 
                { 
                    MovieId = 5, 
                    MovieName = "Morbius", 
                    Description = "Biochemist Michael Morbius tries to cure himself of a rare blood disease, but he inadvertently infects himself with a form of vampirism instead.", 
                    Img = "~/css/images/Morbius.jpg", 
                    GenreId = 5
                }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaSeat> CinemaSeats { get; set; }
        public DbSet<TicketOrder> TicketOrders { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
