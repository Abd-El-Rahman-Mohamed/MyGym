using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGym.DataAccess.Models;

namespace MyGym.DataAccess.Data.Configurations;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("Plan");

        builder.HasKey(plan => plan.Id);

        builder.Property(plan => plan.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(plan => plan.Price)
            .HasPrecision(10, 2);
    }
}