using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityDataAccess;

public class DatabaseAccess : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // https://github.com/TroelsMortensen/EFCpostgres
        optionsBuilder.UseSqlite("Data Source= ../EntityDataAccess/sep3db.db");
        base.OnConfiguring(optionsBuilder);
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
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
            },
            new User
            {
                Username = "Jan",
                Email = "jan@gmail.com",
                Password = "qwer",
                Role = "User"
            }
        );
        
        // Constraints, Primary keys, Foreign keys, etc.
        modelBuilder.Entity<User>().HasKey(user => user.Id);

        /*modelBuilder.Entity<Recipe>().HasKey(recipe => recipe.Id);
        modelBuilder.Entity<Recipe>().Property(recipe => recipe.Id).ValueGeneratedOnAdd();*/
    }
    
    public DbSet<User>Users { get; set; }

    /*public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Description> Descriptions { get; set; }
    public DbSet<Rating> Ratings { get; set; }*/

}