using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class IncidentsLogConfiguration : IEntityTypeConfiguration<IncidentsLog>
{
    public void Configure(EntityTypeBuilder<IncidentsLog> builder)
    {
        builder.ToTable("tblIncidentsLog");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IncidentFields).HasColumnName("incidentFields").HasMaxLength(4000);
        builder.Property(e => e.Operation).HasColumnName("operation").HasMaxLength(10);
        builder.Property(e => e.IncidentId).HasColumnName("incidentId");
        builder.Property(e => e.IncidentQuitNo).HasColumnName("incidentQuitNo").HasMaxLength(50);
        builder.Property(e => e.ImagesCount).HasColumnName("imagesCount");
        builder.Property(e => e.AppVersion).HasColumnName("appVersion").HasMaxLength(10);
        builder.Property(e => e.DeviceId).HasColumnName("deviceId").HasMaxLength(400);
        builder.Property(e => e.SqliteVersion).HasColumnName("sqliteVersion").HasMaxLength(50);
        builder.Property(e => e.Date).HasColumnName("date").HasColumnType("timestamp");
        builder.Property(e => e.SqliteLastUpdate).HasColumnName("sqliteLastUpdate").HasMaxLength(50);
        builder.Property(e => e.Imei).HasColumnName("imei").HasMaxLength(400);

        // Relationship
        builder.HasOne(e => e.Incident).WithMany().HasForeignKey(e => e.IncidentId).OnDelete(DeleteBehavior.Restrict);
    }
}
