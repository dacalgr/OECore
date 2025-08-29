using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class StatisticsDeviceDataConfiguration : IEntityTypeConfiguration<StatisticsDeviceData>
{
    public void Configure(EntityTypeBuilder<StatisticsDeviceData> builder)
    {
        builder.ToTable("tbl_STATISTICS_devicesData");
        
        builder.HasKey(e => new { e.DeviceId, e.Imei, e.Mac });
        
        builder.Property(e => e.DeviceId)
            .HasColumnName("deviceId")
            .HasMaxLength(100);
            
        builder.Property(e => e.Imei)
            .HasColumnName("imei")
            .HasMaxLength(100);
            
        builder.Property(e => e.Mac)
            .HasColumnName("mac")
            .HasMaxLength(100);
    }
}
