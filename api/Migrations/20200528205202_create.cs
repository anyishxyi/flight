using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Flight_flightid",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_userid",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Flight_flightid",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_User_userid",
                table: "Seat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flight",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Flight");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Seat",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "flightid",
                table: "Seat",
                newName: "FlightID");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_userid",
                table: "Seat",
                newName: "IX_Seat_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_flightid",
                table: "Seat",
                newName: "IX_Seat_FlightID");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Reservation",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "flightid",
                table: "Reservation",
                newName: "FlightID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_userid",
                table: "Reservation",
                newName: "IX_Reservation_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_flightid",
                table: "Reservation",
                newName: "IX_Reservation_FlightID");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "User",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "FlightID",
                table: "Flight",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flight",
                table: "Flight",
                column: "FlightID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Flight_FlightID",
                table: "Reservation",
                column: "FlightID",
                principalTable: "Flight",
                principalColumn: "FlightID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserID",
                table: "Reservation",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Flight_FlightID",
                table: "Seat",
                column: "FlightID",
                principalTable: "Flight",
                principalColumn: "FlightID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_User_UserID",
                table: "Seat",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Flight_FlightID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Flight_FlightID",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_User_UserID",
                table: "Seat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flight",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FlightID",
                table: "Flight");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Seat",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "FlightID",
                table: "Seat",
                newName: "flightid");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_UserID",
                table: "Seat",
                newName: "IX_Seat_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_FlightID",
                table: "Seat",
                newName: "IX_Seat_flightid");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Reservation",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "FlightID",
                table: "Reservation",
                newName: "flightid");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UserID",
                table: "Reservation",
                newName: "IX_Reservation_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_FlightID",
                table: "Reservation",
                newName: "IX_Reservation_flightid");

            migrationBuilder.AddColumn<long>(
                name: "id",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "id",
                table: "Flight",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flight",
                table: "Flight",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Flight_flightid",
                table: "Reservation",
                column: "flightid",
                principalTable: "Flight",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_userid",
                table: "Reservation",
                column: "userid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Flight_flightid",
                table: "Seat",
                column: "flightid",
                principalTable: "Flight",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_User_userid",
                table: "Seat",
                column: "userid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
