using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DashboardConfiguration : IEntityTypeConfiguration<Dashboard>
{
    public void Configure(EntityTypeBuilder<Dashboard> builder)
    {
        builder.ToTable("tbl_CONFIG_Dashboards");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50);
            
        builder.Property(e => e.ThemeId)
            .HasColumnName("themeId");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        // Relationships
        builder.HasOne(e => e.Theme)
            .WithMany()
            .HasForeignKey(e => e.ThemeId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasMany(e => e.Users)
            .WithMany()
            .UsingEntity(
                "tbl_CONFIG_Dashboards_Users",
                l => l.HasOne(typeof(User)).WithMany().HasForeignKey("userId"),
                r => r.HasOne(typeof(Dashboard)).WithMany().HasForeignKey("dashboardId"));
    }
}
