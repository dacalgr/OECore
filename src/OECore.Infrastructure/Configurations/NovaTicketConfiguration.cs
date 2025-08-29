using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class NovaTicketConfiguration : IEntityTypeConfiguration<NovaTicket>
{
    public void Configure(EntityTypeBuilder<NovaTicket> builder)
    {
        builder.ToTable("tbl_NOVA_Tickets");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("Id");

        builder.Property(e => e.UserId)
            .HasColumnName("UserID");

        builder.Property(e => e.PersonalNumber)
            .HasColumnName("PersonalNumber")
            .HasMaxLength(100);

        builder.Property(e => e.LaufNumber)
            .HasColumnName("LaufNumber")
            .HasMaxLength(100);

        builder.Property(e => e.CompanyShortName)
            .HasColumnName("CompanyShortName")
            .HasMaxLength(50);

        builder.Property(e => e.Region)
            .HasColumnName("Region")
            .HasMaxLength(100);

        builder.Property(e => e.ValidityRange)
            .HasColumnName("ValidityRange")
            .HasMaxLength(200);

        builder.Property(e => e.ProductName)
            .HasColumnName("ProductName")
            .HasMaxLength(200);

        builder.Property(e => e.BelegRole)
            .HasColumnName("BelegRole");

        builder.Property(e => e.ProductDetails)
            .HasColumnName("ProductDetails")
            .HasMaxLength(500);

        builder.Property(e => e.ArticleNumber)
            .HasColumnName("ArticleNumber")
            .HasMaxLength(100);

        builder.Property(e => e.BelegId)
            .HasColumnName("BelegId")
            .HasMaxLength(100);

        builder.Property(e => e.Class1Quantity)
            .HasColumnName("Class1Quantity");

        builder.Property(e => e.PriceClass1)
            .HasColumnName("PriceClass1");

        builder.Property(e => e.Class2Quantity)
            .HasColumnName("Class2Quantity");

        builder.Property(e => e.PriceClass2)
            .HasColumnName("PriceClass2");

        builder.Property(e => e.GratisQuantity)
            .HasColumnName("GratisQuantity");

        builder.Property(e => e.OwnQuantity)
            .HasColumnName("OwnQuantity");

        builder.Property(e => e.TaxPercentage)
            .HasColumnName("TaxPercentage")
            .HasMaxLength(50);

        builder.Property(e => e.TaxTotal)
            .HasColumnName("TaxTotal");

        builder.Property(e => e.CurrencyCash)
            .HasColumnName("CurrencyCash")
            .HasMaxLength(10);

        builder.Property(e => e.Cash)
            .HasColumnName("Cash");

        builder.Property(e => e.CreditCard)
            .HasColumnName("CreditCard");

        builder.Property(e => e.OnlinePayment)
            .HasColumnName("OnlinePayment");

        builder.Property(e => e.Refund)
            .HasColumnName("Refund");

        builder.Property(e => e.RefundReason)
            .HasColumnName("RefundReason")
            .HasMaxLength(500);

        builder.Property(e => e.CurrencyRate)
            .HasColumnName("CurrencyRate")
            .HasColumnType("numeric");

        builder.Property(e => e.DeviceImei)
            .HasColumnName("DeviceImei")
            .HasMaxLength(100);

        builder.Property(e => e.CreationDate)
            .HasColumnName("CreationDate")
            .HasColumnType("timestamp");

        builder.Property(e => e.UploadedTime)
            .HasColumnName("UploadedTime")
            .HasColumnType("timestamp");

        builder.Property(e => e.ModificationDate)
            .HasColumnName("ModificationDate")
            .HasColumnType("timestamp");

        builder.Property(e => e.RefundAttempt)
            .HasColumnName("RefundAttempt");

        builder.Property(e => e.QuittungImage)
            .HasColumnName("QuittungImage");

        builder.Property(e => e.IsTicketConfirmed)
            .HasColumnName("IsTicketConfirmed");

        builder.Property(e => e.Latitude)
            .HasColumnName("Latitude")
            .HasColumnType("numeric");

        builder.Property(e => e.Longitude)
            .HasColumnName("Longitude")
            .HasColumnType("numeric");

        builder.Property(e => e.SendEmail)
            .HasColumnName("SendEmail");

        builder.Property(e => e.Email)
            .HasColumnName("Email")
            .HasMaxLength(255);

        builder.Property(e => e.MailRetryNumber)
            .HasColumnName("MailRetryNumber");

        builder.Property(e => e.SentMailOK)
            .HasColumnName("SentMailOK")
            .HasColumnType("timestamp");

        builder.Property(e => e.OnlineTransactionId)
            .HasColumnName("OnlineTransactionId")
            .HasMaxLength(100);

        builder.Property(e => e.PrintingAttempts)
            .HasColumnName("printingAttemps");

        builder.Property(e => e.ServiceId)
            .HasColumnName("ServiceId")
            .HasMaxLength(100);

        builder.Property(e => e.PriceType)
            .HasColumnName("PriceType")
            .HasMaxLength(20);

        builder.Property(e => e.Exported)
            .HasColumnName("Exported")
            .HasColumnType("timestamp");

        builder.Property(e => e.Deleted)
            .HasColumnName("Deleted")
            .HasColumnType("timestamp");

        builder.Property(e => e.Balanced)
            .HasColumnName("Balanced")
            .HasColumnType("timestamp");

        builder.Property(e => e.CashChecked)
            .HasColumnName("CashChecked")
            .HasColumnType("timestamp");

        builder.Property(e => e.DtProcessed)
            .HasColumnName("dtProcessed")
            .HasColumnType("timestamp");

        builder.Property(e => e.DtProcessedRefund)
            .HasColumnName("dtProcessedRefund")
            .HasColumnType("timestamp");

        builder.Property(e => e.TicketDataObject)
            .HasColumnName("ticketDataObject");

        builder.Property(e => e.TicketNovaXml)
            .HasColumnName("ticketNOVAXML");

        builder.Property(e => e.RefundNovaXml)
            .HasColumnName("refundNOVAXML");

        builder.Property(e => e.RefundDataObject)
            .HasColumnName("refundDataObject");

        builder.Property(e => e.RefundServiceId)
            .HasColumnName("refundServiceId")
            .HasMaxLength(100);

        builder.Property(e => e.TicketLanguage)
            .HasColumnName("ticketLanguage")
            .HasMaxLength(10);

        builder.Property(e => e.VertriebsPunkt)
            .HasColumnName("vertriebsPunkt")
            .HasMaxLength(100);

        builder.Property(e => e.LeistungsVermittler)
            .HasColumnName("leistungsVermittler")
            .HasMaxLength(100);

        builder.Property(e => e.SellPlace)
            .HasColumnName("sellPlace")
            .HasMaxLength(100);

        builder.Property(e => e.DeviceNumber)
            .HasColumnName("deviceNumber")
            .HasMaxLength(100);

        builder.Property(e => e.Origin)
            .HasColumnName("origin")
            .HasMaxLength(200);

        builder.Property(e => e.Destination)
            .HasColumnName("destination")
            .HasMaxLength(200);

        builder.Property(e => e.Via1)
            .HasColumnName("via1")
            .HasMaxLength(100);

        builder.Property(e => e.Via2)
            .HasColumnName("via2")
            .HasMaxLength(100);

        builder.Property(e => e.Via3)
            .HasColumnName("via3")
            .HasMaxLength(100);

        builder.Property(e => e.Via4)
            .HasColumnName("via4")
            .HasMaxLength(100);

        builder.Property(e => e.PaymentMethodString)
            .HasColumnName("paymentMethodString")
            .HasMaxLength(100);

        builder.Property(e => e.RefundArticleNumber)
            .HasColumnName("refundArticleNumber")
            .HasMaxLength(100);

        builder.Property(e => e.RefundQuittungImage)
            .HasColumnName("RefundQuittungImage");

        // Navigation properties
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
