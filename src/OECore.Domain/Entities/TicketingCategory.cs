using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingCategory
{
    public int Id { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string NameDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string NameFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string NameIT { get; set; } = string.Empty;

    public bool MustOpenMnc { get; set; }

    public DateTime? DtDeleted { get; set; }

    public int Rank { get; set; }

    public DateTime? DtModified { get; set; }

    // Navigation properties
    public ICollection<TicketingProduct> Products { get; set; } = new List<TicketingProduct>();
    public ICollection<TicketingTicket> Tickets { get; set; } = new List<TicketingTicket>();
}
