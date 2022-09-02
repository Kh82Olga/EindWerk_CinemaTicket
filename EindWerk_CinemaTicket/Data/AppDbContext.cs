using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace EindWerk_CinemaTicket.Data
{
    public class AppDbContext:DbContext
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
                new Genre { GenreKey = 1, GenreName = "Action"},
                new Genre { GenreKey = 2, GenreName = "Comedy"},
                new Genre { GenreKey = 3, GenreName = "Drama"},
                new Genre { GenreKey = 4, GenreName = "Fantasy"},
                new Genre { GenreKey = 5, GenreName = "Horror"},
                new Genre { GenreKey = 6, GenreName = "Thriller"},
                new Genre { GenreKey = 7, GenreName = "Adventure"},
                new Genre { GenreKey = 8, GenreName = "Romantic"},
                new Genre { GenreKey = 9, GenreName = "Family"},
                new Genre { GenreKey = 10, GenreName = "Cartoon"}
                );
            modelBuilder.Entity<CinemaHall>().HasData
               (
               new CinemaHall { CinemaHallId = 1, Name ="4DX", Logo = "/css/images/Logo/4dx.jpg", Description = "Revolutionary cinema technology that puts all your senses into action" },
               new CinemaHall { CinemaHallId = 2, Name ="Laser Ultra", Logo = "/css/images/Logo/laserultra.jpg", Description = "The combination of Dolby Atmos and 4k laser projection"},
               new CinemaHall { CinemaHallId = 3, Name ="IMAX", Logo = "/css/images/Logo/imax.jpg", Description = "More picture. More sound. A visual and sound experience"},
               new CinemaHall { CinemaHallId = 4, Name ="Screen X", Logo = "/css/images/Logo/screenx.jpg", Description = "Panoramic viewing experience by expanding the screen on the side walls"}    
               );
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ActorId = 1, FullName = "Johnny Depp", ProfilePictureURL = "~/css/images/ImgActors/JohnnyDepp.jpg" },
                new Actor { ActorId = 2, FullName = "Orlando Bloom", ProfilePictureURL = "~/css/images/ImgActors/OrlandoBloom.jpg" },
                new Actor { ActorId = 3, FullName = "Geoffrey Rush", ProfilePictureURL = "~/css/images/ImgActors/GeoffreyRush.jpg" },
                new Actor { ActorId = 4, FullName = "Keira Knightley", ProfilePictureURL = "~/css/images/ImgActors/KeiraKnightley.jpg" },
                new Actor { ActorId = 5, FullName = "Alan Rickman", ProfilePictureURL = "~/css/images/ImgActors/AlanRickman.jpg" },
                new Actor { ActorId = 6, FullName = "Jude Law", ProfilePictureURL = "~/css/images/ImgActors/JudeLaw.jpg" },
                new Actor { ActorId = 7, FullName = "Eddie Redmayne", ProfilePictureURL = "~/css/images/ImgActors/EddieRedmayne.jpg" },
                new Actor { ActorId = 8, FullName = "Dan Fogler", ProfilePictureURL = "~/css/images/ImgActors/DanFogler.jpg" },
                new Actor { ActorId = 9, FullName = "Jack Davenport", ProfilePictureURL = "~/css/images/ImgActors/JackDavenport.jpg" },
                new Actor { ActorId = 10, FullName = "Helena Bonham Carter", ProfilePictureURL = "~/css/images/ImgActors/HelenaBCarter.jpg" }

                );
            modelBuilder.Entity<Movie>().HasData
                (
                new Movie
                {
                    MovieId = 1,
                    MovieName = "Fantastic Beasts: The Crimes of Grindelwald",
                    Description = "The second installment of the Fantastic Beasts series featuring the adventures of Magizoologist Newt Scamander.",
                    Image = "~/css/images/FanBeastsGrindewald.jpg",
                    GenreId = 4,
                    CinemaHallId = 1,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 2,
                    MovieName = "Fantastic Beasts and Where to Find Them",
                    Description = "The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.",
                    Image = "~/css/images/FanBeasts1.jpg",
                    GenreId = 4,
                    CinemaHallId = 2,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 3,
                    MovieName = "Pirates of the Caribbean: Dead Man's Chest",
                    Description = "Jack Sparrow races to recover the heart of Davy Jones to avoid enslaving his soul to Jones' service, as other friends and foes seek the heart for their own agenda as well.",
                    Image = "~/css/images/PiratesChest.jpg",
                    GenreId = 7,
                    CinemaHallId = 3,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 4,
                    MovieName = "Pirates of the Caribbean: At World's End",
                    Description = "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.",
                    Image = "~/css/images/PiratesWorldsEnd.jpg",
                    GenreId = 7,
                    CinemaHallId= 4,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 5,
                    MovieName = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    Description = "Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.",
                    Image = "~/css/images/PiratesBlackPearl.jpg",
                    GenreId = 7,
                    CinemaHallId = 1,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 6,
                    MovieName = "Alice Through the Looking Glass",
                    Description = "Alice is appointed to save her beloved Mad Hatter from deadly grief by travelling back to the past, but this means fatally harming Time himself, the noble clockwork man with the device needed to save the Hatter's family from the Red Queen.",
                    Image = "~/css/images/AliceInWonderland.jpg",
                    GenreId = 9,
                    CinemaHallId = 2,
                    Price = 20
                },
                new Movie
                {
                    MovieId = 7,
                    MovieName = "Sweeney Todd: The Demon Barber of Fleet Street",
                    Description = "The legendary tale of a barber who returns from wrongful imprisonment to 1840s London, bent on revenge for the rape and death of his wife, and resumes his trade while forming a sinister partnership with his fellow tenant, Mrs. Lovett.",
                    Image = "~/css/images/SweeneyTodd.jpg",
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

    }
}
