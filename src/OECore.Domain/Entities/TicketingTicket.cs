using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingTicket
{
    public Guid Id { get; set; }

    public long UserId { get; set; }

    public long CompanyId { get; set; }

    public int CategoryId { get; set; }

    public int ProductId { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(512)]
    public string Company { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Product { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string FreeText { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(1024)]
    public string DeletedReason { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(8)]
    public string Class { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Details { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Region { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Reference { get; set; } = string.Empty;

    public DateTime? TimeStamp { get; set; }

    public DateTime? Uploaded { get; set; }

    public DateTime? Exported { get; set; }

    public DateTime? Deleted { get; set; }

    public DateTime? Balanced { get; set; }

    public DateTime? DtProcessed { get; set; }

    public int? PrintMode { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(16)]
    public string DeviceImei { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(12)]
    public string Laufnummer { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BelegId { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Kundennummer { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Lastname { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Birthdate { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Currency { get; set; } = string.Empty;

    [StringLength(50)]
    public string? BaseCardNumber { get; set; }

    public int? ClassId { get; set; }

    public int? RegionId { get; set; }

    public int? Payment { get; set; }

    public float? CurrencyRate { get; set; }

    public DateTime? Exported_ { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public DateTime? CashChecked { get; set; }

    [StringLength(1000)]
    public string? OnlineTransactionId { get; set; }

    public bool SendEmail { get; set; }

    [StringLength(400)]
    public string? Email { get; set; }

    public int MailRetryNumber { get; set; }

    public DateTime? SentMailOk { get; set; }

    public bool ConfirmedNoBackendAccess { get; set; }

    public bool ConfirmedNoPaymentProviderAccess { get; set; }

    public bool ConfirmedWithNoPayment { get; set; }

    public int PayrexxGatewayId { get; set; }

    public bool RefundAttempt { get; set; }

    public bool IsTicketConfirmed { get; set; }

    public int QrGenerations { get; set; }

    public int QrDownloads { get; set; }

    public string? DownloadToken { get; set; }

    // Navigation properties
    public User? User { get; set; }
    public Company? CompanyEntity { get; set; }
    public TicketingCategory? Category { get; set; }
    public TicketingProduct? ProductEntity { get; set; }
    public ICollection<TicketingTicketLine> TicketLines { get; set; } = new List<TicketingTicketLine>();
    public ICollection<TicketingTicketImage> TicketImages { get; set; } = new List<TicketingTicketImage>();
}
