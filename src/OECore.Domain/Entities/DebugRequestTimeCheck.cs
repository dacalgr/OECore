using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DebugRequestTimeCheck
{
    public int Id { get; set; }
    
    [Required(AllowEmptyStrings = true)]
    [StringLength(512)]
    public string RequestedResource { get; set; } = string.Empty;
    
    public string? QueryString { get; set; }
    
    public string? Headers { get; set; }
    
    public string? RequestBody { get; set; }
    
    public string? ResponseBody { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public double TotalSeconds { get; set; }
}
