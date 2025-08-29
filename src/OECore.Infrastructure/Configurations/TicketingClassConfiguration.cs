using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingClassConfiguration : IEntityTypeConfiguration<TicketingClass>
{
    public void Configure(EntityTypeBuilder<TicketingClass> builder)
    {
        builder.ToTable("tbl_TICKETING_Classes");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.NameEN)
            .HasColumnName("name_EN")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.NameFR)
            .HasColumnName("name_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.NameIT)
            .HasColumnName("name_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");

        // Navigation properties
        builder.HasMany(e => e.ProductPrices)
            .WithOne(e => e.Class)
            .HasForeignKey(e => e.IdClass)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
