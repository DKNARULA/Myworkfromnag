using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CampBooking.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "campDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    campName = table.Column<string>(nullable: true),
                    capacity = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    desc = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bookingTables",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    billAddress = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    pinCode = table.Column<int>(nullable: false),
                    mobile = table.Column<long>(nullable: false),
                    noofDays = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    campDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingTables", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookingTables_campDetails_campDetailsId",
                        column: x => x.campDetailsId,
                        principalTable: "campDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookingTables_campDetailsId",
                table: "bookingTables",
                column: "campDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingTables");

            migrationBuilder.DropTable(
                name: "campDetails");
        }
    }
}
