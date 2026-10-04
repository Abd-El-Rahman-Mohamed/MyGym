using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.Property(x => x.IsAttended)
            .IsRequired()
            .HasDefaultValue(false); // To set false by default

        builder.HasOne(b => b.Member)
            .WithMany(m => m.Bookings)
            .HasForeignKey(b => b.MemberId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(x => new
        {
            x.MemberId,
            x.SessionId
        });

        builder.ToTable(t =>
        {
            t.HasCheckConstraint(
                "CK_Booking_Date",
                "[Date] >= GETDATE()"
            );
        });
    }
}