namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_userContacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        [StringLength(4000)]
        public string email { get; set; }

        [StringLength(4000)]
        public string phone { get; set; }

        public DateTime? dtContactCreated { get; set; }

        public DateTime? dtContactModified { get; set; }

        public DateTime? dtContactDeleted { get; set; }

        [StringLength(500)]
        public string direction { get; set; }

        [StringLength(50)]
        public string privatePhone { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(50)]
        public string plz { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        public DateTime? birthDate { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        public int? employer { get; set; }

        public int? controlBase { get; set; }

        public int? language { get; set; }

        public DateTime? dtUserCreated { get; set; }

        public DateTime? dtUserModified { get; set; }

        public DateTime? dtUserDeleted { get; set; }

        public DateTime? readFromSP { get; set; }

        public int? extranetId { get; set; }

        [StringLength(50)]
        public string theme { get; set; }

        [StringLength(500)]
        public string PU { get; set; }

        public bool? alphaEnabled { get; set; }

        public bool? ticketTimeCheckEnabled { get; set; }

        [StringLength(50)]
        public string voeVTUCode { get; set; }

        public int? dashboardId { get; set; }

        public bool? protectedUser { get; set; }

        public int? employerOf { get; set; }

        public bool? forceResetPassword { get; set; }

        [StringLength(64)]
        public string hashPassword { get; set; }

        public int? contactId { get; set; }

        public DateTime? activeFrom { get; set; }

        public DateTime? activeTo { get; set; }

        public bool? belegeAusstellbar { get; set; }

        public bool? vorfallAusloesbar { get; set; }

        public DateTime? signedTimestamp { get; set; }

        public bool? isBackendUser { get; set; }

        public DateTime? lastLogin { get; set; }

        public DateTime? lastBalance { get; set; }

        public int userId { get; set; }
    }
}
