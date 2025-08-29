using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class NovaTicket
{
    public Guid Id { get; set; }

    public long UserId { get; set; }

    [StringLength(100)]
    public string? PersonalNumber { get; set; }

    [StringLength(100)]
    public string? LaufNumber { get; set; }

    [StringLength(50)]
    public string? CompanyShortName { get; set; }

    [StringLength(100)]
    public string? Region { get; set; }

    [StringLength(200)]
    public string? ValidityRange { get; set; }

    [StringLength(200)]
    public string? ProductName { get; set; }

    public int BelegRole { get; set; }

    [StringLength(500)]
    public string? ProductDetails { get; set; }

    [StringLength(100)]
    public string? ArticleNumber { get; set; }

    [StringLength(100)]
    public string? BelegId { get; set; }

    public int Class1Quantity { get; set; }

    public double PriceClass1 { get; set; }

    public int Class2Quantity { get; set; }

    public double PriceClass2 { get; set; }

    public int GratisQuantity { get; set; }

    public int OwnQuantity { get; set; }

    [StringLength(50)]
    public string? TaxPercentage { get; set; }

    public double TaxTotal { get; set; }

    [StringLength(10)]
    public string? CurrencyCash { get; set; }

    public double Cash { get; set; }

    public double CreditCard { get; set; }

    public double OnlinePayment { get; set; }

    public bool Refund { get; set; }

    [StringLength(500)]
    public string? RefundReason { get; set; }

    public decimal CurrencyRate { get; set; }

    [StringLength(100)]
    public string? DeviceImei { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UploadedTime { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool RefundAttempt { get; set; }

    public string? QuittungImage { get; set; }

    public bool IsTicketConfirmed { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public bool SendEmail { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    public int MailRetryNumber { get; set; }

    public DateTime? SentMailOK { get; set; }

    [StringLength(100)]
    public string? OnlineTransactionId { get; set; }

    public int PrintingAttempts { get; set; }

    [StringLength(100)]
    public string? ServiceId { get; set; }

    [StringLength(20)]
    public string? PriceType { get; set; }

    public DateTime? Exported { get; set; }

    public DateTime? Deleted { get; set; }

    public DateTime? Balanced { get; set; }

    public DateTime? CashChecked { get; set; }

    public DateTime? DtProcessed { get; set; }

    public DateTime? DtProcessedRefund { get; set; }

    public string? TicketDataObject { get; set; }

    public string? TicketNovaXml { get; set; }

    public string? RefundNovaXml { get; set; }

    public string? RefundDataObject { get; set; }

    [StringLength(100)]
    public string? RefundServiceId { get; set; }

    [StringLength(10)]
    public string? TicketLanguage { get; set; }

    [StringLength(100)]
    public string? VertriebsPunkt { get; set; }

    [StringLength(100)]
    public string? LeistungsVermittler { get; set; }

    [StringLength(100)]
    public string? SellPlace { get; set; }

    [StringLength(100)]
    public string? DeviceNumber { get; set; }

    [StringLength(200)]
    public string? Origin { get; set; }

    [StringLength(200)]
    public string? Destination { get; set; }

    [StringLength(100)]
    public string? Via1 { get; set; }

    [StringLength(100)]
    public string? Via2 { get; set; }

    [StringLength(100)]
    public string? Via3 { get; set; }

    [StringLength(100)]
    public string? Via4 { get; set; }

    [StringLength(100)]
    public string? PaymentMethodString { get; set; }

    [StringLength(100)]
    public string? RefundArticleNumber { get; set; }

    public string? RefundQuittungImage { get; set; }

    // Navigation properties
    public User? User { get; set; }
}
