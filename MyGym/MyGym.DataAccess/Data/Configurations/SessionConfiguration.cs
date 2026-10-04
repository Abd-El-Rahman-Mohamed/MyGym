using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.ToTable(t =>
        {
            t.HasCheckConstraint(
                "CK_Session_Capacity",
                "[Capacity] BETWEEN 1 AND 25"
            );

            t.HasCheckConstraint(
                "CK_Session_DateRange",
                "[EndDate] > [StartDate]"
            );
        });
        
        builder.HasQueryFilter(s => !s.IsDeleted);
    }
}