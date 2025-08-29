using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class RefundReasonConfiguration : IEntityTypeConfiguration<RefundReason>
{
    public void Configure(EntityTypeBuilder<RefundReason> builder)
    {
        builder.ToTable("tbl_CONFIG_RefundReasons");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TextDe)
            .HasColumnName("text_de")
            .HasMaxLength(512);
            
        builder.Property(e => e.TextFr)
            .HasColumnName("text_fr")
            .HasMaxLength(512);
            
        builder.Property(e => e.TextIt)
            .HasColumnName("text_it")
            .HasMaxLength(512);
            
        builder.Property(e => e.LangRef)
            .HasColumnName("langRef")
            .HasMaxLength(512);
            
        builder.Property(e => e.Rank)
            .HasColumnName("rank");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
