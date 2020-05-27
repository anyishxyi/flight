using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departureDate = table.Column<string>(nullable: true),
                    arrivalDate = table.Column<string>(nullable: true),
                    departureAirport = table.Column<string>(nullable: true),
                    arrivalAirport = table.Column<string>(nullable: true),
                    numberOfSeat = table.Column<int>(nullable: false),
                    hasEscale = table.Column<bool>(nullable: false),
                    flightNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flightid = table.Column<long>(nullable: true),
                    userid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reservation_Flight_flightid",
                        column: x => x.flightid,
                        principalTable: "Flight",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservation_User_userid",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placeNumber = table.Column<int>(nullable: false),
                    isEmpty = table.Column<bool>(nullable: false),
                    userid = table.Column<long>(nullable: true),
                    flightid = table.Column<long>(nullable: true),
                    seatCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seat_Flight_flightid",
                        column: x => x.flightid,
                        principalTable: "Flight",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seat_User_userid",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_flightid",
                table: "Reservation",
                column: "flightid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_userid",
                table: "Reservation",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_flightid",
                table: "Seat",
                column: "flightid");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_userid",
                table: "Seat",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
