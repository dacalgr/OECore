using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class CleanJobsConfiguration
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? Days { get; set; }
    
    public bool Monthly { get; set; }
    
    public DateTime? LastExecution { get; set; }
    
    public DateTime? NextExecution { get; set; }
}
