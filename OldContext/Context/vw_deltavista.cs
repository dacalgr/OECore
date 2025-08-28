namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_deltavista
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? status { get; set; }

        public int? error { get; set; }

        public string error_message { get; set; }

        [StringLength(50)]
        public string userId { get; set; }

        [StringLength(50)]
        public string incident { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }
    }
}
