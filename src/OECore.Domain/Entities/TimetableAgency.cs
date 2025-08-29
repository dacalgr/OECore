using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableAgency
{
    [Key]
    public string AgencyId { get; set; } = string.Empty;
    
    public string? AgencyName { get; set; }
    
    public string? AgencyUrl { get; set; }
    
    public string? AgencyTimezone { get; set; }
    
    public string? AgencyLang { get; set; }
    
    public string? AgencyPhone { get; set; }
    
    public string? AgencyFareUrl { get; set; }
    
    public string? AgencyEmail { get; set; }
    
    // Navigation property
    public virtual ICollection<TimetableRoute> Routes { get; set; } = new List<TimetableRoute>();
}
