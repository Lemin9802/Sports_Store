using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Paddleboard",
                        Description = "Great for core workouts",
                        Category = "Watersports",
                        Price = 399
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    },
                    new Product
                    {
                        Name = "Wooden Chess Set",
                        Description = "Classic wooden chess set",
                        Category = "Chess",
                        Price = 59.95m
                    },
                    new Product
                    {
                        Name = "Marble Chess Set",
                        Description = "Elegant marble chess set",
                        Category = "Chess",
                        Price = 79.99m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "Official size and weight",
                        Category = "Soccer",
                        Price = 19.99m
                    },
                    new Product
                    {
                        Name = "Soccer Cleats",
                        Description = "Professional-grade cleats",
                        Category = "Soccer",
                        Price = 129.95m
                    },
                    new Product
                    {
                        Name = "Soccer Goal",
                        Description = "Portable soccer goal",
                        Category = "Soccer",
                        Price = 89.99m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
