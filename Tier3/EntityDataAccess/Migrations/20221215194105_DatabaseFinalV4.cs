using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDataAccess.Migrations
{
    public partial class DatabaseFinalV4 : Migration
    {
        protected   override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ratings_RatedByUserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "LikedRecipesIds",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RatedByUserId",
                table: "Ratings",
                column: "RatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ratings_RatedByUserId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "LikedRecipesIds",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "User",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RatedByUserId",
                table: "Ratings",
                column: "RatedByUserId",
                unique: true);
        }
    }
}
