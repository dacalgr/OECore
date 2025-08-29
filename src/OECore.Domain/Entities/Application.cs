using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Application
{
    public int Id { get; set; }
    
    public int? ParentId { get; set; }
    
    [StringLength(50)]
    public string? AppId { get; set; }
    
    [StringLength(100)]
    public string? Prefix { get; set; }
    
    [StringLength(50)]
    public string? Accessory { get; set; }
    
    [StringLength(50)]
    public string? NameEn { get; set; }
    
    [StringLength(50)]
    public string? NameDe { get; set; }
    
    [StringLength(50)]
    public string? NameFr { get; set; }
    
    [StringLength(50)]
    public string? NameIt { get; set; }
    
    [StringLength(100)]
    public string? DescriptionEn { get; set; }
    
    [StringLength(100)]
    public string? DescriptionDe { get; set; }
    
    [StringLength(100)]
    public string? DescriptionFr { get; set; }
    
    [StringLength(100)]
    public string? DescriptionIt { get; set; }
    
    [StringLength(500)]
    public string? IconEn { get; set; }
    
    [StringLength(500)]
    public string? IconDe { get; set; }
    
    [StringLength(500)]
    public string? IconFr { get; set; }
    
    [StringLength(500)]
    public string? IconIt { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public virtual Application? Parent { get; set; }
    public virtual ICollection<Application> Children { get; set; } = new List<Application>();
}
