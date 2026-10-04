using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class MemberConfiguration :
    UserConfiguration<Member>
{
    public override void Configure(EntityTypeBuilder<Member> builder)
    {
        base.Configure(builder);
        
        // configuration related to "Members"
        
        builder.Property(p => p.Photo)
            .HasMaxLength(500);
    }
}