using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public int? Severity { get; set; }
    
    [StringLength(4000)]
    public string? Message { get; set; }
    
    [StringLength(500)]
    public string? MethodName { get; set; }
    
    [StringLength(500)]
    public string? Bookmark { get; set; }
    
    [StringLength(1000)]
    public string? FreeField1 { get; set; }
    
    [StringLength(1000)]
    public string? FreeField2 { get; set; }
    
    public long? Timestamp { get; set; }
}
