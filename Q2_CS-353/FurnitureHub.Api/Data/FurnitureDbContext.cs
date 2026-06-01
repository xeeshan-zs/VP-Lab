using Microsoft.EntityFrameworkCore;
using FurnitureHub.Api.Models;

namespace FurnitureHub.Api.Data
{
    public class FurnitureDbContext : DbContext
    {
        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options)
        {
        }

        public DbSet<FurnitureItem> FurnitureItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Code-First Seed Data
            modelBuilder.Entity<FurnitureItem>().HasData(
                new FurnitureItem { Id = 1, Name = "Luxury Velvet Sofa", Category = "Living Room", Price = 45000, StockQuantity = 15 },
                new FurnitureItem { Id = 2, Name = "Solid Oak Dining Table", Category = "Dining Room", Price = 38000, StockQuantity = 8 },
                new FurnitureItem { Id = 3, Name = "Ergonomic Study Desk", Category = "Office", Price = 12500, StockQuantity = 25 },
                new FurnitureItem { Id = 4, Name = "Classic Wooden Chair", Category = "Dining Room", Price = 4500, StockQuantity = 50 },
                new FurnitureItem { Id = 5, Name = "Triple Door Wardrobe", Category = "Bedroom", Price = 28000, StockQuantity = 12 },
                new FurnitureItem { Id = 6, Name = "Queen Size Bed Frame", Category = "Bedroom", Price = 35000, StockQuantity = 10 },
                new FurnitureItem { Id = 7, Name = "Glass Coffee Table", Category = "Living Room", Price = 9500, StockQuantity = 20 }
            );
        }
    }
}
