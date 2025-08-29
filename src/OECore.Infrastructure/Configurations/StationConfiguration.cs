using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class StationConfiguration : IEntityTypeConfiguration<Station>
{
    public void Configure(EntityTypeBuilder<Station> builder)
    {
        builder.ToTable("tbl_CONFIG_Stations");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Didok)
            .HasColumnName("didok");
            
        builder.Property(e => e.DidokLong)
            .HasColumnName("didoklong");
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(512);
            
        builder.Property(e => e.Ort)
            .HasColumnName("ort")
            .HasMaxLength(512);
            
        builder.Property(e => e.SystemName)
            .HasColumnName("systemName")
            .HasMaxLength(50);
            
        builder.Property(e => e.Lat)
            .HasColumnName("lat");
            
        builder.Property(e => e.Lng)
            .HasColumnName("lng");
            
        builder.Property(e => e.StraaId)
            .HasColumnName("straaid")
            .HasColumnType("numeric");
            
        builder.Property(e => e.Zone)
            .HasColumnName("zone")
            .HasMaxLength(512);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.KantonsKurzel)
            .HasColumnName("kantonsKurzel")
            .HasMaxLength(50);
            
        builder.Property(e => e.Bemerkung)
            .HasColumnName("bemerkung")
            .HasMaxLength(100);
            
        builder.Property(e => e.Update)
            .HasColumnName("update")
            .HasMaxLength(200);
            
        builder.Property(e => e.DtSharepointImport)
            .HasColumnName("dtSharepointIimport");
    }
}
