using MyGym.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGym.DataAccess.Data.Configurations;

public class UserConfiguration<T> : IEntityTypeConfiguration<T> where T : User
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(u => u.Name)
            .HasMaxLength(100);

        builder.Property(u => u.Email)
            .HasMaxLength(100);
        
        builder.Property(u => u.Phone)
            .HasMaxLength(20);

        builder.OwnsOne(x => x.Address, t =>
        {
            t.Property(a => a.Street)
                .HasColumnName("Street")
                .HasMaxLength(100);
            
            t.Property(a => a.City)
                .HasColumnName("City")
                .HasMaxLength(100);
            
            t.Property(a => a.BuildingNumber)
                .HasColumnName("BuildingNumber")
                .HasMaxLength(100);
        });

        builder.HasIndex(u => u.Email)
            .IsUnique();
        
        builder.HasIndex(u => u.Phone)
            .IsUnique();

        builder.ToTable(t =>
        {
            t.HasCheckConstraint(
                "CK_User_Phone",
                "LEN([Phone]) = 11 AND [Phone] LIKE '01[0125]%'"
            );
        });
        
    }
}