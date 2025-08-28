namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBill
    {
        public int id { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [StringLength(400)]
        public string nameDE { get; set; }

        [StringLength(400)]
        public string nameFR { get; set; }

        [StringLength(400)]
        public string nameIT { get; set; }

        public decimal? surcharge { get; set; }

        public decimal? fare { get; set; }

        public decimal? fee { get; set; }

        public decimal? abuse { get; set; }

        public decimal? forgery { get; set; }

        public decimal? time_penalties { get; set; }

        public decimal? miscellaneus { get; set; }

        public decimal? total { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }

        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
