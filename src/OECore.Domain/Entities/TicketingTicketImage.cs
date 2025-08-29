using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingTicketImage
{
    public int Id { get; set; }

    public Guid TicketId { get; set; }

    public string? ImageContent { get; set; }

    public bool IsQuittung { get; set; }

    // Navigation properties
    public TicketingTicket? Ticket { get; set; }
}
