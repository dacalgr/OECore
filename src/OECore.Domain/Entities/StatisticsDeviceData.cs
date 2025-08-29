using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class StatisticsDeviceData
{
    [Key]
    [StringLength(100)]
    public string DeviceId { get; set; } = string.Empty;
    
    [Key]
    [StringLength(100)]
    public string Imei { get; set; } = string.Empty;
    
    [Key]
    [StringLength(100)]
    public string Mac { get; set; } = string.Empty;
}
