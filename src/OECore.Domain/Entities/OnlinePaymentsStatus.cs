using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class OnlinePaymentsStatus
{
    public int Id { get; set; }
    
    [StringLength(150)]
    public string? ReferenceId { get; set; }
    
    [StringLength(100)]
    public string? EntityId { get; set; }
    
    public DateTime? PaymentDate { get; set; }
    
    [StringLength(100)]
    public string? EntityType { get; set; }
    
    [StringLength(100)]
    public string? Status { get; set; }
    
    [StringLength(250)]
    public string? TransactionId { get; set; }
}
