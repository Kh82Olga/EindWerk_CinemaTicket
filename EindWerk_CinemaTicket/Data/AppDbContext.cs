﻿using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EindWerk_CinemaTicket.Data
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovies).HasForeignKey(m => m.ActorId);
            

            modelBuilder.Entity<Genre>().HasData
                (
                new Genre { Id = 1, GenreName = "Action", Description="/images/GenreCards/Action.jpg"},
                new Genre { Id = 2, GenreName = "Comedy", Description = "/images/GenreCards/Comedy.jpg" },
                new Genre { Id = 3, GenreName = "Drama", Description = "/images/GenreCards/Drama.jpg" },
                new Genre { Id = 4, GenreName = "Fantasy", Description = "/images/GenreCards/Fantasy.jpg" },
                new Genre { Id = 5, GenreName = "Horror", Description = "/images/GenreCards/Horror.jpg" },
                new Genre { Id = 6, GenreName = "Crime", Description = "/images/GenreCards/Crime.jpg" },
                new Genre { Id = 7, GenreName = "Romantic", Description = "/images/GenreCards/Romance.jpg" },
                new Genre { Id = 8, GenreName = "Science Fiction", Description = "/images/GenreCards/ScienceFiction.jpg" },
                new Genre { Id = 9, GenreName = "Cartoon", Description = "/images/GenreCards/Cartoon.jpg" }
                );
            modelBuilder.Entity<CinemaHall>().HasData
               (
               new CinemaHall { Id = 1, Name ="4DX", Logo = "/images/Logo/4dx.jpg", Description = "Revolutionary cinema technology that puts all your senses into action" },
               new CinemaHall { Id = 2, Name ="Laser Ultra", Logo = "/images/Logo/laserultra.jpg", Description = "The combination of Dolby Atmos and 4k laser projection"},
               new CinemaHall { Id = 3, Name ="IMAX", Logo = "/images/Logo/imax.jpg", Description = "More picture. More sound. A visual and sound experience"},
               new CinemaHall { Id = 4, Name ="Screen X", Logo = "/images/Logo/screenx.jpg", Description = "Panoramic viewing experience by expanding the screen on the side walls"}    
               );
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FullName = "Johnny Depp", ProfilePictureURL = "/images/ImgActors/JohnnyDepp.jpg", Imdb= "https://www.imdb.com/name/nm0000136/bio?ref_=nm_ov_bio_sm" },
                new Actor { Id = 2, FullName = "Orlando Bloom", ProfilePictureURL = "/images/ImgActors/OrlandoBloom.jpg", Imdb= "https://www.imdb.com/name/nm0089217/bio?ref_=nm_ql_1" },
                new Actor { Id = 3, FullName = "Geoffrey Rush", ProfilePictureURL = "/images/ImgActors/GeoffreyRush.jpg", Imdb = "https://www.imdb.com/name/nm0001691/bio?ref_=nm_ql_1" },
                new Actor { Id = 4, FullName = "Keira Knightley", ProfilePictureURL = "/images/ImgActors/KeiraKnightley.jpg", Imdb = "https://www.imdb.com/name/nm0461136/bio?ref_=nm_ql_1" },
                new Actor { Id = 5, FullName = "Alan Rickman", ProfilePictureURL = "/images/ImgActors/AlanRickman.jpg", Imdb = "https://www.imdb.com/name/nm0000614/bio?ref_=nm_ql_1" },
                new Actor { Id = 6, FullName = "Jude Law", ProfilePictureURL = "/images/ImgActors/JudeLaw.jpg", Imdb = "https://www.imdb.com/name/nm0000179/bio?ref_=nm_ql_1" },
                new Actor { Id = 7, FullName = "Eddie Redmayne", ProfilePictureURL = "/images/ImgActors/EddieRedmayne.jpg", Imdb = "https://www.imdb.com/name/nm1519666/bio?ref_=nm_ql_1" },
                new Actor { Id = 8, FullName = "Dan Fogler", ProfilePictureURL = "/images/ImgActors/DanFogler.jpg", Imdb = "https://www.imdb.com/name/nm0283945/bio?ref_=nm_ql_1" },
                new Actor { Id = 9, FullName = "Jack Davenport", ProfilePictureURL = "/images/ImgActors/JackDavenport.jpg", Imdb = "https://www.imdb.com/name/nm0202603/bio?ref_=nm_ql_1" },
                new Actor { Id = 10, FullName = "Helena Bonham Carter", ProfilePictureURL = "/images/ImgActors/HelenaBCarter.jpg", Imdb = "https://www.imdb.com/name/nm0000307/bio?ref_=nm_ql_1" }

                );
            modelBuilder.Entity<Movie>().HasData
                (
                new Movie
                {
                    Id = 1,
                    MovieName = "Fantastic Beasts: The Crimes of Grindelwald",
                    Description = "The second installment of the Fantastic Beasts series featuring the adventures of Magizoologist Newt Scamander.",
                    Image = "/images/FanBeastsGrindewald.jpg",
                    GenreId = 4,
                    CinemaHallId = 1,
                    Price = 20
                },
                new Movie
                {
                    Id = 2,
                    MovieName = "Fantastic Beasts and Where to Find Them",
                    Description = "The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.",
                    Image = "/images/FanBeasts1.jpg",
                    GenreId = 4,
                    CinemaHallId = 2,
                    Price = 20
                },
                new Movie
                {
                    Id = 3,
                    MovieName = "Pirates of the Caribbean: Dead Man's Chest",
                    Description = "Jack Sparrow races to recover the heart of Davy Jones to avoid enslaving his soul to Jones' service, as other friends and foes seek the heart for their own agenda as well.",
                    Image = "/images/PiratesChest.jpg",
                    GenreId = 1,
                    CinemaHallId = 3,
                    Price = 20
                },
                new Movie
                {
                    Id = 4,
                    MovieName = "Pirates of the Caribbean: At World's End",
                    Description = "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.",
                    Image = "/images/PiratesWorldsEnd.jpg",
                    GenreId = 1,
                    CinemaHallId= 4,
                    Price = 20
                },
                new Movie
                {
                    Id = 5,
                    MovieName = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    Description = "Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.",
                    Image = "/images/PiratesBlackPearl.jpg",
                    GenreId = 1,
                    CinemaHallId = 1,
                    Price = 20
                },
                new Movie
                {
                    Id = 6,
                    MovieName = "Alice Through the Looking Glass",
                    Description = "Alice is appointed to save her beloved Mad Hatter from deadly grief by travelling back to the past, but this means fatally harming Time himself, the noble clockwork man with the device needed to save the Hatter's family from the Red Queen.",
                    Image = "/images/AliceInWonderland.jpg",
                    GenreId = 4,
                    CinemaHallId = 2,
                    Price = 20
                },
                new Movie
                {
                    Id = 7,
                    MovieName = "Sweeney Todd: The Demon Barber of Fleet Street",
                    Description = "The legendary tale of a barber who returns from wrongful imprisonment to 1840s London, bent on revenge for the rape and death of his wife, and resumes his trade while forming a sinister partnership with his fellow tenant, Mrs. Lovett.",
                    Image = "/images/SweeneyTodd.jpg",
                    GenreId = 5,
                    CinemaHallId = 3,
                    Price = 20
                }
                );
            modelBuilder.Entity<ActorMovie>().HasData
              (
              new ActorMovie { ActorId = 1, MovieId = 1 },
              new ActorMovie { ActorId = 7, MovieId = 1 },
              new ActorMovie { ActorId = 8, MovieId = 1 },
              new ActorMovie { ActorId = 6, MovieId = 1 },
              new ActorMovie { ActorId = 1, MovieId = 2 },
              new ActorMovie { ActorId = 7, MovieId = 2 },
              new ActorMovie { ActorId = 8, MovieId = 2 },
              new ActorMovie { ActorId = 1, MovieId = 3 },
              new ActorMovie { ActorId = 2, MovieId = 3 },
              new ActorMovie { ActorId = 4, MovieId = 3 },
              new ActorMovie { ActorId = 9, MovieId = 3 },
              new ActorMovie { ActorId = 1, MovieId = 4 },
              new ActorMovie { ActorId = 2, MovieId = 4 },
              new ActorMovie { ActorId = 3, MovieId = 4 },
              new ActorMovie { ActorId = 4, MovieId = 4 },
              new ActorMovie { ActorId = 9, MovieId = 4 },
              new ActorMovie { ActorId = 1, MovieId = 5 },
              new ActorMovie { ActorId = 2, MovieId = 5 },
              new ActorMovie { ActorId = 3, MovieId = 5 },
              new ActorMovie { ActorId = 4, MovieId = 5 },
              new ActorMovie { ActorId = 9, MovieId = 5 },
              new ActorMovie { ActorId = 1, MovieId = 6 },
              new ActorMovie { ActorId = 10, MovieId = 6 },
              new ActorMovie { ActorId = 5, MovieId = 6 },
              new ActorMovie { ActorId = 1, MovieId = 7 },
              new ActorMovie { ActorId = 10, MovieId = 7 },
              new ActorMovie { ActorId = 5, MovieId = 7 }
              );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


    }
}
