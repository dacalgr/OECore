namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Parameters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Parameters()
        {
            tbl_CONFIG_Applications_Parameters_Values = new HashSet<tbl_CONFIG_Applications_Parameters_Values>();
            tbl_CONFIG_Widgets_Parameters_Values = new HashSet<tbl_CONFIG_Widgets_Parameters_Values>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Applications_Parameters_Values> tbl_CONFIG_Applications_Parameters_Values { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Widgets_Parameters_Values> tbl_CONFIG_Widgets_Parameters_Values { get; set; }
    }
}
