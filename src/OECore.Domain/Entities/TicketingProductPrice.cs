using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingProductPrice
{
    public int IdProduct { get; set; }

    public int IdClass { get; set; }

    public double Price { get; set; }

    public double HalfPrice { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(255)]
    public string FqCodePrice { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(255)]
    public string FqCodeHalfPrice { get; set; } = string.Empty;

    public DateTime? DtDeleted { get; set; }

    public DateTime? DtModified { get; set; }

    // Navigation properties
    public TicketingClass? Class { get; set; }
    public TicketingProduct? Product { get; set; }
}
