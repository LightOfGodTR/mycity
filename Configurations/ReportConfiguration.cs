using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommercePlatform.Models;

namespace ECommercePlatform.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(r => r.ReportId);
            builder.Property(r => r.Title).IsRequired().HasMaxLength(200);
            builder.Property(r => r.Content).HasMaxLength(2000);
            builder.Property(r => r.GeneratedBy).HasMaxLength(100);
            builder.Property(r => r.GeneratedDate).IsRequired();
            
            // İlişkiler ve diğer yapılandırmalar burada eklenebilir
        }
    }
}
