using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BalanceHistoryConfiguration : IEntityTypeConfiguration<BalanceHistory>
{
    public void Configure(EntityTypeBuilder<BalanceHistory> builder)
    {
        builder.ToTable("tblBalanceHistory");
        builder.HasKey(e => new { e.UserId, e.BalanceDay });
        
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
        
        builder.Property(e => e.BalanceDay)
            .HasColumnName("balanceDay")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.BalanceDayTicks)
            .HasColumnName("balanceDayTicks");
        
        builder.Property(e => e.DeviceId)
            .HasColumnName("deviceId")
            .HasMaxLength(100);
    }
}
