using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BackupCompany
{
    public int Id { get; set; }
    public int? CompanyId { get; set; }
    
    [StringLength(50)]
    public string? ShortName { get; set; }
    
    [StringLength(512)]
    public string? Name { get; set; }
    
    public DateTime? DtCreated { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtDeleted { get; set; }
    public int? Region { get; set; }
    
    [StringLength(50)]
    public string? DomainIncident { get; set; }
    
    [StringLength(50)]
    public string? DomainPicture { get; set; }
    
    [StringLength(50)]
    public string? DomainTask { get; set; }
    
    [StringLength(50)]
    public string? DomainTicketsales { get; set; }
    
    [StringLength(512)]
    public string? EmailBody { get; set; }
    
    [StringLength(512)]
    public string? EmailSalutation { get; set; }
    
    [StringLength(512)]
    public string? EmailIntroduction { get; set; }
    
    [StringLength(512)]
    public string? EmailRepeat { get; set; }
    
    [StringLength(512)]
    public string? EmailContinue { get; set; }
    
    [StringLength(512)]
    public string? EmailPresentation { get; set; }
    
    [StringLength(512)]
    public string? EmailPortal { get; set; }
    
    [StringLength(512)]
    public string? LogoUrl { get; set; }
    
    [StringLength(10)]
    public string? Language { get; set; }
    
    [StringLength(50)]
    public string? Mwst { get; set; }
    
    [StringLength(50)]
    public string? VoeVtuCode { get; set; }
    
    [StringLength(50)]
    public string? VoeTarifVerbundCode { get; set; }
    
    public int? AddQr { get; set; }
    
    [StringLength(512)]
    public string? PrintLogo { get; set; }
    
    [StringLength(50)]
    public string? ShortNameX { get; set; }
    
    public DateTime? DtPublished { get; set; }
    public bool? EnableSendIncidentBySms { get; set; }
    public bool? EnableSendIncidentByEmail { get; set; }
    
    [StringLength(50)]
    public string? MwstEn { get; set; }
    
    [StringLength(50)]
    public string? MwstDe { get; set; }
    
    [StringLength(50)]
    public string? MwstFr { get; set; }
    
    [StringLength(50)]
    public string? MwstIt { get; set; }
    
    public decimal? CurrencyExchangeChfEur { get; set; }
    
    [StringLength(512)]
    public string? EmailLogo { get; set; }
    
    [StringLength(512)]
    public string? AddressInReceipt { get; set; }
}
