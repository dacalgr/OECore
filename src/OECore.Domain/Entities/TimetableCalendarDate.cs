using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableCalendarDate
{
    [Key]
    public string ServiceId { get; set; } = string.Empty;
    
    public string? Date { get; set; }
    
    public string? ExceptionType { get; set; }
    
    // Navigation property
    public virtual TimetableCalendar? Service { get; set; }
}
