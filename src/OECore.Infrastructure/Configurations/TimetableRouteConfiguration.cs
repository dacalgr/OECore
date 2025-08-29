using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TimetableRouteConfiguration : IEntityTypeConfiguration<TimetableRoute>
{
    public void Configure(EntityTypeBuilder<TimetableRoute> builder)
    {
        builder.ToTable("tbl_TIMETABLE_routes");
        
        builder.HasKey(e => e.RouteId);
        
        builder.Property(e => e.RouteId)
            .HasColumnName("route_id");
            
        builder.Property(e => e.AgencyId)
            .HasColumnName("agency_id");
            
        builder.Property(e => e.RouteShortName)
            .HasColumnName("route_short_name");
            
        builder.Property(e => e.RouteLongName)
            .HasColumnName("route_long_name");
            
        builder.Property(e => e.RouteDesc)
            .HasColumnName("route_desc");
            
        builder.Property(e => e.RouteType)
            .HasColumnName("route_type");
            
        builder.Property(e => e.RouteUrl)
            .HasColumnName("route_url");
            
        builder.Property(e => e.RouteColor)
            .HasColumnName("route_color");
            
        builder.Property(e => e.RouteTextColor)
            .HasColumnName("route_text_color");
            
        // Relationships
        builder.HasOne(e => e.Agency)
            .WithMany(e => e.Routes)
            .HasForeignKey(e => e.AgencyId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasMany(e => e.Trips)
            .WithOne(e => e.Route)
            .HasForeignKey(e => e.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
