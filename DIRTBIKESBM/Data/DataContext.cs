using DIRTBIKESBM.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIRTBIKESBM.Data
{
    public class DataContext : DbContext
    {
        internal object Categories;
        internal IEnumerable<object> MotorCategories;

        public DbSet<UserRegistrationDto> UserRegistrations { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Motor> Motor { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Seed> Seed { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLoginDto> UserLoginDtos { get; set; }
        public DbSet<UserRegistrationDto> UserRegistrationDto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motors>()
                .HasKey(m => m.Id);
        }
    }

    public class Motors
    {
        [Key]
        public int Id { get; set; }
        public int MotorsId { get; set; }
        public int UserId { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public int Kilometers { get; set; }
        public string? EngineSpecifications { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
    internal class DirtBikeCategory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("DirtBike")]
        public int DirtBikeId { get; set; }
        public DirtBike? DirtBike { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
    internal class NewClass
    {
        public object DirtBikeId { get; }
        public object CategoryId { get; }

        public NewClass(object dirtBikeId, object categoryId)
        {
            DirtBikeId = dirtBikeId;
            CategoryId = categoryId;
        }

        public override bool Equals(object? obj)
        {
            return obj is NewClass other &&
                   EqualityComparer<object>.Default.Equals(DirtBikeId, other.DirtBikeId) &&
                   EqualityComparer<object>.Default.Equals(CategoryId, other.CategoryId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DirtBikeId, CategoryId);
        }
    }
}