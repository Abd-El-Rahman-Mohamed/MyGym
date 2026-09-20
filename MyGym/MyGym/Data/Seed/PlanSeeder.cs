using Microsoft.EntityFrameworkCore;
using MyGym.Models;

namespace MyGym.Data.Seed;

public static class PlanSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        if (await dbContext.Plans.AnyAsync())
            return;
        
        List<Plan> plans = 
        [
            new Plan
            {
                Name = "Free",
                Description = "Basic access with limited features.",
                DurationDays = 30,
                Price = 0m,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Plan
            {
                Name = "Standard",
                Description = "Standard plan for growing stores.",
                DurationDays = 30,
                Price = 29.99m,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Plan
            {
                Name = "Premium",
                Description = "Full access with all features.",
                DurationDays = 30,
                Price = 79.99m,
                IsActive = false,
                CreatedAt = DateTime.UtcNow
            }
        ];

        await dbContext.Plans.AddRangeAsync(plans);
        await dbContext.SaveChangesAsync();
    }
}