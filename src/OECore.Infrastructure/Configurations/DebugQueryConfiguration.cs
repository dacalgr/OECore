using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DebugQueryConfiguration : IEntityTypeConfiguration<DebugQuery>
{
    public void Configure(EntityTypeBuilder<DebugQuery> builder)
    {
        builder.ToTable("tbl_DEBUG_Queries");
        
        builder.HasKey(e => e.Name);
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(64);
            
        builder.Property(e => e.Query)
            .HasColumnName("query");
    }
}
