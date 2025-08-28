namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_Classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TICKETING_Classes()
        {
            tbl_TICKETING_ProductPrices = new HashSet<tbl_TICKETING_ProductPrices>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name { get; set; }
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_EN { get; set; }
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_FR { get; set; }
        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name_IT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_ProductPrices> tbl_TICKETING_ProductPrices { get; set; }
    }
}
