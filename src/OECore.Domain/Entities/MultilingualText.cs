using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class MultilingualText
{
    public int Id { get; set; }
    
    [StringLength(30)]
    public string? Key { get; set; }
    
    [StringLength(3000)]
    public string? TextDe { get; set; }
    
    [StringLength(3000)]
    public string? TextFr { get; set; }
    
    [StringLength(3000)]
    public string? TextIt { get; set; }
    
    [StringLength(3000)]
    public string? TextEn { get; set; }
}
