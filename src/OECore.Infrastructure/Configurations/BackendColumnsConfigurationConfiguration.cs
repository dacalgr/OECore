using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BackendColumnsConfigurationConfiguration : IEntityTypeConfiguration<BackendColumnsConfiguration>
{
    public void Configure(EntityTypeBuilder<BackendColumnsConfiguration> builder)
    {
        builder.ToTable("tbl_BACKEND_ColumnsConfiguration");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.UserId)
            .HasColumnName("userID")
            .HasMaxLength(50);
        
        builder.Property(e => e.TableName)
            .HasColumnName("tableName")
            .HasMaxLength(100);
        
        builder.Property(e => e.VisibleColumns)
            .HasColumnName("visibleColumns")
            .HasMaxLength(4000);
    }
}
