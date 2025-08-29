using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.ToTable("tblBill");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Code)
            .HasColumnName("code")
            .HasMaxLength(10);
        
        builder.Property(e => e.NameDe)
            .HasColumnName("nameDE")
            .HasMaxLength(400);
        
        builder.Property(e => e.NameFr)
            .HasColumnName("nameFR")
            .HasMaxLength(400);
        
        builder.Property(e => e.NameIt)
            .HasColumnName("nameIT")
            .HasMaxLength(400);
        
        builder.Property(e => e.Surcharge)
            .HasColumnName("surcharge")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Fare)
            .HasColumnName("fare")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Fee)
            .HasColumnName("fee")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Abuse)
            .HasColumnName("abuse")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Forgery)
            .HasColumnName("forgery")
            .HasColumnType("numeric");
        
        builder.Property(e => e.TimePenalties)
            .HasColumnName("time_penalties")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Miscellaneus)
            .HasColumnName("miscellaneus")
            .HasColumnType("numeric");
        
        builder.Property(e => e.Total)
            .HasColumnName("total")
            .HasColumnType("numeric");
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
