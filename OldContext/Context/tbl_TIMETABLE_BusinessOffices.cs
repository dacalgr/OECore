namespace OpenEyeBackendEntities
{
    using System;

    public partial class tbl_TIMETABLE_BusinessOffices
    {
        public int id { get; set; }
        public string sboid { get; set; }
        public string said { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public string organisationNumber { get; set; }
        public string status { get; set; }
        public string descriptionDe { get; set; }
        public string descriptionFr { get; set; }
        public string descriptionIt { get; set; }
        public string descriptionEn { get; set; }
        public string abbreviationDe { get; set; }
        public string abbreviationFr { get; set; }
        public string abbreviationIt { get; set; }
        public string abbreviationEn { get; set; }
        public string businessTypesId { get; set; }
        public string businessTypesDe { get; set; }
        public string businessTypesIt { get; set; }
        public string businessTypesFr { get; set; }
        public string transportCompanyNumber { get; set; }
        public string transportCompanyAbbreviation { get; set; }
        public string transportCompanyBusinessRegisterName { get; set; }
        public string creationTime { get; set; }
        public string editionTime { get; set; }
    }
}