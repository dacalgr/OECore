using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Widget
{
    public int Id { get; set; }
    
    public int? ApplicationId { get; set; }
    
    [StringLength(50)]
    public string? WidgetId { get; set; }
    
    [StringLength(50)]
    public string? Title { get; set; }
    
    [StringLength(50)]
    public string? NameEn { get; set; }
    
    [StringLength(50)]
    public string? NameDe { get; set; }
    
    [StringLength(50)]
    public string? NameFr { get; set; }
    
    [StringLength(50)]
    public string? NameIt { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation property
    public virtual Application? Application { get; set; }
}
