namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_turnsExported
    {
        public Guid id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [StringLength(50)]
        public string name { get; set; }
        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [StringLength(50)]
        public string personalNummer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? stopTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportTime { get; set; }
    }
}
