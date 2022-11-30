using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityDataAccess;

public class DatabaseAccess : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // https://github.com/TroelsMortensen/EFCpostgres
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=sep3db; Username=postgres; Password=postgres;");
        base.OnConfiguring(optionsBuilder);
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
        
        // Constraints, Primary keys, Foreign keys, etc.
        modelBuilder.Entity<User>().HasKey(user => user.Id);
        modelBuilder.Entity<User>().Property(user => user.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Recipe>().HasKey(recipe => recipe.Id);
        modelBuilder.Entity<Recipe>().Property(recipe => recipe.Id).ValueGeneratedOnAdd();
    }
    
    public DbSet<User>Users { get; set; }

    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Description> Descriptions { get; set; }
    public DbSet<Rating> Ratings { get; set; }

}