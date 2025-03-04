using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommercePlatform.Models;

namespace ECommercePlatform.Configurations
{
    public class ResellerConfiguration : IEntityTypeConfiguration<Reseller>
    {
        public void Configure(EntityTypeBuilder<Reseller> builder)
        {
            builder.HasKey(r => r.ResellerId);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.Property(r => r.ContactName).HasMaxLength(100);
            builder.Property(r => r.Email).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Phone).HasMaxLength(20);
            builder.Property(r => r.Address).HasMaxLength(200);
            builder.Property(r => r.City).HasMaxLength(100);
            builder.Property(r => r.State).HasMaxLength(50);
            builder.Property(r => r.PostalCode).HasMaxLength(20);
            builder.Property(r => r.Country).HasMaxLength(50);
            
            // Diğer yapılandırmalar ve ilişkiler burada eklenebilir
        }
    }
}
