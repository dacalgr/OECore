namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKUP_Companies
    {
        public int id { get; set; }

        public int? companyId { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [StringLength(512)]
        public string name { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }

        public int? region { get; set; }

        [StringLength(50)]
        public string domainIncident { get; set; }

        [StringLength(50)]
        public string domainPicture { get; set; }

        [StringLength(50)]
        public string domainTask { get; set; }

        [StringLength(50)]
        public string domainTicketsales { get; set; }

        [StringLength(512)]
        public string emailBody { get; set; }

        [StringLength(512)]
        public string emailSalutation { get; set; }

        [StringLength(512)]
        public string emailIntroduction { get; set; }

        [StringLength(512)]
        public string emailRepeat { get; set; }

        [StringLength(512)]
        public string emailContinue { get; set; }

        [StringLength(512)]
        public string emailPresentation { get; set; }

        [StringLength(512)]
        public string emailPortal { get; set; }

        [StringLength(512)]
        public string logoUrl { get; set; }

        [StringLength(10)]
        public string language { get; set; }

        [StringLength(50)]
        public string mwst { get; set; }

        [StringLength(50)]
        public string VoeVTUCode { get; set; }

        [StringLength(50)]
        public string VoeTarifVerbundCode { get; set; }

        public int? AddQR { get; set; }

        [StringLength(512)]
        public string printLogo { get; set; }

        [StringLength(50)]
        public string shortNameX { get; set; }

        public DateTime? dtPublished { get; set; }

        public bool? enableSendIncidentBySMS { get; set; }

        public bool? enableSendIncidentByEmail { get; set; }

        [StringLength(50)]
        public string mwstEN { get; set; }

        [StringLength(50)]
        public string mwstDE { get; set; }

        [StringLength(50)]
        public string mwstFR { get; set; }

        [StringLength(50)]
        public string mwstIT { get; set; }

        public decimal? currencyExchangeCHF_EUR { get; set; }

        [StringLength(512)]
        public string emailLogo { get; set; }

        [StringLength(512)]
        public string addressInReceipt { get; set; }
    }
}
