using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Theme
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? Name { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
