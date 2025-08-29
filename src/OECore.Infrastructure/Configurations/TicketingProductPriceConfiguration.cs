using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingProductPriceConfiguration : IEntityTypeConfiguration<TicketingProductPrice>
{
    public void Configure(EntityTypeBuilder<TicketingProductPrice> builder)
    {
        builder.ToTable("tbl_TICKETING_ProductPrices");

        builder.HasKey(e => new { e.IdProduct, e.IdClass });

        builder.Property(e => e.IdProduct)
            .HasColumnName("idProduct");

        builder.Property(e => e.IdClass)
            .HasColumnName("idClass");

        builder.Property(e => e.Price)
            .HasColumnName("price");

        builder.Property(e => e.HalfPrice)
            .HasColumnName("halfPrice");

        builder.Property(e => e.FqCodePrice)
            .HasColumnName("fqCodePrice")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(e => e.FqCodeHalfPrice)
            .HasColumnName("fqCodeHalfPrice")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");

        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");

        // Navigation properties
        builder.HasOne(e => e.Class)
            .WithMany(e => e.ProductPrices)
            .HasForeignKey(e => e.IdClass)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Product)
            .WithMany(e => e.ProductPrices)
            .HasForeignKey(e => e.IdProduct)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
