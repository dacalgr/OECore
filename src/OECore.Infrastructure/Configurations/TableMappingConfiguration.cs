using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TableMappingConfiguration : IEntityTypeConfiguration<TableMapping>
{
    public void Configure(EntityTypeBuilder<TableMapping> builder)
    {
        builder.ToTable("tbl_CONFIG_TableMapping");
        
        builder.HasKey(e => new { e.SqlServerName, e.SqliteName });
        
        builder.Property(e => e.SqlServerName)
            .HasColumnName("sqlServerName")
            .HasMaxLength(50);
            
        builder.Property(e => e.SqliteName)
            .HasColumnName("sqliteName")
            .HasMaxLength(50);
            
        builder.Property(e => e.Order)
            .HasColumnName("order");
    }
}
