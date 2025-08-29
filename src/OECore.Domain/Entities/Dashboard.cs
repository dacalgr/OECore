using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Dashboard
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? Name { get; set; }
    
    public int? ThemeId { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public virtual Theme? Theme { get; set; }
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
