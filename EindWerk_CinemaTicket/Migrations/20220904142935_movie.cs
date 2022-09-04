using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Movies_MovieId",
                table: "ActorMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/JohnnyDepp.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaHallId", "Description", "GenreId", "Image", "MovieName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "The second installment of the Fantastic Beasts series featuring the adventures of Magizoologist Newt Scamander.", 4, "https://www.imdb.com/title/tt4123430/mediaviewer/rm3528093952/?ref_=tt_ov_i", "Fantastic Beasts: The Crimes of Grindelwald", 20.0 },
                    { 2, 2, "The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.", 4, "/images/FanBeasts1.jpg", "Fantastic Beasts and Where to Find Them", 20.0 },
                    { 3, 3, "Jack Sparrow races to recover the heart of Davy Jones to avoid enslaving his soul to Jones' service, as other friends and foes seek the heart for their own agenda as well.", 7, "/images/PiratesChest.jpg", "Pirates of the Caribbean: Dead Man's Chest", 20.0 },
                    { 4, 4, "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.", 7, "/images/PiratesWorldsEnd.jpg", "Pirates of the Caribbean: At World's End", 20.0 },
                    { 5, 1, "Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", 7, "/images/PiratesBlackPearl.jpg", "Pirates of the Caribbean: The Curse of the Black Pearl", 20.0 },
                    { 6, 2, "Alice is appointed to save her beloved Mad Hatter from deadly grief by travelling back to the past, but this means fatally harming Time himself, the noble clockwork man with the device needed to save the Hatter's family from the Red Queen.", 9, "/images/AliceInWonderland.jpg", "Alice Through the Looking Glass", 20.0 },
                    { 7, 3, "The legendary tale of a barber who returns from wrongful imprisonment to 1840s London, bent on revenge for the rape and death of his wife, and resumes his trade while forming a sinister partnership with his fellow tenant, Mrs. Lovett.", 5, "/images/SweeneyTodd.jpg", "Sweeney Todd: The Demon Barber of Fleet Street", 20.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Movies_MovieId",
                table: "ActorMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Movies_MovieId",
                table: "ActorMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieId");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePictureURL",
                value: "https://en.wikipedia.org/wiki/File:Johnny_Depp_2020.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CinemaHallId", "Description", "GenreId", "Image", "MovieName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "The second installment of the Fantastic Beasts series featuring the adventures of Magizoologist Newt Scamander.", 4, "https://www.imdb.com/title/tt4123430/mediaviewer/rm3528093952/?ref_=tt_ov_i", "Fantastic Beasts: The Crimes of Grindelwald", 20.0 },
                    { 2, 2, "The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.", 4, "/images/FanBeasts1.jpg", "Fantastic Beasts and Where to Find Them", 20.0 },
                    { 3, 3, "Jack Sparrow races to recover the heart of Davy Jones to avoid enslaving his soul to Jones' service, as other friends and foes seek the heart for their own agenda as well.", 7, "/images/PiratesChest.jpg", "Pirates of the Caribbean: Dead Man's Chest", 20.0 },
                    { 4, 4, "Captain Barbossa, Will Turner and Elizabeth Swann must sail off the edge of the map, navigate treachery and betrayal, find Jack Sparrow, and make their final alliances for one last decisive battle.", 7, "/images/PiratesWorldsEnd.jpg", "Pirates of the Caribbean: At World's End", 20.0 },
                    { 5, 1, "Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", 7, "/images/PiratesBlackPearl.jpg", "Pirates of the Caribbean: The Curse of the Black Pearl", 20.0 },
                    { 6, 2, "Alice is appointed to save her beloved Mad Hatter from deadly grief by travelling back to the past, but this means fatally harming Time himself, the noble clockwork man with the device needed to save the Hatter's family from the Red Queen.", 9, "/images/AliceInWonderland.jpg", "Alice Through the Looking Glass", 20.0 },
                    { 7, 3, "The legendary tale of a barber who returns from wrongful imprisonment to 1840s London, bent on revenge for the rape and death of his wife, and resumes his trade while forming a sinister partnership with his fellow tenant, Mrs. Lovett.", 5, "/images/SweeneyTodd.jpg", "Sweeney Todd: The Demon Barber of Fleet Street", 20.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Movies_MovieId",
                table: "ActorMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
