using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class CinemaHall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_CinemaHalls_CinemaHallId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls");

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CinemaHallId",
                table: "CinemaHalls");

            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genres",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CinemaHalls",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/GeoffreyRush.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/KeiraKnightley.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/AlanRickman.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/JudeLaw.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/EddieRedmayne.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/DanFogler.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/JackDavenport.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProfilePictureURL",
                value: "/images/ImgActors/HelenaBCarter.jpg");

            migrationBuilder.InsertData(
                table: "CinemaHalls",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Revolutionary cinema technology that puts all your senses into action", "/images/Logo/4dx.jpg", "4DX" },
                    { 2, "The combination of Dolby Atmos and 4k laser projection", "/images/Logo/laserultra.jpg", "Laser Ultra" },
                    { 3, "More picture. More sound. A visual and sound experience", "/images/Logo/imax.jpg", "IMAX" },
                    { 4, "Panoramic viewing experience by expanding the screen on the side walls", "/images/Logo/screenx.jpg", "Screen X" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Image",
                value: "/images/PiratesChest.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Image",
                value: "/images/PiratesBlackPearl.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "Image",
                value: "/images/AliceInWonderland.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "Image",
                value: "/images/SweeneyTodd.jpg");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_CinemaHalls_CinemaHallId",
                table: "Movies",
                column: "CinemaHallId",
                principalTable: "CinemaHalls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_CinemaHalls_CinemaHallId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls");

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CinemaHalls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CinemaHalls");

            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "CinemaHallId",
                table: "CinemaHalls",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CinemaHalls",
                table: "CinemaHalls",
                column: "CinemaHallId");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/GeoffreyRush.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/KeiraKnightley.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/AlanRickman.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/JudeLaw.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/EddieRedmayne.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/DanFogler.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/JackDavenport.jpg");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProfilePictureURL",
                value: "~/images/ImgActors/HelenaBCarter.jpg");

            migrationBuilder.InsertData(
                table: "CinemaHalls",
                columns: new[] { "CinemaHallId", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Revolutionary cinema technology that puts all your senses into action", "/images/Logo/4dx.jpg", "4DX" },
                    { 2, "The combination of Dolby Atmos and 4k laser projection", "/images/Logo/laserultra.jpg", "Laser Ultra" },
                    { 3, "More picture. More sound. A visual and sound experience", "/images/Logo/imax.jpg", "IMAX" },
                    { 4, "Panoramic viewing experience by expanding the screen on the side walls", "/images/Logo/screenx.jpg", "Screen X" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Image",
                value: "~/images/PiratesChest.jpg");

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
                name: "FK_Movies_CinemaHalls_CinemaHallId",
                table: "Movies",
                column: "CinemaHallId",
                principalTable: "CinemaHalls",
                principalColumn: "CinemaHallId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
