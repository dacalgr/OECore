using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableStopTimeConfiguration : IEntityTypeConfiguration<TimetableStopTime>
{
    public void Configure(EntityTypeBuilder<TimetableStopTime> builder)
    {
        builder.ToTable("tbl_TIMETABLE_stop_times");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TripId)
            .HasColumnName("trip_id");
            
        builder.Property(e => e.ArrivalTime)
            .HasColumnName("arrival_time");
            
        builder.Property(e => e.DepartureTime)
            .HasColumnName("departure_time");
            
        builder.Property(e => e.StopId)
            .HasColumnName("stop_id");
            
        builder.Property(e => e.StopSequence)
            .HasColumnName("stop_sequence");
            
        builder.Property(e => e.StopHeadsign)
            .HasColumnName("stop_headsign");
            
        builder.Property(e => e.PickupType)
            .HasColumnName("pickup_type");
            
        builder.Property(e => e.DropOffType)
            .HasColumnName("drop_off_type");
            
        builder.Property(e => e.ShapeDistTraveled)
            .HasColumnName("shape_dist_traveled");
            
        builder.Property(e => e.Timepoint)
            .HasColumnName("timepoint");
            
        // Relationships
        builder.HasOne(e => e.Stop)
            .WithMany(e => e.StopTimes)
            .HasForeignKey(e => e.StopId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasOne(e => e.Trip)
            .WithMany(e => e.StopTimes)
            .HasForeignKey(e => e.TripId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
