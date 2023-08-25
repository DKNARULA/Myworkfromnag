using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CampBooking.Data.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "campDetails");

            migrationBuilder.DropColumn(
                name: "capacity",
                table: "bookingTables");

            migrationBuilder.DropColumn(
                name: "name",
                table: "bookingTables");

            migrationBuilder.DropColumn(
                name: "noofDays",
                table: "bookingTables");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "campDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "campName",
                table: "bookingTables",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "checkInDate",
                table: "bookingTables",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "checkOutDate",
                table: "bookingTables",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "noofpeople",
                table: "bookingTables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "campDetailsViewModel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    campName = table.Column<string>(nullable: true),
                    capacity = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    desc = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campDetailsViewModel", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "campDetailsViewModel");

            migrationBuilder.DropColumn(
                name: "price",
                table: "campDetails");

            migrationBuilder.DropColumn(
                name: "campName",
                table: "bookingTables");

            migrationBuilder.DropColumn(
                name: "checkInDate",
                table: "bookingTables");

            migrationBuilder.DropColumn(
                name: "checkOutDate",
                table: "bookingTables");

            migrationBuilder.DropColumn(
                name: "noofpeople",
                table: "bookingTables");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "campDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "bookingTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "bookingTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "noofDays",
                table: "bookingTables",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
