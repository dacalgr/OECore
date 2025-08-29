using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class StatisticsLoginConfiguration : IEntityTypeConfiguration<StatisticsLogin>
{
    public void Configure(EntityTypeBuilder<StatisticsLogin> builder)
    {
        builder.ToTable("tbl_STATISTICS_Logins");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
            
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp");
            
        builder.Property(e => e.Device)
            .HasColumnName("device")
            .HasMaxLength(100);
            
        builder.Property(e => e.AppVersion)
            .HasColumnName("appVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.DatabaseVersion)
            .HasColumnName("databaseVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.ETicketAppVersion)
            .HasColumnName("eTicketAppVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.ETicketDatabaseVersion)
            .HasColumnName("eTicketDatabaseVersion")
            .HasMaxLength(100);
            
        builder.Property(e => e.Latitude)
            .HasColumnName("latitude")
            .HasColumnType("numeric");
            
        builder.Property(e => e.Longitude)
            .HasColumnName("longitude")
            .HasColumnType("numeric");
            
        builder.Property(e => e.Imei)
            .HasColumnName("imei")
            .HasMaxLength(15);
            
        builder.Property(e => e.Mac)
            .HasColumnName("mac")
            .HasMaxLength(17);
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(4000);
            
        builder.Property(e => e.LastName)
            .HasColumnName("lastName")
            .HasMaxLength(4000);
            
        builder.Property(e => e.PersonalNumber)
            .HasColumnName("personalNumber")
            .HasMaxLength(50);
            
        builder.Property(e => e.Operation)
            .HasColumnName("operation")
            .HasMaxLength(50);
            
        // Relationships
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
