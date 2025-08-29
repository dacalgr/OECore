using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ConfigurationData
{
    [StringLength(64)]
    public string DataKey { get; set; } = string.Empty;
    
    public string? DataValue { get; set; }
}
