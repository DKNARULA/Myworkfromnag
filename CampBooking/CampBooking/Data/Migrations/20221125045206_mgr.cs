using Microsoft.EntityFrameworkCore.Migrations;

namespace CampBooking.Data.Migrations
{
    public partial class mgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "bookingTables",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bookingTables",
                newName: "id");
        }
    }
}
