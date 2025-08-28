namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMailing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMailing()
        {
            
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(500)]
        public string to { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(2000)]
        public string body { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string type { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string domain { get; set; }

        public Guid? entityId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtSendTime { get; set; }
    }
}
