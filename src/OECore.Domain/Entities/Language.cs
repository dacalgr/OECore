using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Language
{
    public int Id { get; set; }
    
    [StringLength(10)]
    public string? Name { get; set; }
    
    [StringLength(10)]
    public string? ShortName { get; set; }
    
    // Navigation properties
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
