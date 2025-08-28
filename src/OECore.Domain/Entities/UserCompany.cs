namespace OECore.Domain.Entities;

public class UserCompany
{
    public long UserId { get; set; }
    public User User { get; set; } = null!;

    public long CompanyId { get; set; }
    public Company Company { get; set; } = null!;

    public long? ProfileId { get; set; }
    public Profile? Profile { get; set; }
}


