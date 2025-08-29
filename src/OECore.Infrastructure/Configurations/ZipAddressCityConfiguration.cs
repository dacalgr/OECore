using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ZipAddressCityConfiguration : IEntityTypeConfiguration<ZipAddressCity>
{
    public void Configure(EntityTypeBuilder<ZipAddressCity> builder)
    {
        builder.ToTable("tbl_CONFIG_ZipAddressCity");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Address)
            .HasColumnName("address")
            .HasMaxLength(1000);
            
        builder.Property(e => e.Zip)
            .HasColumnName("zip")
            .HasMaxLength(20);
            
        builder.Property(e => e.City)
            .HasColumnName("city")
            .HasMaxLength(200);
            
        builder.Property(e => e.CountryCode)
            .HasColumnName("countryCode")
            .HasMaxLength(20);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
