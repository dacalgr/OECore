namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKUP_IDCardType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(1000)]
        public string name_de { get; set; }

        [StringLength(1000)]
        public string name_fr { get; set; }

        [StringLength(1000)]
        public string name_it { get; set; }

        public int? parent { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        public bool? zemis { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }
    }
}
