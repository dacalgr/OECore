using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class NovaProductDataConfiguration : IEntityTypeConfiguration<NovaProductData>
{
    public void Configure(EntityTypeBuilder<NovaProductData> builder)
    {
        builder.ToTable("tbl_NOVA_ProductData");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Verbund)
            .HasColumnName("Verbund")
            .HasMaxLength(100);

        builder.Property(e => e.ProductNumber)
            .HasColumnName("productNumber")
            .HasMaxLength(100);

        builder.Property(e => e.DefaultText)
            .HasColumnName("defaultText")
            .HasMaxLength(500);

        builder.Property(e => e.DeText)
            .HasColumnName("deText")
            .HasMaxLength(500);

        builder.Property(e => e.FrText)
            .HasColumnName("frText")
            .HasMaxLength(500);

        builder.Property(e => e.ItText)
            .HasColumnName("itText")
            .HasMaxLength(500);

        builder.Property(e => e.EnText)
            .HasColumnName("enText")
            .HasMaxLength(500);

        builder.Property(e => e.DisplayGroup)
            .HasColumnName("displayGroup")
            .HasMaxLength(100);

        builder.Property(e => e.TemplateId)
            .HasColumnName("templateId")
            .HasMaxLength(100);

        builder.Property(e => e.IsProductBasedPurchase)
            .HasColumnName("isProductBasedPurchase");

        // Navigation properties
        builder.HasMany(e => e.CompanyProducts)
            .WithOne(e => e.NovaProductData)
            .HasForeignKey(e => e.NovaProductDataId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public class NovaCompanyProductDataConfiguration : IEntityTypeConfiguration<NovaCompanyProductData>
{
    public void Configure(EntityTypeBuilder<NovaCompanyProductData> builder)
    {
        builder.ToTable("tbl_CONFIG_Companies_NOVA_ProductData");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.NovaProductDataId)
            .HasColumnName("NovaProductDataId");

        builder.Property(e => e.CompanyId)
            .HasColumnName("CompanyId");

        // Navigation properties
        builder.HasOne(e => e.Company)
            .WithMany()
            .HasForeignKey(e => e.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
