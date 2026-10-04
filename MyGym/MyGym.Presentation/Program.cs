using Microsoft.EntityFrameworkCore;
using MyGym.DataAccess.Data;
using MyGym.DataAccess.Data.Seed;
using MyGym.DataAccess.Interceptors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AuditColumnsInterceptor>();

builder.Services.AddDbContext<ApplicationDbContext>((sp, options) =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    options.AddInterceptors(sp.GetRequiredService<AuditColumnsInterceptor>());
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

await DatabaseSeeder.SeedAsync(dbContext);

app.Run();