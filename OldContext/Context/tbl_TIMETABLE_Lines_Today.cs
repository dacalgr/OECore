namespace OpenEyeBackendEntities
{
    using System;

    public partial class tbl_TIMETABLE_Lines_Today
    {
        public int id { get; set; }
        public string slnid { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public string status { get; set; }
        public string lineType { get; set; }
        public string concessionType { get; set; }
        public string swissLineNumber { get; set; }
        public string description { get; set; }
        public string longName { get; set; }
        public string number { get; set; }
        public string shortNumber { get; set; }
        public string offerCategory { get; set; }
        public string businessOrganisation { get; set; }
        public string comment { get; set; }
        public string creationTime { get; set; }
        public string editionTime { get; set; }
    }
}