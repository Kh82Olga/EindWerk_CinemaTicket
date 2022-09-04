using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class Generic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Actors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Johnny Depp", "https://en.wikipedia.org/wiki/File:Johnny_Depp_2020.jpg" },
                    { 2, "Orlando Bloom", "/images/ImgActors/OrlandoBloom.jpg" },
                    { 3, "Geoffrey Rush", "~/images/ImgActors/GeoffreyRush.jpg" },
                    { 4, "Keira Knightley", "~/images/ImgActors/KeiraKnightley.jpg" },
                    { 5, "Alan Rickman", "~/images/ImgActors/AlanRickman.jpg" },
                    { 6, "Jude Law", "~/images/ImgActors/JudeLaw.jpg" },
                    { 7, "Eddie Redmayne", "~/images/ImgActors/EddieRedmayne.jpg" },
                    { 8, "Dan Fogler", "~/images/ImgActors/DanFogler.jpg" },
                    { 9, "Jack Davenport", "~/images/ImgActors/JackDavenport.jpg" },
                    { 10, "Helena Bonham Carter", "~/images/ImgActors/HelenaBCarter.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 1,
                column: "Logo",
                value: "/images/Logo/4dx.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 2,
                column: "Logo",
                value: "/images/Logo/laserultra.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 3,
                column: "Logo",
                value: "/images/Logo/imax.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 4,
                column: "Logo",
                value: "/images/Logo/screenx.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Image",
                value: "https://www.imdb.com/title/tt4123430/mediaviewer/rm3528093952/?ref_=tt_ov_i");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Image",
                value: "/images/FanBeasts1.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Image",
                value: "~/images/PiratesChest.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Image",
                value: "/images/PiratesWorldsEnd.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Image",
                value: "~/images/PiratesBlackPearl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "Image",
                value: "~/images/AliceInWonderland.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "Image",
                value: "~/images/SweeneyTodd.jpg");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "ActorId");

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

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 1,
                column: "Logo",
                value: "/css/images/Logo/4dx.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 2,
                column: "Logo",
                value: "/css/images/Logo/laserultra.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 3,
                column: "Logo",
                value: "/css/images/Logo/imax.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 4,
                column: "Logo",
                value: "/css/images/Logo/screenx.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Image",
                value: "~/css/images/FanBeastsGrindewald.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Image",
                value: "~/css/images/FanBeasts1.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Image",
                value: "~/css/images/PiratesChest.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Image",
                value: "~/css/images/PiratesWorldsEnd.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Image",
                value: "~/css/images/PiratesBlackPearl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "Image",
                value: "~/css/images/AliceInWonderland.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "Image",
                value: "~/css/images/SweeneyTodd.jpg");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
