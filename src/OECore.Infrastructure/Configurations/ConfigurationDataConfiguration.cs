using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ConfigurationDataConfiguration : IEntityTypeConfiguration<ConfigurationData>
{
    public void Configure(EntityTypeBuilder<ConfigurationData> builder)
    {
        builder.ToTable("tblConfigurationData");
        builder.HasKey(e => e.DataKey);
        
        builder.Property(e => e.DataKey)
            .HasColumnName("DataKey")
            .HasMaxLength(64);
        
        builder.Property(e => e.DataValue)
            .HasColumnName("DataValue")
            .HasColumnType("text");
    }
}
