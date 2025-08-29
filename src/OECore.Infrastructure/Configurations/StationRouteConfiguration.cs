using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class StationRouteConfiguration : IEntityTypeConfiguration<StationRoute>
{
    public void Configure(EntityTypeBuilder<StationRoute> builder)
    {
        builder.ToTable("tbl_CONFIG_StationsRoutes");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.StationId)
            .HasColumnName("stationId");
            
        builder.Property(e => e.RouteId)
            .HasColumnName("routeId");
            
        builder.Property(e => e.Station)
            .HasColumnName("station")
            .HasMaxLength(50);
            
        builder.Property(e => e.Route)
            .HasColumnName("route")
            .HasMaxLength(8);
    }
}
