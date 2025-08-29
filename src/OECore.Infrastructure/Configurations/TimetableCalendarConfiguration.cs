using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableCalendarConfiguration : IEntityTypeConfiguration<TimetableCalendar>
{
    public void Configure(EntityTypeBuilder<TimetableCalendar> builder)
    {
        builder.ToTable("tbl_TIMETABLE_calendar");
        
        builder.HasKey(e => e.ServiceId);
        
        builder.Property(e => e.ServiceId)
            .HasColumnName("service_id");
            
        builder.Property(e => e.Monday)
            .HasColumnName("monday");
            
        builder.Property(e => e.Tuesday)
            .HasColumnName("tuesday");
            
        builder.Property(e => e.Wednesday)
            .HasColumnName("wednesday");
            
        builder.Property(e => e.Thursday)
            .HasColumnName("thursday");
            
        builder.Property(e => e.Friday)
            .HasColumnName("friday");
            
        builder.Property(e => e.Saturday)
            .HasColumnName("saturday");
            
        builder.Property(e => e.Sunday)
            .HasColumnName("sunday");
            
        builder.Property(e => e.StartDate)
            .HasColumnName("start_date");
            
        builder.Property(e => e.EndDate)
            .HasColumnName("end_date");
            
        // Relationships
        builder.HasMany(e => e.Trips)
            .WithOne(e => e.Service)
            .HasForeignKey(e => e.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasMany(e => e.CalendarDates)
            .WithOne(e => e.Service)
            .HasForeignKey(e => e.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
