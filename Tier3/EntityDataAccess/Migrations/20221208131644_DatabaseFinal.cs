using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDataAccess.Migrations
{
    public partial class DatabaseFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "User",
                type: "INTEGER",
                nullable: false,    
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    NoOfLikes = table.Column<int>(type: "INTEGER", nullable: true),
                    NoOfIngredients = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    RecipeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RateScore = table.Column<int>(type: "INTEGER", nullable: false),
                    RateOfRecipeId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatedByUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Recipes_RateOfRecipeId",
                        column: x => x.RateOfRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_User_RatedByUserId",
                        column: x => x.RatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Response = table.Column<bool>(type: "INTEGER", nullable: false),
                    RequestedByUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeRequests_Recipes_Id",
                        column: x => x.Id,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeRequests_User_RequestedByUserId",
                        column: x => x.RequestedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RatedByUserId",
                table: "Ratings",
                column: "RatedByUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RateOfRecipeId",
                table: "Ratings",
                column: "RateOfRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeRequests_RequestedByUserId",
                table: "RecipeRequests",
                column: "RequestedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "RecipeRequests");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "User");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Role", "Username" },
                values: new object[] { 1, "alex@gmai.com", "1234", "Admin", "Alex" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Role", "Username" },
                values: new object[] { 2, "bp@gmail.com", "pass", "Admin", "Bhupas" });
        }
    }
}
