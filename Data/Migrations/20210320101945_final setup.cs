using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Nutrition.Data.Migrations
{
    public partial class finalsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCalories",
                table: "FoodModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalCalories",
                table: "FoodModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
