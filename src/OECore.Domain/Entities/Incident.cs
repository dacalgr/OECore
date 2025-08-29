using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Incident
{
    public Guid Id { get; set; }
    public Guid? TurnId { get; set; }
    public Guid? TaskId { get; set; }
    public long? UserId { get; set; }
    public int? CardTypeId { get; set; }
    public int? CategoryCardTypeId { get; set; }
    
    [StringLength(50)]
    public string? QuitNo { get; set; }
    
    public long? FirmId { get; set; }
    public string? Image { get; set; }
    
    [StringLength(4000)]
    public string? Comments { get; set; }
    
    public string? Thumbnail { get; set; }
    public int? Step { get; set; }
    public Guid? ParentId { get; set; }
    public bool? Cancelled { get; set; }
    
    [StringLength(4000)]
    public string? CancelledReason { get; set; }
    
    public int? CancelledReasonId { get; set; }
    public int? AutoIncrement { get; set; }
    public bool ConfirmedWarningMailSent { get; set; }

    // Passenger data
    [StringLength(50)]
    public string? BehaviorCode { get; set; }
    
    [StringLength(4000)]
    public string? Name { get; set; }
    
    [StringLength(4000)]
    public string? Firstname { get; set; }
    
    [StringLength(4000)]
    public string? Address { get; set; }
    
    [StringLength(4000)]
    public string? Zip { get; set; }
    
    [StringLength(500)]
    public string? Email { get; set; }
    
    public DateTime? Birthdate { get; set; }
    
    [StringLength(50)]
    public string? BirthLand { get; set; }
    
    [StringLength(4000)]
    public string? Citizenship { get; set; }
    
    public int? TitleId { get; set; }
    
    [StringLength(4000)]
    public string? City { get; set; }
    
    [StringLength(4000)]
    public string? Country { get; set; }
    
    [StringLength(40)]
    public string? CountryCode { get; set; }
    
    [StringLength(4000)]
    public string? Extra { get; set; }
    
    [StringLength(50)]
    public string? ZemisNr { get; set; }
    
    public int? ResidencePermitId { get; set; }
    public bool? IsAnon { get; set; }
    
    [StringLength(40)]
    public string? Hausnummer { get; set; }
    
    [StringLength(50)]
    public string? CoAddress { get; set; }
    
    [StringLength(50)]
    public string? Telephone { get; set; }
    
    [StringLength(1000)]
    public string? AnonymousReason { get; set; }
    
    [StringLength(50)]
    public string? PersId { get; set; }
    
    [StringLength(50)]
    public string? HbkKey { get; set; }
    
    public bool Scanned { get; set; }
    public bool AmpDataModified { get; set; }
    
    [StringLength(25)]
    public string? PassengerPreferredLanguage { get; set; }

    // Tutor data
    [StringLength(4000)]
    public string? TutorName { get; set; }
    
    [StringLength(4000)]
    public string? TutorFirstname { get; set; }
    
    [StringLength(4000)]
    public string? TutorAddress { get; set; }
    
    [StringLength(4000)]
    public string? TutorZip { get; set; }
    
    [StringLength(500)]
    public string? TutorEmail { get; set; }
    
    [StringLength(50)]
    public string? TutorPhone { get; set; }
    
    public DateTime? TutorBirthdate { get; set; }
    
    [StringLength(4000)]
    public string? TutorCitizenship { get; set; }
    
    public int? TutorTitleId { get; set; }
    
    [StringLength(4000)]
    public string? TutorCity { get; set; }
    
    [StringLength(4000)]
    public string? TutorCountry { get; set; }
    
    [StringLength(40)]
    public string? TutorCountryCode { get; set; }
    
    [StringLength(4000)]
    public string? TutorExtra { get; set; }
    
    [StringLength(40)]
    public string? TutorHausnummer { get; set; }
    
    [StringLength(50)]
    public string? TutorCoAddress { get; set; }
    
    [StringLength(50)]
    public string? TutorPersId { get; set; }
    
    [StringLength(50)]
    public string? TutorHbkKey { get; set; }

    // Incident deployment
    public bool? SendSms { get; set; }
    public bool? MailRequestFlag { get; set; }
    public int MailNumber { get; set; }
    public bool? ReceiptPrinted { get; set; }
    public int PrintNumber { get; set; }
    public bool RefundAttempt { get; set; }
    public int QrGenerations { get; set; }
    public int QrDownloads { get; set; }
    public string? DownloadToken { get; set; }
    public DateTime? AlreadySentSms { get; set; }
    public DateTime? SentMailOk { get; set; }
    public int? MailRetryNumber { get; set; }
    
    [StringLength(5000)]
    public string? SmtpLastResponse { get; set; }

    // Dates
    public DateTime? StartTime { get; set; }
    
    [StringLength(100)]
    public string? Timezone { get; set; }
    
    public DateTime? Modified { get; set; }
    public DateTime? DtNotified { get; set; }
    public DateTime? ExportedToSap { get; set; }
    public DateTime? UploadedDate { get; set; }
    public DateTime? Deleted { get; set; }
    public long? StartTimeReceived { get; set; }
    public DateTime? ClosedDate { get; set; }
    public DateTime? LastModificationDate { get; set; }
    public DateTime? Balanced { get; set; }
    public DateTime? ControlTimeStamp { get; set; }
    public DateTime? CashChecked { get; set; }
    public DateTime? DtProcessed { get; set; }

    // Payment data
    public decimal? Remaining { get; set; }
    public decimal? Deduction { get; set; }
    public decimal? Cash { get; set; }
    public decimal? Total { get; set; }
    
    [StringLength(50)]
    public string? Currency { get; set; }
    
    public int? PaymentMode { get; set; }
    public decimal? Factor { get; set; }
    public decimal? Change { get; set; }
    public bool IsOnlinePaid { get; set; }
    
    [StringLength(1000)]
    public string? OnlineTransactionId { get; set; }
    
    public bool ConfirmedWithNoPayment { get; set; }
    public bool ConfirmedNoBackendAccess { get; set; }
    public bool ConfirmedNoPaymentProviderAccess { get; set; }
    public int PayrexxGatewayId { get; set; }
    public string? PaymentMethod { get; set; }

    // Incident location
    [StringLength(4000)]
    public string? Place { get; set; }
    
    [StringLength(1000)]
    public string? Route { get; set; }
    
    [StringLength(4000)]
    public string? Number { get; set; }
    
    [StringLength(1000)]
    public string? Station { get; set; }

    // Incident status
    public bool? IsOpen { get; set; }
    
    [StringLength(50)]
    public string? Zone { get; set; }
    
    [StringLength(200)]
    public string? Wagennummer { get; set; }
    
    public bool? ConfirmedLine { get; set; }
    
    [StringLength(4000)]
    public string? ConfirmedLineComments { get; set; }
    
    public int? Region { get; set; }
    
    [StringLength(100)]
    public string? RegionName { get; set; }
    
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    
    [StringLength(100)]
    public string? RouteNumber { get; set; }

    // Abuse
    public int? AbuseOption { get; set; }
    public int? ConfirmationOfPersonalDetailsOption { get; set; }
    public int? ContactPersonOption { get; set; }
    public string? ForgeryComment { get; set; }
    public int? TimeClarification { get; set; }
    public string? PersonalDetailsComment { get; set; }
    public bool? IsAbuse { get; set; }

    // Navigation properties
    public Company? Company { get; set; }
    public User? User { get; set; }
    public IncidentTask? IncidentTask { get; set; }
    public Turn? Turn { get; set; }
    public ICollection<IncidentImage> IncidentImages { get; set; } = new List<IncidentImage>();
    public ICollection<IncidentExportReport> ExportReports { get; set; } = new List<IncidentExportReport>();
}
