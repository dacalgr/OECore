namespace OECore.Domain.Entities;

public class Profile
{
    public long Id { get; set; }
    public string ShortName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime? DeletedUTC { get; set; }
}


