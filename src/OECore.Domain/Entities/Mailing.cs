using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Mailing
{
    public int Id { get; set; }
    
    [StringLength(500)]
    public string To { get; set; } = string.Empty;
    
    [StringLength(2000)]
    public string Body { get; set; } = string.Empty;
    
    [StringLength(20)]
    public string Type { get; set; } = string.Empty;
    
    [StringLength(20)]
    public string Domain { get; set; } = string.Empty;
    
    public Guid? EntityId { get; set; }
    public DateTime? DtCreated { get; set; }
    public DateTime? DtSendTime { get; set; }
}
