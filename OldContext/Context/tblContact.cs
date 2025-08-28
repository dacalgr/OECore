namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblContact()
        {
            tblUsers = new HashSet<tblUser>();
            tbl_CONFIG_Profiles = new HashSet<tbl_CONFIG_Profiles>();
        }

        public int id { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        public DateTime? birthDate { get; set; }

        public DateTime? activeFrom { get; set; }

        public DateTime? activeTo { get; set; }

        public int? language { get; set; }

        [StringLength(4000)]
        public string email { get; set; }

        [StringLength(4000)]
        public string phone { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }

        [StringLength(500)]
        public string department { get; set; }

        [StringLength(500)]
        public string direction { get; set; }

        [StringLength(50)]
        public string privatePhone { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(100)]
        public string section { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(50)]
        public string plz { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }
    }
}
