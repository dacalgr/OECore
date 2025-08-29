using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class NovaProductData
{
    public int Id { get; set; }

    [StringLength(100)]
    public string? Verbund { get; set; }

    [StringLength(100)]
    public string? ProductNumber { get; set; }

    [StringLength(500)]
    public string? DefaultText { get; set; }

    [StringLength(500)]
    public string? DeText { get; set; }

    [StringLength(500)]
    public string? FrText { get; set; }

    [StringLength(500)]
    public string? ItText { get; set; }

    [StringLength(500)]
    public string? EnText { get; set; }

    [StringLength(100)]
    public string? DisplayGroup { get; set; }

    [StringLength(100)]
    public string? TemplateId { get; set; }

    public bool IsProductBasedPurchase { get; set; }

    // Navigation properties
    public ICollection<NovaCompanyProductData> CompanyProducts { get; set; } = new List<NovaCompanyProductData>();
}

public class NovaCompanyProductData
{
    public int Id { get; set; }

    public int NovaProductDataId { get; set; }

    public long CompanyId { get; set; }

    // Navigation properties
    public NovaProductData? NovaProductData { get; set; }
    public Company? Company { get; set; }
}
