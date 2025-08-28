namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTaskType")]
    public partial class tblTaskType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTaskType()
        {
            tblTaskType1 = new HashSet<tblTaskType1>();
            tblTaskType3 = new HashSet<tblTaskType3>();
        }

        public int id { get; set; }

        public int? type { get; set; }

        public Guid? taskId { get; set; }

        public int? firmId { get; set; }

        public virtual tblTask tblTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskType1> tblTaskType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskType3> tblTaskType3 { get; set; }
    }
}
