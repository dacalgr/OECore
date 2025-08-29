using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BalanceHistory
{
    public int UserId { get; set; }
    public DateTime BalanceDay { get; set; }
    public long? BalanceDayTicks { get; set; }
    
    [StringLength(100)]
    public string? DeviceId { get; set; }
}
