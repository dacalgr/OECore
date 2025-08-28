namespace OECore.Domain.Entities;

public class User
{
    public long Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }

    public DateTime? ValidFromUtc { get; set; }
    public DateTime? ValidToUtc { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Postalcode { get; set; }
    public string? Address { get; set; }
    public string? Address_Extra { get; set; }
    public string? Housenumber { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public bool IsActive
        => (!ValidFromUtc.HasValue || ValidFromUtc.Value <= DateTime.UtcNow)
           && (!ValidToUtc.HasValue || ValidToUtc.Value > DateTime.UtcNow);

    public string? PersonalNumber { get; set; }

    public long? EmployerCompanyId { get; set; }
    public Company? EmployerCompany { get; set; }

    public DateTime? DeletedUTC { get; set; }
    public DateTime? LastPasswordChangeUTC { get; set; }
    public string? HashPasswordSalt { get; set; }
    public bool ForceResetPassword { get; set; }
    public DateTime? LastLoginUTC { get; set; }
    public DateTime? LastBalanceUTC { get; set; }

    public ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
}


