using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TurnConfiguration : IEntityTypeConfiguration<Turn>
{
    public void Configure(EntityTypeBuilder<Turn> builder)
    {
        builder.ToTable("tblTurn");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.StartTime).HasColumnName("startTime").HasColumnType("timestamp");
        builder.Property(e => e.UserId).HasColumnName("userId");
        builder.Property(e => e.DtModified).HasColumnName("dtModified").HasColumnType("timestamp");
        builder.Property(e => e.StopTime).HasColumnName("stopTime").HasColumnType("timestamp");
        builder.Property(e => e.ExportTime).HasColumnName("exportTime").HasColumnType("timestamp");
        builder.Property(e => e.Notes).HasColumnName("notes").HasMaxLength(4000);
        builder.Property(e => e.OldStartTime).HasColumnName("oldStartTime").HasColumnType("timestamp");
        builder.Property(e => e.OldStopTime).HasColumnName("oldStopTime").HasColumnType("timestamp");
        builder.Property(e => e.Balanced).HasColumnName("balanced").HasColumnType("timestamp");
        builder.Property(e => e.StopTime_).HasColumnName("stopTime_").HasColumnType("timestamp");
        builder.Property(e => e.TurnStopOrig).HasColumnName("turnStop_ORIG").HasColumnType("timestamp");
        builder.Property(e => e.TurnStartOrig).HasColumnName("turnStart_ORIG").HasColumnType("timestamp");
        builder.Property(e => e.IsDisabled).HasColumnName("is_disabled");
        builder.Property(e => e.Latitude).HasColumnName("latitude").HasColumnType("numeric");
        builder.Property(e => e.Longitude).HasColumnName("longitude").HasColumnType("numeric");

        // Relationships
        builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(e => e.IncidentTasks).WithOne(e => e.Turn).HasForeignKey(e => e.TurnId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(e => e.Incidents).WithOne(e => e.Turn).HasForeignKey(e => e.TurnId).OnDelete(DeleteBehavior.Restrict);
    }
}
