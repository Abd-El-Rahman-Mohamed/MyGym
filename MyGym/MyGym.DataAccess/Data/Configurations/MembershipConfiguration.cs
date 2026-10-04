using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
{
    public void Configure(EntityTypeBuilder<Membership> builder)
    {
        builder.ToTable(t =>
        {
            t.HasCheckConstraint(
                "CK_Membership_DataRange",
                "[EndDate] > [StartDate]"
            );
        });

        builder.HasIndex(x => new
        {
            x.MemberId,
            x.PlanId,
            x.StartDate
        }).IsUnique();
    }
}