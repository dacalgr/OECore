using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingTicketConfiguration : IEntityTypeConfiguration<TicketingTicket>
{
    public void Configure(EntityTypeBuilder<TicketingTicket> builder)
    {
        builder.ToTable("tbl_TICKETING_Tickets");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.UserId)
            .HasColumnName("userID");

        builder.Property(e => e.CompanyId)
            .HasColumnName("companyID");

        builder.Property(e => e.CategoryId)
            .HasColumnName("categoryID");

        builder.Property(e => e.ProductId)
            .HasColumnName("productID");

        builder.Property(e => e.Company)
            .HasColumnName("company")
            .HasMaxLength(512)
            .IsRequired();

        builder.Property(e => e.Product)
            .HasColumnName("product")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.FreeText)
            .HasColumnName("freeText")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.DeletedReason)
            .HasColumnName("deletedReason")
            .HasMaxLength(1024)
            .IsRequired();

        builder.Property(e => e.Class)
            .HasColumnName("class")
            .HasMaxLength(8)
            .IsRequired();

        builder.Property(e => e.Details)
            .HasColumnName("details")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Region)
            .HasColumnName("region")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Reference)
            .HasColumnName("reference")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.TimeStamp)
            .HasColumnName("timeStamp")
            .HasColumnType("timestamp");

        builder.Property(e => e.Uploaded)
            .HasColumnName("uploaded")
            .HasColumnType("timestamp");

        builder.Property(e => e.Exported)
            .HasColumnName("exported")
            .HasColumnType("timestamp");

        builder.Property(e => e.Deleted)
            .HasColumnName("deleted")
            .HasColumnType("timestamp");

        builder.Property(e => e.Balanced)
            .HasColumnName("balanced")
            .HasColumnType("timestamp");

        builder.Property(e => e.DtProcessed)
            .HasColumnName("dtProcessed")
            .HasColumnType("timestamp");

        builder.Property(e => e.PrintMode)
            .HasColumnName("printMode");

        builder.Property(e => e.DeviceImei)
            .HasColumnName("deviceImei")
            .HasMaxLength(16)
            .IsRequired();

        builder.Property(e => e.Laufnummer)
            .HasColumnName("laufnummer")
            .HasMaxLength(12)
            .IsRequired();

        builder.Property(e => e.BelegId)
            .HasColumnName("belegId")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Kundennummer)
            .HasColumnName("kundennummer")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Lastname)
            .HasColumnName("lastname")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Birthdate)
            .HasColumnName("birthdate")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Currency)
            .HasColumnName("currency")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.BaseCardNumber)
            .HasColumnName("baseCardNumber")
            .HasMaxLength(50);

        builder.Property(e => e.ClassId)
            .HasColumnName("classId");

        builder.Property(e => e.RegionId)
            .HasColumnName("regionID");

        builder.Property(e => e.Payment)
            .HasColumnName("payment");

        builder.Property(e => e.CurrencyRate)
            .HasColumnName("currencyRate");

        builder.Property(e => e.Exported_)
            .HasColumnName("exported_")
            .HasColumnType("timestamp");

        builder.Property(e => e.Latitude)
            .HasColumnName("latitude")
            .HasColumnType("numeric");

        builder.Property(e => e.Longitude)
            .HasColumnName("longitude")
            .HasColumnType("numeric");

        builder.Property(e => e.CashChecked)
            .HasColumnName("cashChecked")
            .HasColumnType("timestamp");

        builder.Property(e => e.OnlineTransactionId)
            .HasColumnName("onlineTransactionID")
            .HasMaxLength(1000);

        builder.Property(e => e.SendEmail)
            .HasColumnName("sendEmail");

        builder.Property(e => e.Email)
            .HasColumnName("email")
            .HasMaxLength(400);

        builder.Property(e => e.MailRetryNumber)
            .HasColumnName("mailRetryNumber");

        builder.Property(e => e.SentMailOk)
            .HasColumnName("sentMailOK")
            .HasColumnType("timestamp");

        builder.Property(e => e.ConfirmedNoBackendAccess)
            .HasColumnName("confirmedNOBackendAccess");

        builder.Property(e => e.ConfirmedNoPaymentProviderAccess)
            .HasColumnName("confirmedNOPaymentProviderAccess");

        builder.Property(e => e.ConfirmedWithNoPayment)
            .HasColumnName("confirmedWithNOPayment");

        builder.Property(e => e.PayrexxGatewayId)
            .HasColumnName("payrexxGatewayID");

        builder.Property(e => e.RefundAttempt)
            .HasColumnName("RefundAttempt");

        builder.Property(e => e.IsTicketConfirmed)
            .HasColumnName("IsTicketConfirmed");

        builder.Property(e => e.QrGenerations)
            .HasColumnName("QRGenerations");

        builder.Property(e => e.QrDownloads)
            .HasColumnName("QRDownloads");

        builder.Property(e => e.DownloadToken)
            .HasColumnName("DownloadToken");

        // Navigation properties
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.CompanyEntity)
            .WithMany()
            .HasForeignKey(e => e.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Category)
            .WithMany(e => e.Tickets)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ProductEntity)
            .WithMany(e => e.Tickets)
            .HasForeignKey(e => e.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.TicketLines)
            .WithOne(e => e.Ticket)
            .HasForeignKey(e => e.TicketId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.TicketImages)
            .WithOne(e => e.Ticket)
            .HasForeignKey(e => e.TicketId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
