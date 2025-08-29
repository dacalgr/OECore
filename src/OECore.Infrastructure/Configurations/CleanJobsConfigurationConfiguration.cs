using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CleanJobsConfigurationConfiguration : IEntityTypeConfiguration<CleanJobsConfiguration>
{
    public void Configure(EntityTypeBuilder<CleanJobsConfiguration> builder)
    {
        builder.ToTable("tbl_CONFIG_CleanJobsConfiguration");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Days)
            .HasColumnName("days")
            .HasMaxLength(50);
            
        builder.Property(e => e.Monthly)
            .HasColumnName("monthly");
            
        builder.Property(e => e.LastExecution)
            .HasColumnName("lastExecution")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.NextExecution)
            .HasColumnName("nextExecution")
            .HasColumnType("timestamp");
    }
}
