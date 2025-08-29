using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableAgencyConfiguration : IEntityTypeConfiguration<TimetableAgency>
{
    public void Configure(EntityTypeBuilder<TimetableAgency> builder)
    {
        builder.ToTable("tbl_TIMETABLE_agency");
        
        builder.HasKey(e => e.AgencyId);
        
        builder.Property(e => e.AgencyId)
            .HasColumnName("agency_id");
            
        builder.Property(e => e.AgencyName)
            .HasColumnName("agency_name");
            
        builder.Property(e => e.AgencyUrl)
            .HasColumnName("agency_url");
            
        builder.Property(e => e.AgencyTimezone)
            .HasColumnName("agency_timezone");
            
        builder.Property(e => e.AgencyLang)
            .HasColumnName("agency_lang");
            
        builder.Property(e => e.AgencyPhone)
            .HasColumnName("agency_phone");
            
        builder.Property(e => e.AgencyFareUrl)
            .HasColumnName("agency_fare_url");
            
        builder.Property(e => e.AgencyEmail)
            .HasColumnName("agency_email");
            
        // Relationships
        builder.HasMany(e => e.Routes)
            .WithOne(e => e.Agency)
            .HasForeignKey(e => e.AgencyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
