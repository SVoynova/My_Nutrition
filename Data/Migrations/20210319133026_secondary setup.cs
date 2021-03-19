using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Nutrition.Data.Migrations
{
    public partial class secondarysetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    CurrentWeight = table.Column<int>(nullable: false),
                    GoalWeight = table.Column<int>(nullable: false),
                    ActivityLevel = table.Column<string>(nullable: true),
                    IntensityOfThePlan = table.Column<string>(nullable: true),
                    DailyVitaminA = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
