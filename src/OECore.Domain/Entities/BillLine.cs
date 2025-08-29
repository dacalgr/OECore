using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BillLine
{
    public int Id { get; set; }
    public int? BillId { get; set; }
    public decimal? Surcharge { get; set; }
    public decimal? Fare { get; set; }
    public decimal? Fee { get; set; }
    public decimal? Abuse { get; set; }
    public decimal? Forgery { get; set; }
    public decimal? TimePenalties { get; set; }
    public decimal? Miscellaneus { get; set; }
    public decimal? Total { get; set; }
    public Guid? IncidentId { get; set; }
    public Guid? HistoricalIncidentId { get; set; }
    
    [StringLength(4000)]
    public string? Comments { get; set; }
    
    public DateTime? LastModificationDate { get; set; }
}
