namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBlackListFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBlackListFile()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string fileName { get; set; }

        public bool blacklist { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(5)]
        public string language { get; set; }

        [StringLength(100)]
        public string sftpHost { get; set; }

        [StringLength(50)]
        public string sftpUser { get; set; }

        [StringLength(50)]
        public string sftpPwd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? lastUpdate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public bool? parsed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
