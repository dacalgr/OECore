using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class PayrexxPayment
{
    public Guid Id { get; set; }
    
    [StringLength(200)]
    public string? EntityType { get; set; }
    
    [StringLength(200)]
    public string? TransactionId { get; set; }
    
    [StringLength(200)]
    public string? Status { get; set; }
    
    [StringLength(200)]
    public string? Psp { get; set; }
    
    public DateTime? LastUpdateTime { get; set; }
}
