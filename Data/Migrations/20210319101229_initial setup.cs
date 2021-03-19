using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Nutrition.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Serving = table.Column<string>(nullable: true),
                    CaloriesPerServing = table.Column<int>(nullable: false),
                    TotalCalories = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Protein = table.Column<int>(nullable: false),
                    Carbohydrates = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    Fibre = table.Column<int>(nullable: false),
                    Sugars = table.Column<int>(nullable: false),
                    Sodium = table.Column<int>(nullable: false),
                    Potassium = table.Column<int>(nullable: false),
                    Cholesterol = table.Column<int>(nullable: false),
                    VitaminA = table.Column<int>(nullable: false),
                    VitaminC = table.Column<int>(nullable: false),
                    Calcium = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodModel");
        }
    }
}
