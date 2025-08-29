using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ConfigLogConfiguration : IEntityTypeConfiguration<ConfigLog>
{
    public void Configure(EntityTypeBuilder<ConfigLog> builder)
    {
        builder.ToTable("tbl_CONFIG_Log");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.UserEmail)
            .HasColumnName("userEmail")
            .HasMaxLength(150);
            
        builder.Property(e => e.UserUsername)
            .HasColumnName("userUsername")
            .HasMaxLength(50);
            
        builder.Property(e => e.UserDisplayName)
            .HasColumnName("userDisplayName")
            .HasMaxLength(50);
            
        builder.Property(e => e.EntityName)
            .HasColumnName("entityName")
            .HasMaxLength(100);
            
        builder.Property(e => e.EntityId)
            .HasColumnName("entityId")
            .HasMaxLength(100);
            
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp");
            
        builder.Property(e => e.Operation)
            .HasColumnName("operation")
            .HasMaxLength(20);
            
        builder.Property(e => e.OldValues)
            .HasColumnName("oldValues");
            
        builder.Property(e => e.NewValues)
            .HasColumnName("newValues");
    }
}
