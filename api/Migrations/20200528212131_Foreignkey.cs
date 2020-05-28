using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserID",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_UserID",
                table: "Reservation");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_FlightID",
                table: "Reservation",
                column: "FlightID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_FlightID",
                table: "Reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserID",
                table: "Reservation",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserID",
                table: "Reservation",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
