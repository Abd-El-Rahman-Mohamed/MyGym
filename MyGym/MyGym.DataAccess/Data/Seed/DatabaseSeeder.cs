namespace MyGym.DataAccess.Data.Seed;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        await PlanSeeder.SeedAsync(dbContext);
        
        await CategorySeeder.SeedAsync(dbContext);
    }
}