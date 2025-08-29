using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ReasonSubcategoryConfiguration : IEntityTypeConfiguration<ReasonSubcategory>
{
    public void Configure(EntityTypeBuilder<ReasonSubcategory> builder)
    {
        builder.ToTable("tbl_CONFIG_ReasonsSubcategories");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TextDe)
            .HasColumnName("text_de");
            
        builder.Property(e => e.TextFr)
            .HasColumnName("text_fr");
            
        builder.Property(e => e.TextIt)
            .HasColumnName("text_it");
            
        builder.Property(e => e.TextEn)
            .HasColumnName("text_en");
            
        builder.Property(e => e.Code)
            .HasColumnName("code");
            
        builder.Property(e => e.Fee)
            .HasColumnName("fee");
            
        builder.Property(e => e.Forgery)
            .HasColumnName("forgery");
            
        builder.Property(e => e.Miscellaneus)
            .HasColumnName("miscellaneus");
            
        builder.Property(e => e.ParentId)
            .HasColumnName("parentId");
            
        builder.Property(e => e.Surcharge)
            .HasColumnName("surcharge");
            
        builder.Property(e => e.Fare)
            .HasColumnName("fare");
            
        builder.Property(e => e.CategoryId)
            .HasColumnName("categoryId");
            
        builder.Property(e => e.Abuse)
            .HasColumnName("abuse");
            
        builder.Property(e => e.TimePenalties)
            .HasColumnName("time_penalties");
            
        builder.Property(e => e.Total)
            .HasColumnName("total");
            
        builder.Property(e => e.CompanyId)
            .HasColumnName("companyId");
            
        builder.Property(e => e.Rank)
            .HasColumnName("rank");
            
        builder.Property(e => e.PrintContinue)
            .HasColumnName("print_continue");
            
        builder.Property(e => e.PrintContinue2)
            .HasColumnName("print_continue2");
            
        builder.Property(e => e.PrintSalesPoint)
            .HasColumnName("print_salesPoint");
            
        builder.Property(e => e.PrintLogo)
            .HasColumnName("print_logo");
            
        builder.Property(e => e.PrintPortal)
            .HasColumnName("print_portal");
            
        builder.Property(e => e.PrintSignature)
            .HasColumnName("print_signature");
            
        builder.Property(e => e.PrintRepeat)
            .HasColumnName("print_repeat");
            
        builder.Property(e => e.AllowComments)
            .HasColumnName("allowComments");
            
        builder.Property(e => e.PrintQr)
            .HasColumnName("print_QR");
            
        builder.Property(e => e.AbuseOptionId)
            .HasColumnName("abuseOptionId");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
            
        // Relationships
        builder.HasOne(e => e.AbuseOption)
            .WithMany()
            .HasForeignKey(e => e.AbuseOptionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
