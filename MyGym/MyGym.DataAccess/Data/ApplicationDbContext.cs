using Microsoft.EntityFrameworkCore;
using MyGym.DataAccess.Models;

namespace MyGym.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Plan> Plans => Set<Plan>();
    
    public DbSet<Category> Categories => Set<Category>();
    
    public DbSet<User> Users => Set<User>();
    
    public DbSet<Session> Sessions => Set<Session>();
    
    public DbSet<Membership> Memberships => Set<Membership>();
    
    public DbSet<Booking> Bookings => Set<Booking>();
    
    public DbSet<HealthRecord> HealthRecords => Set<HealthRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}