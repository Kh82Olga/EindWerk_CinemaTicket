using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class imdball : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0089217/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0001691/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0461136/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0000614/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0000179/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm1519666/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0283945/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0202603/bio?ref_=nm_ql_1");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Imdb",
                value: "https://www.imdb.com/name/nm0000307/bio?ref_=nm_ql_1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Imdb",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Imdb",
                value: null);
        }
    }
}
