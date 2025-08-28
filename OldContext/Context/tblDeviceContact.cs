namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDeviceContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDeviceContact()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        [StringLength(4000)]    
        public string emailList { get; set; }

        [StringLength(4000)]
        public string phone { get; set; }

        [StringLength(50)]
        public string phone2 { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }

        [StringLength(500)]
        public string website { get; set; }

        [StringLength(500)]
        public string street { get; set; }

        [StringLength(50)]
        public string plz { get; set; }

        [StringLength(50)]
        public string houseNumber { get; set; }

        [StringLength(500)]
        public string city { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        [StringLength(500)]
        public string firma { get; set; }


        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }

    }
}
