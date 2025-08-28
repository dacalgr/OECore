namespace OECore.Domain.Entities;

public class CompanyRegion
{
    public long CompanyId { get; set; }
    public Company Company { get; set; } = null!;

    public long RegionId { get; set; }
    public Region Region { get; set; } = null!;
}


