using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class IncidentTaskConfiguration : IEntityTypeConfiguration<IncidentTask>
{
    public void Configure(EntityTypeBuilder<IncidentTask> builder)
    {
        builder.ToTable("tblTask");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.StartTime).HasColumnName("startTime").HasColumnType("timestamp");
        builder.Property(e => e.TurnId).HasColumnName("turnId");
        builder.Property(e => e.FirmId).HasColumnName("firmId");
        builder.Property(e => e.DtModified).HasColumnName("dtModified").HasColumnType("timestamp");
        builder.Property(e => e.Type).HasColumnName("type").HasMaxLength(20);
        builder.Property(e => e.TeamId).HasColumnName("teamId");
        builder.Property(e => e.Station).HasColumnName("station").HasMaxLength(4000);
        builder.Property(e => e.StationsList).HasColumnName("stationsList").HasMaxLength(4000);
        builder.Property(e => e.ControlTypeId).HasColumnName("controlTypeId");
        builder.Property(e => e.Route).HasColumnName("route").HasMaxLength(50);
        builder.Property(e => e.Counter).HasColumnName("counter");
        builder.Property(e => e.Zone).HasColumnName("zone").HasMaxLength(50);
        builder.Property(e => e.Wagon).HasColumnName("wagon").HasMaxLength(50);
        builder.Property(e => e.Confirmedline).HasColumnName("confirmedline");
        builder.Property(e => e.ConfirmedLineReason).HasColumnName("confirmedLineReason").HasMaxLength(4000);
        builder.Property(e => e.SubcategoryId).HasColumnName("subcategoryId");
        builder.Property(e => e.Category).HasColumnName("category");
        builder.Property(e => e.OldTurnId).HasColumnName("oldTurnID");
        builder.Property(e => e.Region).HasColumnName("region");
        builder.Property(e => e.FreeText).HasColumnName("freeText");
        builder.Property(e => e.RegionName).HasColumnName("regionName").HasMaxLength(300);
        builder.Property(e => e.Balanced).HasColumnName("balanced").HasColumnType("timestamp");
        builder.Property(e => e.FirmId_).HasColumnName("firmId_");
        builder.Property(e => e.TurnIdOrig).HasColumnName("turnId_ORIG");
        builder.Property(e => e.Latitude).HasColumnName("latitude").HasColumnType("numeric");
        builder.Property(e => e.Longitude).HasColumnName("longitude").HasColumnType("numeric");
        builder.Property(e => e.FullControl).HasColumnName("fullControl");
        builder.Property(e => e.FlightCount).HasColumnName("flightCount");
        builder.Property(e => e.Aggression).HasColumnName("aggression");
        builder.Property(e => e.DtProcessed).HasColumnName("dtProcessed").HasColumnType("timestamp");
        builder.Property(e => e.DeviceId).HasColumnName("deviceId");

        // Relationships
        builder.HasOne(e => e.Company).WithMany().HasForeignKey(e => e.FirmId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(e => e.Turn).WithMany(e => e.IncidentTasks).HasForeignKey(e => e.TurnId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(e => e.TaskTypes).WithOne(e => e.IncidentTask).HasForeignKey(e => e.TaskId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(e => e.Incidents).WithOne(e => e.IncidentTask).HasForeignKey(e => e.TaskId).OnDelete(DeleteBehavior.Restrict);
    }
}
