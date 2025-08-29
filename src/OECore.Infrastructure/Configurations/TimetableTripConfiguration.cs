using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableTripConfiguration : IEntityTypeConfiguration<TimetableTrip>
{
    public void Configure(EntityTypeBuilder<TimetableTrip> builder)
    {
        builder.ToTable("tbl_TIMETABLE_trips");
        
        builder.HasKey(e => e.TripId);
        
        builder.Property(e => e.TripId)
            .HasColumnName("trip_id");
            
        builder.Property(e => e.RouteId)
            .HasColumnName("route_id");
            
        builder.Property(e => e.ServiceId)
            .HasColumnName("service_id");
            
        builder.Property(e => e.TripHeadsign)
            .HasColumnName("trip_headsign");
            
        builder.Property(e => e.TripShortName)
            .HasColumnName("trip_short_name");
            
        builder.Property(e => e.DirectionId)
            .HasColumnName("direction_id");
            
        builder.Property(e => e.BlockId)
            .HasColumnName("block_id");
            
        builder.Property(e => e.ShapeId)
            .HasColumnName("shape_id");
            
        builder.Property(e => e.WheelchairAccessible)
            .HasColumnName("wheelchair_accessible");
            
        builder.Property(e => e.BikesAllowed)
            .HasColumnName("bikes_allowed");
            
        // Relationships
        builder.HasOne(e => e.Route)
            .WithMany(e => e.Trips)
            .HasForeignKey(e => e.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasOne(e => e.Service)
            .WithMany(e => e.Trips)
            .HasForeignKey(e => e.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasMany(e => e.StopTimes)
            .WithOne(e => e.Trip)
            .HasForeignKey(e => e.TripId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
