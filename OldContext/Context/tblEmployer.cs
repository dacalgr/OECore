namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmployer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployer()
        {
            tblUsers = new HashSet<tblUser>();
        }

        public int id { get; set; }

        [StringLength(400)]
        public string name { get; set; }

        public int? companyId { get; set; }

        public virtual tblCompany tblCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
