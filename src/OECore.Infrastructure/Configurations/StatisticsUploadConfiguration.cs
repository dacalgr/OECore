using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class StatisticsUploadConfiguration : IEntityTypeConfiguration<StatisticsUpload>
{
    public void Configure(EntityTypeBuilder<StatisticsUpload> builder)
    {
        builder.ToTable("tbl_STATISTICS_Uploads");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
            
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp");
            
        builder.Property(e => e.Type)
            .HasColumnName("type")
            .HasMaxLength(100);
            
        builder.Property(e => e.Device)
            .HasColumnName("device")
            .HasMaxLength(100);
            
        builder.Property(e => e.AppVersion)
            .HasColumnName("appVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.DatabaseVersion)
            .HasColumnName("databaseVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.ItemGuid)
            .HasColumnName("itemGUID");
            
        builder.Property(e => e.Imei)
            .HasColumnName("imei")
            .HasMaxLength(15);
            
        builder.Property(e => e.Mac)
            .HasColumnName("mac")
            .HasMaxLength(17);
            
        builder.Property(e => e.PersonalNumber)
            .HasColumnName("personalNumber")
            .HasMaxLength(50);
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(4000);
            
        builder.Property(e => e.LastName)
            .HasColumnName("lastName")
            .HasMaxLength(4000);
            
        // Relationships
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
