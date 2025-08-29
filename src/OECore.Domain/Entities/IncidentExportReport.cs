using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class IncidentExportReport
{
    public Guid IncidentId { get; set; }
    
    [StringLength(150)]
    public string? Quittungsnummer { get; set; }
    
    public int? Laufnummer { get; set; }
    public long? UserId { get; set; }
    
    [StringLength(500)]
    public string? PersonalNummer { get; set; }
    
    public int? PartnerTuId { get; set; }
    
    [StringLength(80)]
    public string? PartnerTu { get; set; }
    
    public int? Kontrollart { get; set; }
    
    [StringLength(160)]
    public string? Linie { get; set; }
    
    [StringLength(100)]
    public string? LinieNr { get; set; }
    
    [StringLength(256)]
    public string? Richtung { get; set; }
    
    [StringLength(256)]
    public string? Kontrollhaltestelle { get; set; }
    
    [StringLength(80)]
    public string? Strafantragscode { get; set; }
    
    public DateTime? Kontrolldatum { get; set; }
    
    [StringLength(10)]
    public string? GeschlechtFahrgast { get; set; }
    
    [StringLength(500)]
    public string? NachnameFahrgast { get; set; }
    
    [StringLength(500)]
    public string? VornameFahrgast { get; set; }
    
    public DateTime? GeburtsdatumFahrgast { get; set; }
    
    [StringLength(500)]
    public string? WohnortFahrgast { get; set; }
    
    [StringLength(500)]
    public string? StrasseFahrgast { get; set; }
    
    [StringLength(500)]
    public string? HausnummerFahrgast { get; set; }
    
    [StringLength(20)]
    public string? WohnlandFahrgast { get; set; }
    
    [StringLength(500)]
    public string? PostleitzahlFahrgast { get; set; }
    
    [StringLength(500)]
    public string? AdresseFahrgast { get; set; }
    
    [StringLength(500)]
    public string? ZusatzadresseFahrgast { get; set; }
    
    [StringLength(500)]
    public string? BürgerortFahrgast { get; set; }
    
    [StringLength(64)]
    public string? MailAdresse { get; set; }
    
    [StringLength(160)]
    public string? MobileNummer { get; set; }
    
    [StringLength(10)]
    public string? GeschlechtErzieher { get; set; }
    
    [StringLength(500)]
    public string? NachnameErzieher { get; set; }
    
    [StringLength(500)]
    public string? VornameErzieher { get; set; }
    
    [StringLength(500)]
    public string? AdresseErzieher { get; set; }
    
    [StringLength(500)]
    public string? WohnortErzieher { get; set; }
    
    [StringLength(500)]
    public string? WohnlandErzieher { get; set; }
    
    [StringLength(500)]
    public string? StrasseErzieher { get; set; }
    
    [StringLength(500)]
    public string? HausnummerErzieher { get; set; }
    
    [StringLength(40)]
    public string? PostleitzahlErzieher { get; set; }
    
    [StringLength(500)]
    public string? ZusatzadresseErzieher { get; set; }
    
    [StringLength(500)]
    public string? TutorEmail { get; set; }
    
    [StringLength(50)]
    public string? TutorPhone { get; set; }
    
    [StringLength(30)]
    public string? Ausweisart { get; set; }
    
    [StringLength(500)]
    public string? Ausweisnummer { get; set; }
    
    [StringLength(500)]
    public string? Zemisnummer { get; set; }
    
    [StringLength(500)]
    public string? AusstellungsortDesAusweises { get; set; }
    
    [StringLength(500)]
    public string? Beanstandungsgrund1 { get; set; }
    
    [StringLength(500)]
    public string? Beanstandungsgrund2 { get; set; }
    
    [StringLength(500)]
    public string? Beanstandungsgrund3 { get; set; }
    
    [StringLength(500)]
    public string? Beanstandungsgrund4 { get; set; }
    
    [StringLength(30)]
    public string? Währung { get; set; }
    
    public decimal? Wechselkurs { get; set; }
    public decimal? BarzahlungInChf { get; set; }
    public decimal? BarzahlungInFremdwahrung { get; set; }
    public decimal? Kreditkartenzahlung { get; set; }
    public decimal? Onlinekartenzahlung { get; set; }
    public decimal? Grundgebühr { get; set; }
    public decimal? Fahrpreispauschale { get; set; }
    public decimal? Bearbeitungssgebuhr { get; set; }
    public decimal? Missbrauchsgebuhr { get; set; }
    public decimal? Falschungsgebühr { get; set; }
    public decimal? Zeitzuschlagsgebuhr { get; set; }
    public decimal? DiverseGebuhren { get; set; }
    public decimal? RuckgeldInChf { get; set; }
    
    [StringLength(20)]
    public string? VerhaltenKunde1 { get; set; }
    
    [StringLength(4000)]
    public string? BemerkungKontrolleur { get; set; }
    
    public bool? Storno { get; set; }
    
    [StringLength(500)]
    public string? BegrundungStorno { get; set; }
    
    [StringLength(500)]
    public string? Zone { get; set; }
    
    [StringLength(500)]
    public string? Wagennummer { get; set; }
    
    public DateTime? ExportTime { get; set; }
    public DateTime? ExportedToCsv { get; set; }
    
    [StringLength(500)]
    public string? Domain { get; set; }
    
    [StringLength(20)]
    public string? CompanyCode { get; set; }
    
    public decimal? Total { get; set; }
    
    [StringLength(500)]
    public string? Name { get; set; }
    
    [StringLength(500)]
    public string? LastName { get; set; }
    
    public long? EmployerId { get; set; }
    
    [StringLength(100)]
    public string? EmployerName { get; set; }
    
    public DateTime? ControlTimeStamp { get; set; }
    
    [StringLength(50)]
    public string? PersId { get; set; }
    
    [StringLength(50)]
    public string? HbkKey { get; set; }
    
    [StringLength(50)]
    public string? TutorPersId { get; set; }
    
    [StringLength(50)]
    public string? TutorHbkKey { get; set; }
    
    [StringLength(1000)]
    public string? Begrundung1erFall { get; set; }
    
    [StringLength(500)]
    public string? AbuseOption { get; set; }
    
    [StringLength(500)]
    public string? ConfirmationOfPersonalDetailsOption { get; set; }
    
    [StringLength(500)]
    public string? ContactPersonOption { get; set; }
    
    [StringLength(500)]
    public string? ForgeryComment { get; set; }
    
    public int? TimeClarification { get; set; }
    
    [StringLength(500)]
    public string? PersonalDetailsComment { get; set; }
    
    [StringLength(10)]
    public string? PassengerPreferredLanguage { get; set; }
    
    public bool ConfirmedNoBackendAccess { get; set; }
    public bool ConfirmedNoPaymentProviderAccess { get; set; }
    public bool ConfirmedWithNoPayment { get; set; }
    public int PayrexxGatewayId { get; set; }
    public bool RefundAttempt { get; set; }
    public int QrGenerations { get; set; }
    public int QrDownloads { get; set; }
    public int PrintingAttempts { get; set; }
    public int MailSendings { get; set; }

    // Navigation property
    public Incident? Incident { get; set; }
}
