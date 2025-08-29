using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableCalendarDateConfiguration : IEntityTypeConfiguration<TimetableCalendarDate>
{
    public void Configure(EntityTypeBuilder<TimetableCalendarDate> builder)
    {
        builder.ToTable("tbl_TIMETABLE_calendar_dates");
        
        builder.HasKey(e => e.ServiceId);
        
        builder.Property(e => e.ServiceId)
            .HasColumnName("service_id");
            
        builder.Property(e => e.Date)
            .HasColumnName("date");
            
        builder.Property(e => e.ExceptionType)
            .HasColumnName("exception_type");
            
        // Relationships
        builder.HasOne(e => e.Service)
            .WithMany(e => e.CalendarDates)
            .HasForeignKey(e => e.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
