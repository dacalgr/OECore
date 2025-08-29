using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TicketingProduct
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string NameIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string FreeTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string FreeTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string FreeTextIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(512)]
    public string CommentsDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(512)]
    public string CommentsFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(512)]
    public string CommentsIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ResponsibleDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ResponsibleFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ResponsibleIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string TransferableDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string TransferableFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string TransferableIT { get; set; } = string.Empty;

    public bool BaseCard { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BillIdDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BillIdFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BillIdIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ValidToTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ValidToTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ValidToTextIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ValidFromFormat { get; set; } = string.Empty;

    public double ValidToInHours { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ValidToFormat { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string FQCode { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(100)]
    public string SignatureDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(100)]
    public string SignatureFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(100)]
    public string SignatureIT { get; set; } = string.Empty;

    public bool HasPrivateData { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BirthDateTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BirthDateTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string BirthDateTextIT { get; set; } = string.Empty;

    public bool ShowCustomerNumber { get; set; }

    public bool QRCode { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ArticleTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ArticleTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ArticleTextIT { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string ArticleNumber { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string PriceTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string PriceTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(50)]
    public string PriceTextIT { get; set; } = string.Empty;

    public bool Group { get; set; }

    public bool Single { get; set; }

    [StringLength(256)]
    public string? MwstLabelDE { get; set; }

    [StringLength(256)]
    public string? MwstLabelFR { get; set; }

    [StringLength(256)]
    public string? MwstLabelIT { get; set; }

    public decimal? Mwst { get; set; }

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string ProductFreeTextDE { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string ProductFreeTextFR { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = true)]
    [StringLength(256)]
    public string ProductFreeTextIT { get; set; } = string.Empty;

    [StringLength(256)]
    public string? GroupLabelDE { get; set; }

    [StringLength(256)]
    public string? GroupLabelFR { get; set; }

    [StringLength(256)]
    public string? GroupLabelIT { get; set; }

    public DateTime? DtDeleted { get; set; }

    public int Rank { get; set; }

    public bool Cancellable { get; set; }

    public int BelegRoleId { get; set; }

    public DateTime? DtModified { get; set; }

    // Navigation properties
    public TicketingCategory? Category { get; set; }
    public ICollection<TicketingProductPrice> ProductPrices { get; set; } = new List<TicketingProductPrice>();
    public ICollection<TicketingTicket> Tickets { get; set; } = new List<TicketingTicket>();
}
