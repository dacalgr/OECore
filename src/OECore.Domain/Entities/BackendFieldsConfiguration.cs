using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BackendFieldsConfiguration
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? ViewName { get; set; }
    
    public string? JsonFields { get; set; }
    
    public string? JsonFieldsFr { get; set; }
    
    public string? JsonFieldsIt { get; set; }
    
    public string? JsonFieldsEn { get; set; }
}
