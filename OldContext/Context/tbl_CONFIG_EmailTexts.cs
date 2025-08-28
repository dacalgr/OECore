namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_CONFIG_EmailTexts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_EmailTexts()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        [ForeignKey("destination")]
        public int destinationId { get; set; }

        public tbl_CONFIG_EmailTexts_Destinations destination { get; set; }

        [StringLength(4000)]
        public string subject { get; set; }

        [StringLength(4000)]
        public string body { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
