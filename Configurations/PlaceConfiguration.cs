using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommercePlatform.Models;

namespace ECommercePlatform.Configurations
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(p => p.PlaceId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Address).HasMaxLength(200);
            builder.Property(p => p.City).HasMaxLength(100);
            builder.Property(p => p.State).HasMaxLength(50);
            builder.Property(p => p.PostalCode).HasMaxLength(20);
            builder.Property(p => p.Country).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(500);
        }
    }
}
