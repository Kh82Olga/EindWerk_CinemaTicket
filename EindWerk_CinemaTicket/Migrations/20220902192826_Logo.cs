using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class Logo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 1,
                column: "Logo",
                value: "~/css/images/Logo/4dx.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 2,
                column: "Logo",
                value: "~/css/images/Logo/laserultra.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 3,
                column: "Logo",
                value: "~/css/images/Logo/imax.jpg");

            migrationBuilder.UpdateData(
                table: "CinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 4,
                column: "Logo",
                value: "~/css/images/Logo/screenx.jpg");
        }
    }
}
