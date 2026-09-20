namespace MyGym.Data.Seed;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        await PlanSeeder.SeedAsync(dbContext);
    }
}