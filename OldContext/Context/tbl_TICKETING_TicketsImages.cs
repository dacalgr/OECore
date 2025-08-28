namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TICKETING_TicketsImages
    {
        public int id { get; set; }

        public Guid ticketID { get; set; }

        [Column(TypeName = "text")]
        public string imageContent { get; set; }

        public bool isQuittung { get; set; }

        public virtual tbl_TICKETING_Tickets tbl_TICKETING_Tickets { get; set; }
    }
}