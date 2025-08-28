namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Dashboards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Dashboards()
        {
            tbl_CONFIG_Dashboards_Applications = new HashSet<tbl_CONFIG_Dashboards_Applications>();
            tbl_CONFIG_Dashboards_Widgets = new HashSet<tbl_CONFIG_Dashboards_Widgets>();
            tblUsers = new HashSet<tblUser>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? themeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Dashboards_Applications> tbl_CONFIG_Dashboards_Applications { get; set; }

        public virtual tbl_CONFIG_Themes tbl_CONFIG_Themes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Dashboards_Widgets> tbl_CONFIG_Dashboards_Widgets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
