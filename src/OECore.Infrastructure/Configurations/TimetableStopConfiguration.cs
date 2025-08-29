using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableStopConfiguration : IEntityTypeConfiguration<TimetableStop>
{
    public void Configure(EntityTypeBuilder<TimetableStop> builder)
    {
        builder.ToTable("tbl_TIMETABLE_stops");
        
        builder.HasKey(e => e.StopId);
        
        builder.Property(e => e.StopId)
            .HasColumnName("stop_id");
            
        builder.Property(e => e.StopCode)
            .HasColumnName("stop_code");
            
        builder.Property(e => e.StopName)
            .HasColumnName("stop_name");
            
        builder.Property(e => e.StopDesc)
            .HasColumnName("stop_desc");
            
        builder.Property(e => e.StopLat)
            .HasColumnName("stop_lat");
            
        builder.Property(e => e.StopLon)
            .HasColumnName("stop_lon");
            
        builder.Property(e => e.ZoneId)
            .HasColumnName("zone_id");
            
        builder.Property(e => e.StopUrl)
            .HasColumnName("stop_url");
            
        builder.Property(e => e.LocationType)
            .HasColumnName("location_type");
            
        builder.Property(e => e.ParentStation)
            .HasColumnName("parent_station");
            
        builder.Property(e => e.StopTimezone)
            .HasColumnName("stop_timezone");
            
        builder.Property(e => e.WheelchairBoarding)
            .HasColumnName("wheelchair_boarding");
            
        builder.Property(e => e.LevelId)
            .HasColumnName("level_id");
            
        builder.Property(e => e.PlatformCode)
            .HasColumnName("platform_code");
            
        // Relationships
        builder.HasMany(e => e.StopTimes)
            .WithOne(e => e.Stop)
            .HasForeignKey(e => e.StopId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
