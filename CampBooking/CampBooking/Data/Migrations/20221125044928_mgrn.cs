using Microsoft.EntityFrameworkCore.Migrations;

namespace CampBooking.Data.Migrations
{
    public partial class mgrn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "campid",
                table: "bookingTables",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "campid",
                table: "bookingTables");
        }
    }
}
