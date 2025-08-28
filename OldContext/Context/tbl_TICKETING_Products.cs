namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TICKETING_Products()
        {
            tbl_TICKETING_ProductPrices = new HashSet<tbl_TICKETING_ProductPrices>();
            tbl_TICKETING_Tickets = new HashSet<tbl_TICKETING_Tickets>();
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        public int categoryId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string freeText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string freeText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string freeText_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string comments_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string comments_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string comments_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string responsible_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string responsible_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string responsible_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string transferable_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string transferable_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string transferable_IT { get; set; }

        public bool baseCard { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string billId_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string billId_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string billId_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string validToText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string validToText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string validToText_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string validFromFormat { get; set; }

        public double validToInHours { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string validToFormat { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string fQCode { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string signature_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string signature_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string signature_IT { get; set; }

        public bool hasPrivateData { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string birthDateText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string birthDateText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string birthDateText_IT { get; set; }

        public bool showCustomerNumber { get; set; }

        public bool qRCode { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string articleText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string articleText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string articleText_IT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string articleNumber { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string priceText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string priceText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string priceText_IT { get; set; }

        public bool group { get; set; }

        public bool single { get; set; }

        [StringLength(256)]
        public string mwst_label_de { get; set; }

        [StringLength(256)]
        public string mwst_label_fr { get; set; }

        [StringLength(256)]
        public string mwst_label_it { get; set; }

        public decimal? mwst { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string productFreeText_DE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string productFreeText_FR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string productFreeText_IT { get; set; }

        [StringLength(256)]
        public string groupLabel_DE { get; set; }

        [StringLength(256)]
        public string groupLabel_FR { get; set; }

        [StringLength(256)]
        public string groupLabel_IT { get; set; }

        public DateTime? dtDeleted { get; set; }

        public int rank { get; set; }

        public bool cancellable { get; set; }

        public int belegRoleId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        public virtual tbl_CONFIG_BelegRole tbl_CONFIG_BelegRole { get; set; }

        public virtual tbl_TICKETING_Categories tbl_TICKETING_Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_ProductPrices> tbl_TICKETING_ProductPrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_Tickets> tbl_TICKETING_Tickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
