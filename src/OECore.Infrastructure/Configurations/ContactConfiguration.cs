using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("tblContact");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(4000);
        
        builder.Property(e => e.LastName)
            .HasColumnName("lastName")
            .HasMaxLength(4000);
        
        builder.Property(e => e.BirthDate)
            .HasColumnName("birthDate")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.ActiveFrom)
            .HasColumnName("activeFrom")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.ActiveTo)
            .HasColumnName("activeTo")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.Language)
            .HasColumnName("language");
        
        builder.Property(e => e.Email)
            .HasColumnName("email")
            .HasMaxLength(4000);
        
        builder.Property(e => e.Phone)
            .HasColumnName("phone")
            .HasMaxLength(4000);
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.Department)
            .HasColumnName("department")
            .HasMaxLength(500);
        
        builder.Property(e => e.Direction)
            .HasColumnName("direction")
            .HasMaxLength(500);
        
        builder.Property(e => e.PrivatePhone)
            .HasColumnName("privatePhone")
            .HasMaxLength(50);
        
        builder.Property(e => e.Fax)
            .HasColumnName("fax")
            .HasMaxLength(50);
        
        builder.Property(e => e.Section)
            .HasColumnName("section")
            .HasMaxLength(100);
        
        builder.Property(e => e.Address)
            .HasColumnName("address")
            .HasMaxLength(100);
        
        builder.Property(e => e.Plz)
            .HasColumnName("plz")
            .HasMaxLength(50);
        
        builder.Property(e => e.City)
            .HasColumnName("city")
            .HasMaxLength(50);
        
        builder.Property(e => e.Country)
            .HasColumnName("country")
            .HasMaxLength(50);
    }
}
