using Microsoft.EntityFrameworkCore.Migrations;

namespace EindWerk_CinemaTicket.Migrations
{
    public partial class carousel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceAdult",
                table: "CinemaSeats");

            migrationBuilder.DropColumn(
                name: "PriceChild",
                table: "CinemaSeats");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "TicketOrders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.InsertData(
                table: "CinemaSeats",
                columns: new[] { "SeatId", "SeatNumber" },
                values: new object[,]
                {
                    { 1, "1A" },
                    { 30, "10C" },
                    { 29, "9C" },
                    { 28, "8C" },
                    { 27, "7C" },
                    { 26, "6C" },
                    { 25, "5C" },
                    { 24, "4C" },
                    { 23, "3C" },
                    { 22, "2C" },
                    { 21, "1C" },
                    { 20, "10B" },
                    { 19, "9B" },
                    { 17, "7B" },
                    { 16, "6B" },
                    { 18, "8B" },
                    { 14, "4B" },
                    { 2, "2A" },
                    { 3, "3A" },
                    { 4, "4A" },
                    { 5, "5A" },
                    { 15, "5B" },
                    { 7, "7A" },
                    { 6, "6A" },
                    { 9, "9A" },
                    { 10, "10A" },
                    { 11, "1B" },
                    { 12, "2B" },
                    { 13, "3B" },
                    { 8, "8A" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "GenreId", "Img", "MovieName" },
                values: new object[,]
                {
                    { 4, "Five assassins aboard a fast moving bullet train find out their missions have something in common.", 6, "~/css/images/Bullet_Train.jpg", "Bullet Train" },
                    { 1, "Professor Albus Dumbledore must assign Newt Scamander and his fellow partners as Grindelwald begins to lead an army to eliminate all Muggles.", 4, "~/css/images/Fantastic_Beasts.jpg", "Fantastic Beasts: The Secrets of Dumbledore" },
                    { 2, "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.", 10, "~/css/images/Minions.jpg", "Minions: The Rise of Gru" },
                    { 3, "Jake Sully lives with his newfound family formed on the planet of Pandora. Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their planet.", 1, "~/css/images/Avatar.jpg", "Avatar: The Way of Water" },
                    { 5, "Biochemist Michael Morbius tries to cure himself of a rare blood disease, but he inadvertently infects himself with a form of vampirism instead.", 5, "~/css/images/Morbius.jpg", "Morbius" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrders_CartId",
                table: "TicketOrders",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOrders_Carts_CartId",
                table: "TicketOrders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrders_Carts_CartId",
                table: "TicketOrders");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_TicketOrders_CartId",
                table: "TicketOrders");

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CinemaSeats",
                keyColumn: "SeatId",
                keyValue: 30);

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

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "TicketOrders");

            migrationBuilder.AddColumn<int>(
                name: "PriceAdult",
                table: "CinemaSeats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceChild",
                table: "CinemaSeats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
