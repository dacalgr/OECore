using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class UserCompanyConfiguration : IEntityTypeConfiguration<UserCompany>
{
    public void Configure(EntityTypeBuilder<UserCompany> builder)
    {
        builder.ToTable("user_company");

        builder.HasKey(x => new { x.UserId, x.CompanyId });

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserCompanies)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Company)
            .WithMany(x => x.UserCompanies)
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Profile)
            .WithMany()
            .HasForeignKey(x => x.ProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.ProfileId);
    }
}


