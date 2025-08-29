using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class FirstNameConfiguration : IEntityTypeConfiguration<FirstName>
{
    public void Configure(EntityTypeBuilder<FirstName> builder)
    {
        builder.ToTable("tbl_CONFIG_Firstnames");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Gender)
            .HasColumnName("gender")
            .HasMaxLength(16);
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(32)
            .IsRequired();
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
