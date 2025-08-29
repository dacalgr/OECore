using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class StatisticsUpload
{
    public int Id { get; set; }
    
    public long? UserId { get; set; }
    
    public DateTime? Timestamp { get; set; }
    
    [StringLength(100)]
    public string? Type { get; set; }
    
    [StringLength(100)]
    public string? Device { get; set; }
    
    [StringLength(100)]
    public string? AppVersion { get; set; }
    
    [StringLength(100)]
    public string? DatabaseVersion { get; set; }
    
    public Guid? ItemGuid { get; set; }
    
    [StringLength(15)]
    public string? Imei { get; set; }
    
    [StringLength(17)]
    public string? Mac { get; set; }
    
    [StringLength(50)]
    public string? PersonalNumber { get; set; }
    
    [StringLength(4000)]
    public string? Name { get; set; }
    
    [StringLength(4000)]
    public string? LastName { get; set; }
    
    // Navigation property
    public virtual User? User { get; set; }
}
