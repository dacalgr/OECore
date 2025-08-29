using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DebugRequestTimeCheckConfiguration : IEntityTypeConfiguration<DebugRequestTimeCheck>
{
    public void Configure(EntityTypeBuilder<DebugRequestTimeCheck> builder)
    {
        builder.ToTable("tbl_DEBUG_RequestTimeCheck");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.RequestedResource)
            .HasColumnName("requestedResource")
            .HasMaxLength(512)
            .IsRequired();
            
        builder.Property(e => e.QueryString)
            .HasColumnName("queryString");
            
        builder.Property(e => e.Headers)
            .HasColumnName("headers");
            
        builder.Property(e => e.RequestBody)
            .HasColumnName("requestBody");
            
        builder.Property(e => e.ResponseBody)
            .HasColumnName("responseBody");
            
        builder.Property(e => e.StartTime)
            .HasColumnName("startTime")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.EndTime)
            .HasColumnName("endTime")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.TotalSeconds)
            .HasColumnName("totalSeconds");
    }
}
