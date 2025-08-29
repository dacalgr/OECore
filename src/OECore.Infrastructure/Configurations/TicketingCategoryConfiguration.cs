using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingCategoryConfiguration : IEntityTypeConfiguration<TicketingCategory>
{
    public void Configure(EntityTypeBuilder<TicketingCategory> builder)
    {
        builder.ToTable("tbl_TICKETING_Categories");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.NameDE)
            .HasColumnName("nameDE")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.NameFR)
            .HasColumnName("nameFR")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.NameIT)
            .HasColumnName("nameIT")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.MustOpenMnc)
            .HasColumnName("mustOpenMnc");

        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");

        builder.Property(e => e.Rank)
            .HasColumnName("rank");

        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");

        // Navigation properties
        builder.HasMany(e => e.Products)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Tickets)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
