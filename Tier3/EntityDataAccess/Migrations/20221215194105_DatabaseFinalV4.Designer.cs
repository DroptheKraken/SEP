﻿// <auto-generated />
using System;
using EntityDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityDataAccess.Migrations
{
    [DbContext(typeof(DatabaseAccess))]
    [Migration("20221215194105_DatabaseFinalV4")]
    partial class DatabaseFinalV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Domain.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Domain.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateOfRecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatedByUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingId");

                    b.HasIndex("RateOfRecipeId");

                    b.HasIndex("RatedByUserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Domain.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("Description");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Ingredients");

                    b.Property<int?>("NoOfIngredients")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NoOfIngredients");

                    b.Property<int?>("NoOfLikes")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NoOfLikes");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Status");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasColumnName("Title");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasColumnName("Email");

                    b.Property<string>("LikedRecipesIds")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasColumnName("Password");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT")
                        .HasColumnName("Role");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Models.RecipeRequest", b =>
                {
                    b.HasBaseType("Domain.Models.Recipe");

                    b.Property<int>("RequestedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Response")
                        .HasColumnType("INTEGER");

                    b.HasIndex("RequestedByUserId");

                    b.ToTable("RecipeRequests", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Ingredient", b =>
                {
                    b.HasOne("Domain.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Domain.Models.Rating", b =>
                {
                    b.HasOne("Domain.Models.Recipe", "RateOfRecipe")
                        .WithMany("Ratings")
                        .HasForeignKey("RateOfRecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "RatedByUser")
                        .WithMany()
                        .HasForeignKey("RatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RateOfRecipe");

                    b.Navigation("RatedByUser");
                });

            modelBuilder.Entity("Domain.Models.RecipeRequest", b =>
                {
                    b.HasOne("Domain.Models.Recipe", null)
                        .WithOne()
                        .HasForeignKey("Domain.Models.RecipeRequest", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "RequestedByUser")
                        .WithMany()
                        .HasForeignKey("RequestedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestedByUser");
                });

            modelBuilder.Entity("Domain.Models.Recipe", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
