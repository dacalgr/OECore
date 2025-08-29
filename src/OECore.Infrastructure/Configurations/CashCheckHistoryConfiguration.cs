using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CashCheckHistoryConfiguration : IEntityTypeConfiguration<CashCheckHistory>
{
    public void Configure(EntityTypeBuilder<CashCheckHistory> builder)
    {
        builder.ToTable("tblCashCheckHistory");
        builder.HasKey(e => new { e.UserId, e.CashCheckDay });
        
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
        
        builder.Property(e => e.CashCheckDay)
            .HasColumnName("cashCheckDay")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.CaschCheckDayTicks)
            .HasColumnName("caschCheckDayTicks");
    }
}
