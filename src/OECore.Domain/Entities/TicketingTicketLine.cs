using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingTicketLine
{
    public int Id { get; set; }

    public Guid TicketId { get; set; }

    public int Amount { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Currency { get; set; }

    public int Type { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(255)]
    public string FqCode { get; set; } = string.Empty;

    public string? QuittungJson { get; set; }

    public decimal? QuittungPrice { get; set; }

    // Navigation properties
    public TicketingTicket? Ticket { get; set; }
}
