using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingClass
{
    public int Id { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameEN { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameIT { get; set; } = string.Empty;

    public DateTime? DtModified { get; set; }

    // Navigation properties
    public ICollection<TicketingProductPrice> ProductPrices { get; set; } = new List<TicketingProductPrice>();
}
