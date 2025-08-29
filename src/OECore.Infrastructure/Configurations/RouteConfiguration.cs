using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class RouteConfiguration : IEntityTypeConfiguration<Route>
{
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.ToTable("tbl_CONFIG_Routes");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50);
            
        builder.Property(e => e.Destination)
            .HasColumnName("destination")
            .HasMaxLength(64);
            
        builder.Property(e => e.FColor)
            .HasColumnName("fColor");
            
        builder.Property(e => e.BColor)
            .HasColumnName("bColor");
            
        builder.Property(e => e.AgencyId)
            .HasColumnName("agencyid");
            
        builder.Property(e => e.Vehicle)
            .HasColumnName("vehicle");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.Bemerkung)
            .HasColumnName("bemerkung")
            .HasMaxLength(100);
            
        builder.Property(e => e.Update)
            .HasColumnName("update")
            .HasMaxLength(200);
            
        builder.Property(e => e.GlueName)
            .HasColumnName("glueName")
            .HasMaxLength(50);
            
        builder.Property(e => e.GlueDestination)
            .HasColumnName("glueDestination")
            .HasMaxLength(50);
            
        builder.Property(e => e.DtSharepointImport)
            .HasColumnName("dtSharepointIimport");
            
        builder.Property(e => e.AgencyName)
            .HasColumnName("agencyName")
            .HasMaxLength(100);
    }
}
