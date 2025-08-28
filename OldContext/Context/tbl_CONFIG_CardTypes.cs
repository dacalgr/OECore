namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_CardTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_CardTypes()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        public int parentId { get; set; }

        public string text_de { get; set; }

        public string text_fr { get; set; }

        public string text_it { get; set; }
        public string text_en { get; set; }

        [StringLength(8)]
        public string code { get; set; }

        public bool zemis { get; set; }

        public int? rank { get; set; }

        public int cardTypeId { get; set; }

        //Obsolete Remove from DB
        public string companyId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
