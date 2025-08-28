namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Applications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Applications()
        {
            tbl_CONFIG_Applications_Parameters_Values = new HashSet<tbl_CONFIG_Applications_Parameters_Values>();
            tbl_CONFIG_Applications1 = new HashSet<tbl_CONFIG_Applications>();
            tbl_CONFIG_Dashboards_Applications = new HashSet<tbl_CONFIG_Dashboards_Applications>();
            tbl_CONFIG_Widgets = new HashSet<tbl_CONFIG_Widgets>();
        }

        public int id { get; set; }

        public int? parentId { get; set; }

        [StringLength(50)]
        public string appId { get; set; }

        [StringLength(100)]
        public string prefix { get; set; }

        [StringLength(50)]
        public string accessory { get; set; }

        [StringLength(50)]
        public string nameEN { get; set; }

        [StringLength(50)]
        public string nameDE { get; set; }

        [StringLength(50)]
        public string nameFR { get; set; }

        [StringLength(50)]
        public string nameIT { get; set; }

        [StringLength(100)]
        public string descriptionEN { get; set; }

        [StringLength(100)]
        public string descriptionDE { get; set; }

        [StringLength(100)]
        public string descriptionFR { get; set; }

        [StringLength(100)]
        public string descriptionIT { get; set; }

        [StringLength(500)]
        public string iconEN { get; set; }

        [StringLength(500)]
        public string iconDE { get; set; }

        [StringLength(500)]
        public string iconFR { get; set; }

        [StringLength(500)]
        public string iconIT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Applications_Parameters_Values> tbl_CONFIG_Applications_Parameters_Values { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Applications> tbl_CONFIG_Applications1 { get; set; }

        public virtual tbl_CONFIG_Applications tbl_CONFIG_Applications2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Dashboards_Applications> tbl_CONFIG_Dashboards_Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Widgets> tbl_CONFIG_Widgets { get; set; }
    }
}
