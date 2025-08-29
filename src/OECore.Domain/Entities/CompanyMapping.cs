using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class CompanyMapping
{
    public int CompanyId { get; set; }
    
    [StringLength(50)]
    public string CompanyCode { get; set; } = string.Empty;
    
    public int? NewCompanyId { get; set; }
}
