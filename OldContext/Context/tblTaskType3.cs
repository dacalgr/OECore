namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTaskType3
    {
        public int id { get; set; }

        public int? taskTypeId { get; set; }

        public long? subcategoryId { get; set; }

        public long? categoryId { get; set; }

        public virtual tblTaskType tblTaskType { get; set; }
    }
}
