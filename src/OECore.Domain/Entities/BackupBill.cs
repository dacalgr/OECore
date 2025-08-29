using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BackupBill
{
    public int Id { get; set; }
    public int BillId { get; set; }
    
    [StringLength(10)]
    public string? Code { get; set; }
    
    [StringLength(400)]
    public string? NameDe { get; set; }
    
    [StringLength(400)]
    public string? NameFr { get; set; }
    
    [StringLength(400)]
    public string? NameIt { get; set; }
    
    public decimal? Surcharge { get; set; }
    public decimal? Fare { get; set; }
    public decimal? Fee { get; set; }
    public decimal? Abuse { get; set; }
    public decimal? Forgery { get; set; }
    public decimal? TimePenalties { get; set; }
    public decimal? Miscellaneus { get; set; }
    public decimal? Total { get; set; }
    
    public DateTime? DtCreated { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtPublished { get; set; }
}
