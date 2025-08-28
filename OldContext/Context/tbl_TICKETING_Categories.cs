namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_TICKETING_Categories()
        {
            tbl_TICKETING_Products = new HashSet<tbl_TICKETING_Products>();
            tbl_TICKETING_Tickets = new HashSet<tbl_TICKETING_Tickets>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string nameDE { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string nameFR { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string nameIT { get; set; }

        public bool mustOpenMnc { get; set; }

        public DateTime? dtDeleted { get; set; }

        public int rank { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_Products> tbl_TICKETING_Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_Tickets> tbl_TICKETING_Tickets { get; set; }
    }
}
