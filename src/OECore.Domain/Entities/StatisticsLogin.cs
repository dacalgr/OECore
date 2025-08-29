using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class StatisticsLogin
{
    public int Id { get; set; }
    
    public long? UserId { get; set; }
    
    public DateTime? Timestamp { get; set; }
    
    [StringLength(100)]
    public string? Device { get; set; }
    
    [StringLength(100)]
    public string? AppVersion { get; set; }
    
    [StringLength(100)]
    public string? DatabaseVersion { get; set; }
    
    [StringLength(100)]
    public string? ETicketAppVersion { get; set; }
    
    [StringLength(100)]
    public string? ETicketDatabaseVersion { get; set; }
    
    public decimal? Latitude { get; set; }
    
    public decimal? Longitude { get; set; }
    
    [StringLength(15)]
    public string? Imei { get; set; }
    
    [StringLength(17)]
    public string? Mac { get; set; }
    
    [StringLength(4000)]
    public string? Name { get; set; }
    
    [StringLength(4000)]
    public string? LastName { get; set; }
    
    [StringLength(50)]
    public string? PersonalNumber { get; set; }
    
    [StringLength(50)]
    public string? Operation { get; set; }
    
    // Navigation property
    public virtual User? User { get; set; }
}
