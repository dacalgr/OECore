namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_ReasonsSubcategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_ReasonsSubcategories()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
            
        }

        public int id { get; set; }

        public string text_de { get; set; }

        public string text_fr { get; set; }

        public string text_it { get; set; }

        public string text_en { get; set; }

        public string code { get; set; }

        public float? fee { get; set; }

        public float? forgery { get; set; }

        public float? miscellaneus { get; set; }

        public int? parentId { get; set; }

        public float? surcharge { get; set; }

        public float? fare { get; set; }

        public int? categoryId { get; set; }

        public float? abuse { get; set; }

        public float? time_penalties { get; set; }

        public float? total { get; set; }

        public int? companyId { get; set; }

        public int? rank { get; set; }

        public int? print_continue { get; set; }

        public int? print_continue2 { get; set; }

        public int? print_salesPoint { get; set; }

        public int? print_logo { get; set; }

        public int? print_portal { get; set; }

        public int? print_signature { get; set; }

        public int? print_repeat { get; set; }

        public int? allowComments { get; set; }

        public int? print_QR { get; set; }

        public int? abuseOptionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }

        

        public tbl_CONFIG_AbuseOptions tbl_CONFIG_AbuseOptions { get; set; }

    }
}
