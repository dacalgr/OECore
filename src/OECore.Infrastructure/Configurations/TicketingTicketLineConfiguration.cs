using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingTicketLineConfiguration : IEntityTypeConfiguration<TicketingTicketLine>
{
    public void Configure(EntityTypeBuilder<TicketingTicketLine> builder)
    {
        builder.ToTable("tbl_TICKETING_TicketsLines");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.TicketId)
            .HasColumnName("ticketID");

        builder.Property(e => e.Amount)
            .HasColumnName("amount");

        builder.Property(e => e.Description)
            .HasColumnName("description")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.Price)
            .HasColumnName("price")
            .HasColumnType("numeric");

        builder.Property(e => e.Currency)
            .HasColumnName("currency");

        builder.Property(e => e.Type)
            .HasColumnName("type");

        builder.Property(e => e.FqCode)
            .HasColumnName("fqCode")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(e => e.QuittungJson)
            .HasColumnName("quittungJSON");

        builder.Property(e => e.QuittungPrice)
            .HasColumnName("quittungPrice");

        // Navigation properties
        builder.HasOne(e => e.Ticket)
            .WithMany(e => e.TicketLines)
            .HasForeignKey(e => e.TicketId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
