using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ConfigLog
{
    public int Id { get; set; }
    
    [StringLength(150)]
    public string? UserEmail { get; set; }
    
    [StringLength(50)]
    public string? UserUsername { get; set; }
    
    [StringLength(50)]
    public string? UserDisplayName { get; set; }
    
    [StringLength(100)]
    public string? EntityName { get; set; }
    
    [StringLength(100)]
    public string? EntityId { get; set; }
    
    public DateTime? Timestamp { get; set; }
    
    [StringLength(20)]
    public string? Operation { get; set; }
    
    public string? OldValues { get; set; }
    
    public string? NewValues { get; set; }
}
