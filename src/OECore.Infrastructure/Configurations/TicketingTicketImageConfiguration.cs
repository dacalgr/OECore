using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TicketingTicketImageConfiguration : IEntityTypeConfiguration<TicketingTicketImage>
{
    public void Configure(EntityTypeBuilder<TicketingTicketImage> builder)
    {
        builder.ToTable("tbl_TICKETING_TicketsImages");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.TicketId)
            .HasColumnName("ticketID");

        builder.Property(e => e.ImageContent)
            .HasColumnName("imageContent");

        builder.Property(e => e.IsQuittung)
            .HasColumnName("isQuittung");

        // Navigation properties
        builder.HasOne(e => e.Ticket)
            .WithMany(e => e.TicketImages)
            .HasForeignKey(e => e.TicketId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
