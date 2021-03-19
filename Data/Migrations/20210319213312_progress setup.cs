using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Nutrition.Data.Migrations
{
    public partial class progresssetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProgress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    WaistMeasurements = table.Column<double>(nullable: false),
                    ArmMeasurements = table.Column<double>(nullable: false),
                    LegMeasurements = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgress", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProgress");
        }
    }
}
