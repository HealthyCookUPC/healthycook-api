using HealthyCook_Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeRating> RecipeRatings { get; set; }
        public DbSet<RecipeDetails> RecipeDetails { get; set; }
        public DbSet<RecipesSaved> RecipesSaveds { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantOwner> RestaurantOwners { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
        public DbSet<IngredientType> IngredientTypes { get; set; }
        public DbSet<ExcludedIngredients> ExcludedIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ConsultasAyuda> Consulta { get; set; }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<Followers> Followers{ get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Followers>()
            .HasOne(s => s.User)
            .WithMany(u => u.Followers)
            .HasForeignKey(s => s.UserID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Followers>()
                .HasOne(s => s.FollowedUser)
                .WithMany(u => u.Followeds)
                .HasForeignKey(s => s.FollowedUserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
