using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDataAccess.Migrations
{
    public partial class DatabaseFinalV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LikedRecipesIds",
                table: "User",
                newName: "LikedRecipes");
        }

        protected   override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LikedRecipes",
                table: "User",
                newName: "LikedRecipesIds");
        }
    }
}
