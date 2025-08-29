using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingProductConfiguration : IEntityTypeConfiguration<TicketingProduct>
{
    public void Configure(EntityTypeBuilder<TicketingProduct> builder)
    {
        builder.ToTable("tbl_TICKETING_Products");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.CategoryId)
            .HasColumnName("categoryId");

        builder.Property(e => e.NameDE)
            .HasColumnName("name_DE")
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

        builder.Property(e => e.FreeTextDE)
            .HasColumnName("freeText_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.FreeTextFR)
            .HasColumnName("freeText_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.FreeTextIT)
            .HasColumnName("freeText_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.CommentsDE)
            .HasColumnName("comments_DE")
            .HasMaxLength(512)
            .IsRequired();

        builder.Property(e => e.CommentsFR)
            .HasColumnName("comments_FR")
            .HasMaxLength(512)
            .IsRequired();

        builder.Property(e => e.CommentsIT)
            .HasColumnName("comments_IT")
            .HasMaxLength(512)
            .IsRequired();

        builder.Property(e => e.ResponsibleDE)
            .HasColumnName("responsible_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ResponsibleFR)
            .HasColumnName("responsible_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ResponsibleIT)
            .HasColumnName("responsible_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.TransferableDE)
            .HasColumnName("transferable_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.TransferableFR)
            .HasColumnName("transferable_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.TransferableIT)
            .HasColumnName("transferable_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BaseCard)
            .HasColumnName("baseCard");

        builder.Property(e => e.BillIdDE)
            .HasColumnName("billId_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BillIdFR)
            .HasColumnName("billId_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BillIdIT)
            .HasColumnName("billId_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ValidToTextDE)
            .HasColumnName("validToText_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ValidToTextFR)
            .HasColumnName("validToText_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ValidToTextIT)
            .HasColumnName("validToText_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ValidFromFormat)
            .HasColumnName("validFromFormat")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ValidToInHours)
            .HasColumnName("validToInHours");

        builder.Property(e => e.ValidToFormat)
            .HasColumnName("validToFormat")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.FQCode)
            .HasColumnName("fQCode")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.SignatureDE)
            .HasColumnName("signature_DE")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.SignatureFR)
            .HasColumnName("signature_FR")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.SignatureIT)
            .HasColumnName("signature_IT")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.HasPrivateData)
            .HasColumnName("hasPrivateData");

        builder.Property(e => e.BirthDateTextDE)
            .HasColumnName("birthDateText_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BirthDateTextFR)
            .HasColumnName("birthDateText_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BirthDateTextIT)
            .HasColumnName("birthDateText_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ShowCustomerNumber)
            .HasColumnName("showCustomerNumber");

        builder.Property(e => e.QRCode)
            .HasColumnName("qRCode");

        builder.Property(e => e.ArticleTextDE)
            .HasColumnName("articleText_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ArticleTextFR)
            .HasColumnName("articleText_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ArticleTextIT)
            .HasColumnName("articleText_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ArticleNumber)
            .HasColumnName("articleNumber")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.PriceTextDE)
            .HasColumnName("priceText_DE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.PriceTextFR)
            .HasColumnName("priceText_FR")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.PriceTextIT)
            .HasColumnName("priceText_IT")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Group)
            .HasColumnName("group");

        builder.Property(e => e.Single)
            .HasColumnName("single");

        builder.Property(e => e.MwstLabelDE)
            .HasColumnName("mwst_label_de")
            .HasMaxLength(256);

        builder.Property(e => e.MwstLabelFR)
            .HasColumnName("mwst_label_fr")
            .HasMaxLength(256);

        builder.Property(e => e.MwstLabelIT)
            .HasColumnName("mwst_label_it")
            .HasMaxLength(256);

        builder.Property(e => e.Mwst)
            .HasColumnName("mwst");

        builder.Property(e => e.ProductFreeTextDE)
            .HasColumnName("productFreeText_DE")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.ProductFreeTextFR)
            .HasColumnName("productFreeText_FR")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.ProductFreeTextIT)
            .HasColumnName("productFreeText_IT")
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.GroupLabelDE)
            .HasColumnName("groupLabel_DE")
            .HasMaxLength(256);

        builder.Property(e => e.GroupLabelFR)
            .HasColumnName("groupLabel_FR")
            .HasMaxLength(256);

        builder.Property(e => e.GroupLabelIT)
            .HasColumnName("groupLabel_IT")
            .HasMaxLength(256);

        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");

        builder.Property(e => e.Rank)
            .HasColumnName("rank");

        builder.Property(e => e.Cancellable)
            .HasColumnName("cancellable");

        builder.Property(e => e.BelegRoleId)
            .HasColumnName("belegRoleId");

        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");

        // Navigation properties
        builder.HasOne(e => e.Category)
            .WithMany(e => e.Products)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.ProductPrices)
            .WithOne(e => e.Product)
            .HasForeignKey(e => e.IdProduct)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Tickets)
            .WithOne(e => e.ProductEntity)
            .HasForeignKey(e => e.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
