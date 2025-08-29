using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class PaymentMode
{
    public int Id { get; set; }
    
    [StringLength(200)]
    public string? Name { get; set; }
}
