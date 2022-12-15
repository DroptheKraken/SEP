using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityDataAccess;

public class DatabaseAccess : DbContext
{
    public DbSet<User>?Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    // public DbSet<RecipeIngredient> RecipeIngredients { get; set; }  // not a bad idea... 
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<RecipeRequest> RecipeRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // https://github.com/TroelsMortensen/EFCpostgres
        optionsBuilder.UseSqlite("Data Source= ../EntityDataAccess/sep3db.db");
        base.OnConfiguring(optionsBuilder);
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        /*modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "Alex",
                Email = "alex@gmai.com",
                Password = "1234",
                Role = "Admin"
            },
            new User
            {
                Id = 2,
                Username = "Bhupas",
                Email = "bp@gmail.com",
                Password = "pass",
                Role = "Admin"
            }
        );*/
        // Constraints, Primary keys, Foreign keys, etc.
        // User
        modelBuilder.Entity<User>().HasKey(user => user.Id);
        
        // Recipe  
        modelBuilder.Entity<Recipe>().HasKey(recipe => recipe.Id);
        modelBuilder.Entity<Recipe>().HasMany(rating => rating.Ratings);
        /*
        modelBuilder.Entity<Recipe>()
            .HasMany(recipe => recipe.Ingredients)
            .WithOne(ingredient => ingredient.Recipe)
            .HasForeignKey(fk => fk.RecipeId);
            */
       
        // RecipeRequest
        // modelBuilder.Entity<RecipeRequest>().HasKey(r => r.Id);
        modelBuilder.Entity<RecipeRequest>().ToTable("RecipeRequests"); //inherited from Recipe
     
        // Ingredient
        modelBuilder.Entity<Ingredient>().HasKey(ingredient => ingredient.Id);
        
        // Rating
        modelBuilder.Entity<Rating>()
            .HasOne(rating => rating.RateOfRecipe)
            .WithMany(recipe => recipe.Ratings);
    }

    /*public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Description> Descriptions { get; set; }
    public DbSet<Rating> Ratings { get; set; }*/

}