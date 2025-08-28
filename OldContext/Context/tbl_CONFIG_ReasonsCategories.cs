namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_ReasonsCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_ReasonsCategories()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
            tbl_CONFIG_Companies_TicketControl = new HashSet<tbl_CONFIG_Companies>();
            tbl_CONFIG_Companies_ExternerTU = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string text_it { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string text_de { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string text_fr { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string text_en { get; set; }

        public int categoryId { get; set; }

        public int? companyId { get; set; }

        public int? rank { get; set; }

        public bool isAbuse { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies_TicketControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies_ExternerTU { get; set; }
    }
}
