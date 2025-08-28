namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Widgets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Widgets()
        {
            tbl_CONFIG_Dashboards_Widgets = new HashSet<tbl_CONFIG_Dashboards_Widgets>();
            tbl_CONFIG_Widgets_Parameters_Values = new HashSet<tbl_CONFIG_Widgets_Parameters_Values>();
        }

        public int id { get; set; }

        public int? applicationId { get; set; }

        [StringLength(50)]
        public string widgetId { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string nameEN { get; set; }

        [StringLength(50)]
        public string nameDE { get; set; }

        [StringLength(50)]
        public string nameFR { get; set; }

        [StringLength(50)]
        public string nameIT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public virtual tbl_CONFIG_Applications tbl_CONFIG_Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Dashboards_Widgets> tbl_CONFIG_Dashboards_Widgets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Widgets_Parameters_Values> tbl_CONFIG_Widgets_Parameters_Values { get; set; }
    }
}
