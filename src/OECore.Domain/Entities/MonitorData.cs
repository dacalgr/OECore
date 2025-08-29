using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class MonitorData
{
    public int Id { get; set; }
    
    [StringLength(4000)]
    public string? Message { get; set; }
    
    [StringLength(500)]
    public string? Type { get; set; }
    
    [StringLength(500)]
    public string? SubType { get; set; }
    
    [StringLength(1000)]
    public string? Cathegory { get; set; }
    
    [StringLength(1000)]
    public string? SubCathegory { get; set; }
    
    [StringLength(100)]
    public string? Result { get; set; }
    
    public DateTime Timestamp { get; set; }
}
