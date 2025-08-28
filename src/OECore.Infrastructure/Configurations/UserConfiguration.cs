using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
        builder.Property(x => x.Username).HasMaxLength(128).IsRequired();
        builder.Property(x => x.DisplayName).HasMaxLength(256);

        builder.Property(x => x.CreatedAtUtc).HasColumnName("created_at").IsRequired();
        builder.Property(x => x.UpdatedAtUtc).HasColumnName("updated_at");

        builder.Property(x => x.ValidFromUtc).HasColumnName("valid_from_utc");
        builder.Property(x => x.ValidToUtc).HasColumnName("valid_to_utc");

        builder.Property(x => x.FirstName).HasMaxLength(128);
        builder.Property(x => x.LastName).HasMaxLength(128);
        builder.Property(x => x.Postalcode).HasMaxLength(16);
        builder.Property(x => x.Address).HasMaxLength(256);
        builder.Property(x => x.Address_Extra).HasMaxLength(256).HasColumnName("address_extra");
        builder.Property(x => x.Housenumber).HasMaxLength(32);
        builder.Property(x => x.City).HasMaxLength(128);
        builder.Property(x => x.Country).HasMaxLength(2);
        builder.Property(x => x.Phone).HasMaxLength(64);

        builder.Property(x => x.PersonalNumber).HasMaxLength(64);
        builder.Property(x => x.DeletedUTC).HasColumnName("deleted_utc");
        builder.Property(x => x.LastPasswordChangeUTC).HasColumnName("last_password_change_utc");
        builder.Property(x => x.HashPasswordSalt).HasMaxLength(512).HasColumnName("hash_password_salt");
        builder.Property(x => x.ForceResetPassword).HasDefaultValue(false).HasColumnName("force_reset_password");
        builder.Property(x => x.LastLoginUTC).HasColumnName("last_login_utc");
        builder.Property(x => x.LastBalanceUTC).HasColumnName("last_balance_utc");

        builder.HasOne(x => x.EmployerCompany)
            .WithMany()
            .HasForeignKey(x => x.EmployerCompanyId)
            .HasConstraintName("fk_user_employer_company")
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasIndex(x => x.Username).IsUnique();
    }
}


