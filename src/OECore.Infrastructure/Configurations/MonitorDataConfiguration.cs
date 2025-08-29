using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class MonitorDataConfiguration : IEntityTypeConfiguration<MonitorData>
{
    public void Configure(EntityTypeBuilder<MonitorData> builder)
    {
        builder.ToTable("tbl_MONITOR_Data");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Message)
            .HasColumnName("message")
            .HasMaxLength(4000);
        
        builder.Property(e => e.Type)
            .HasColumnName("type")
            .HasMaxLength(500);
        
        builder.Property(e => e.SubType)
            .HasColumnName("subType")
            .HasMaxLength(500);
        
        builder.Property(e => e.Cathegory)
            .HasColumnName("cathegory")
            .HasMaxLength(1000);
        
        builder.Property(e => e.SubCathegory)
            .HasColumnName("subCathegory")
            .HasMaxLength(1000);
        
        builder.Property(e => e.Result)
            .HasColumnName("result")
            .HasMaxLength(100);
        
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp")
            .HasColumnType("timestamp");
    }
}
