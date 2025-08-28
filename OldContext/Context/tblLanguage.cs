namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLanguage")]
    public partial class tblLanguage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLanguage()
        {
            tbl_DOCBOX_Documents = new HashSet<tbl_DOCBOX_Documents>();
            tblUsers = new HashSet<tblUser>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string shortName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Documents> tbl_DOCBOX_Documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
