namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_Tickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TICKETING_Tickets()
        {
            tbl_TICKETING_TicketsLines = new HashSet<tbl_TICKETING_TicketsLines>();
            tbl_TICKETING_TicketsImages = new HashSet<tbl_TICKETING_TicketsImages>();
        }

        public Guid id { get; set; }

        public int userID { get; set; }

        public int companyID { get; set; }

        public int categoryID { get; set; }

        public int productID { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string company { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string product { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string freeText { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
        public string deletedReason { get; set; }

        [Column("class")]
        [Required(AllowEmptyStrings = true)]
        [StringLength(8)]
        public string @class { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string details { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string region { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string reference { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? timeStamp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? uploaded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exported { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? balanced { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtProcessed { get; set; }

        public int? printMode { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(16)]
        public string deviceImei { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(12)]
        public string laufnummer { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string belegId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string kundennummer { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string lastname { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string birthdate { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string currency { get; set; }

        [StringLength(50)]
        public string baseCardNumber { get; set; }

        public int? classId { get; set; }

        public int? regionID { get; set; }

        public int? payment { get; set; }

        public float? currencyRate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exported_ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        public DateTime? cashChecked { get; set; }

        [StringLength(1000)]
        public string onlineTransactionID { get; set; }

        public bool sendEmail { get; set; }

        [StringLength(400)]
        public string email { get; set; }

        public int mailRetryNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? sentMailOK { get; set; }

        /// <summary>
        /// Confirm payment flags
        /// </summary>
        public bool confirmedNOBackendAccess { get; set; }
        public bool confirmedNOPaymentProviderAccess { get; set; }
        public bool confirmedWithNOPayment { get; set; }
        public int payrexxGatewayID { get; set; }

        public bool RefundAttempt { get; set; }
        public bool IsTicketConfirmed { get; set; }

        public int QRGenerations { get; set; }

        public int QRDownloads { get; set; }
        public string DownloadToken { get; set; }
    
        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        public virtual tbl_TICKETING_Categories tbl_TICKETING_Categories { get; set; }

        public virtual tbl_TICKETING_Products tbl_TICKETING_Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_TicketsLines> tbl_TICKETING_TicketsLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_TicketsImages> tbl_TICKETING_TicketsImages { get; set; }
    }
}
