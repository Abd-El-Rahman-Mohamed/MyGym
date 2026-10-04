using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class TrainerConfiguration :
    UserConfiguration<Trainer>
{
    public override void Configure(EntityTypeBuilder<Trainer> builder)
    {
        base.Configure(builder);
        
        // configuration related to "Trainers"

        builder.Property(p => p.Specialty)
            .HasConversion<string>()
            .HasMaxLength(30);
    }
}