using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "CinemaHalls",
                columns: table => new
                {
                    CinemaHallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaHalls", x => x.CinemaHallId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    CinemaHallId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_CinemaHalls_CinemaHallId",
                        column: x => x.CinemaHallId,
                        principalTable: "CinemaHalls",
                        principalColumn: "CinemaHallId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Johnny Depp", "~/css/images/ImgActors/JohnnyDepp.jpg" },
                    { 2, "Orlando Bloom", "~/css/images/ImgActors/OrlandoBloom.jpg" },
                    { 3, "Geoffrey Rush", "~/css/images/ImgActors/GeoffreyRush.jpg" },
                    { 4, "Keira Knightley", "~/css/images/ImgActors/KeiraKnightley.jpg" },
                    { 5, "Alan Rickman", "~/css/images/ImgActors/AlanRickman.jpg" },
                    { 6, "Jude Law", "~/css/images/ImgActors/JudeLaw.jpg" },
                    { 7, "Eddie Redmayne", "~/css/images/ImgActors/EddieRedmayne.jpg" },
                    { 8, "Dan Fogler", "~/css/images/ImgActors/DanFogler.jpg" },
                    { 9, "Jack Davenport", "~/css/images/ImgActors/JackDavenport.jpg" },
                    { 10, "Helena Bonham Carter", "~/css/images/ImgActors/HelenaBCarter.jpg" }
                });

            migrationBuilder.InsertData(
                table: "CinemaHalls",
                columns: new[] { "CinemaHallId", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 4, "Panoramic viewing experience by expanding the screen on the side walls", "~/css/images/Logo/screenx.jpg", "Screen X" },
                    { 3, "More picture. More sound. A visual and sound experience", "~/css/images/Logo/imax.jpg", "IMAX" },
                    { 2, "The combination of Dolby Atmos and 4k laser projection", "~/css/images/Logo/laserultra.jpg", "Laser Ultra" },
                    { 1, "Revolutionary cinema technology that puts all your senses into action", "~/css/images/Logo/4dx.jpg", "4DX" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Fantasy" },
                    { 5, "Horror" },
                    { 6, "Thriller" },
                    { 7, "Adventure" },
                    { 8, "Romantic" },
                    { 9, "Family" },
                    { 10, "Cartoon" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CinemaHallId", "Description", "GenreId", "Image", "MovieName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "The second installment of the Fantastic Beasts series featuring the adventures of Magizoologist Newt Scamander.", 4, "~/css/images/FanBeastsGrindewald.jpg", "Fantastic Beasts: The Crimes of Grindelwald", 20.0 },
                    { 2, 2, "The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.", 4, "~/css/images/FanBeasts1.jpg", "Fantastic Beasts and Where to Find Them", 20.0 },
                    { 7, 3, "The legendary tale of a barber who returns from wrongful imprisonment to 1840s London, bent on revenge for the rape and death of his wife, and resumes his trade while forming a sinister partnership with his fellow tenant, Mrs. Lovett.", 5, "~/css/images/SweeneyTodd.jpg", "Sweeney Todd: The Demon Barber of Fleet Street", 20.0 },
                    { 3, 3, "Jack Sparrow races to recover the heart of Davy Jones to avoid enslaving his soul to Jones' service, as other friends and foes seek the heart for their own agenda as well.", 7, "~/css/images/PiratesChest.jpg", "Pirates of the Caribbean: Dead Man's Chest", 20.0 },
                    { 4, 4, "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.", 7, "~/css/images/PiratesWorldsEnd.jpg", "Pirates of the Caribbean: At World's End", 20.0 },
                    { 5, 1, "Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", 7, "~/css/images/PiratesBlackPearl.jpg", "Pirates of the Caribbean: The Curse of the Black Pearl", 20.0 },
                    { 6, 2, "Alice is appointed to save her beloved Mad Hatter from deadly grief by travelling back to the past, but this means fatally harming Time himself, the noble clockwork man with the device needed to save the Hatter's family from the Red Queen.", 9, "~/css/images/AliceInWonderland.jpg", "Alice Through the Looking Glass", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 6 },
                    { 9, 5 },
                    { 4, 5 },
                    { 3, 5 },
                    { 2, 5 },
                    { 1, 5 },
                    { 9, 4 },
                    { 4, 4 },
                    { 3, 4 },
                    { 2, 4 },
                    { 1, 4 },
                    { 10, 6 },
                    { 9, 3 },
                    { 2, 3 },
                    { 1, 3 },
                    { 5, 7 },
                    { 10, 7 },
                    { 1, 7 },
                    { 8, 2 },
                    { 7, 2 },
                    { 1, 2 },
                    { 6, 1 },
                    { 8, 1 },
                    { 7, 1 },
                    { 4, 3 },
                    { 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_MovieId",
                table: "ActorMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaHallId",
                table: "Movies",
                column: "CinemaHallId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "CinemaHalls");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
