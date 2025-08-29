using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableCalendar
{
    [Key]
    public string ServiceId { get; set; } = string.Empty;
    
    public string? Monday { get; set; }
    
    public string? Tuesday { get; set; }
    
    public string? Wednesday { get; set; }
    
    public string? Thursday { get; set; }
    
    public string? Friday { get; set; }
    
    public string? Saturday { get; set; }
    
    public string? Sunday { get; set; }
    
    public string? StartDate { get; set; }
    
    public string? EndDate { get; set; }
    
    // Navigation properties
    public virtual ICollection<TimetableTrip> Trips { get; set; } = new List<TimetableTrip>();
    public virtual ICollection<TimetableCalendarDate> CalendarDates { get; set; } = new List<TimetableCalendarDate>();
}
