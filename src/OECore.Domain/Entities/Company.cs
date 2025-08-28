namespace OECore.Domain.Entities;

public class Company
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? LegalName { get; set; }
    public string? CountryCode { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }

    public ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
    public ICollection<CompanyRegion> CompanyRegions { get; set; } = new List<CompanyRegion>();
}


