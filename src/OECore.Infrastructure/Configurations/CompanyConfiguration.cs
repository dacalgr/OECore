using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("company");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
        builder.Property(x => x.LegalName).HasMaxLength(256);
        builder.Property(x => x.CountryCode).HasMaxLength(2);
        builder.Property(x => x.IsActive).HasDefaultValue(true);

        builder.Property(x => x.CreatedAtUtc).HasColumnName("created_at").IsRequired();
        builder.Property(x => x.UpdatedAtUtc).HasColumnName("updated_at");

        builder.HasIndex(x => x.Name).IsUnique();
    }
}


