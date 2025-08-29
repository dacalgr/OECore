using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class EmailTextDestination
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? Name { get; set; }
    
    public DateTime? DtDeleted { get; set; }
}
