using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class SpecialPassengerConfiguration : IEntityTypeConfiguration<SpecialPassenger>
{
    public void Configure(EntityTypeBuilder<SpecialPassenger> builder)
    {
        builder.ToTable("tblSpecialPassenger");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Firstname)
            .HasColumnName("firstname")
            .HasMaxLength(100);
        
        builder.Property(e => e.Lastname)
            .HasColumnName("lastname")
            .HasMaxLength(100);
        
        builder.Property(e => e.TdbId)
            .HasColumnName("TDB_Id");
        
        builder.Property(e => e.BirthDate)
            .HasColumnName("birthDate")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.CompanyId)
            .HasColumnName("CompanyId");
        
        builder.Property(e => e.CommentDe)
            .HasColumnName("commentDE")
            .HasMaxLength(1024);
        
        builder.Property(e => e.CommentFr)
            .HasColumnName("commentFR")
            .HasMaxLength(1024);
        
        builder.Property(e => e.CommentIt)
            .HasColumnName("commentIT")
            .HasMaxLength(1024);
        
        builder.Property(e => e.ExpirationDate)
            .HasColumnName("expirationDate")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtCreation)
            .HasColumnName("dtCreation")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtUpdate)
            .HasColumnName("dtUpdate")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasOne(e => e.Company)
            .WithMany()
            .HasForeignKey(e => e.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
