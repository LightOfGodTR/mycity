using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommercePlatform.Models;

namespace ECommercePlatform.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasKey(v => v.VendorId);
            builder.Property(v => v.Name).IsRequired().HasMaxLength(100);
            builder.Property(v => v.ContactName).HasMaxLength(100);
            builder.Property(v => v.Email).IsRequired().HasMaxLength(100);
            builder.Property(v => v.Phone).HasMaxLength(20);
            builder.Property(v => v.Address).HasMaxLength(200);
            builder.Property(v => v.City).HasMaxLength(100);
            builder.Property(v => v.State).HasMaxLength(50);
            builder.Property(v => v.PostalCode).HasMaxLength(20);
            builder.Property(v => v.Country).HasMaxLength(50);
            
            // Diğer yapılandırmalar ve ilişkiler burada eklenebilir
        }
    }
}
