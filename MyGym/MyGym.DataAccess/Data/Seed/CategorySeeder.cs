using MyGym.DataAccess.Models;
using MyGym.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace MyGym.DataAccess.Data.Seed;

public static class CategorySeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        if (await dbContext.Categories.AnyAsync())
            return;

        var categories = new List<Category>
        {
            new ()
            {
                Name = "Yoga"
            },
            new ()
            {
                Name = "Cardio"
            },
            new ()
            {
                Name = "Strength Training"
            },
            new ()
            {
                Name = "CrossFit"
            },
            new ()
            {
                Name = "Boxing"
            }
        };
    }
}