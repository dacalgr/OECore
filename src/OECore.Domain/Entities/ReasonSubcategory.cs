using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ReasonSubcategory
{
    public int Id { get; set; }
    
    public string? TextDe { get; set; }
    
    public string? TextFr { get; set; }
    
    public string? TextIt { get; set; }
    
    public string? TextEn { get; set; }
    
    public string? Code { get; set; }
    
    public float? Fee { get; set; }
    
    public float? Forgery { get; set; }
    
    public float? Miscellaneus { get; set; }
    
    public int? ParentId { get; set; }
    
    public float? Surcharge { get; set; }
    
    public float? Fare { get; set; }
    
    public int? CategoryId { get; set; }
    
    public float? Abuse { get; set; }
    
    public float? TimePenalties { get; set; }
    
    public float? Total { get; set; }
    
    public int? CompanyId { get; set; }
    
    public int? Rank { get; set; }
    
    public int? PrintContinue { get; set; }
    
    public int? PrintContinue2 { get; set; }
    
    public int? PrintSalesPoint { get; set; }
    
    public int? PrintLogo { get; set; }
    
    public int? PrintPortal { get; set; }
    
    public int? PrintSignature { get; set; }
    
    public int? PrintRepeat { get; set; }
    
    public int? AllowComments { get; set; }
    
    public int? PrintQr { get; set; }
    
    public int? AbuseOptionId { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
    
    // Navigation property
    public virtual AbuseOption? AbuseOption { get; set; }
}
