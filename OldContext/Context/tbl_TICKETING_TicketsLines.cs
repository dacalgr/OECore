namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_TicketsLines
    {
        public int id { get; set; }

        public Guid ticketID { get; set; }

        public int amount { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal price { get; set; }

        public int currency { get; set; }

        public int type { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string fqCode { get; set; }

        [Column(TypeName = "text")]
        public string quittungJSON { get; set; }

        public decimal? quittungPrice { get; set; }
    
        public virtual tbl_TICKETING_Tickets tbl_TICKETING_Tickets { get; set; }
    }
}
