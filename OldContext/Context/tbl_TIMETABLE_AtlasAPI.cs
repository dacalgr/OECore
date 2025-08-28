namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_TIMETABLE_AtlasAPI
    {
        public int id { get; set; }

        public string numberShort { get; set; }
        public string uicCountryCode { get; set; }
        public string sloid { get; set; }
        public string number { get; set; }
        public string checkDigit { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public string designationOfficial { get; set; }
        public string designationLong { get; set; }
        public string abbreviation { get; set; }
        public string operatingPoint { get; set; }
        public string operatingPointWithTimetable { get; set; }
        public string stopPoint { get; set; }
        public string stopPointType { get; set; }
        public string freightServicePoint { get; set; }
        public string trafficPoint { get; set; }
        public string borderPoint { get; set; }
        public string hasGeolocation { get; set; }
        public string isoCountryCode { get; set; }
        public string cantonName { get; set; }
        public string cantonFsoNumber { get; set; }
        public string cantonAbbreviation { get; set; }
        public string districtName { get; set; }
        public string districtFsoNumber { get; set; }
        public string municipalityName { get; set; }
        public string fsoNumber { get; set; }
        public string localityName { get; set; }
        public string operatingPointType { get; set; }
        public string operatingPointTechnicalTimetableType { get; set; }
        public string meansOfTransport { get; set; }
        public string categories { get; set; }
        public string operatingPointTrafficPointType { get; set; }
        public string operatingPointRouteNetwork { get; set; }
        public string operatingPointKilometer { get; set; }
        public string operatingPointKilometerMasterNumber { get; set; }
        public string sortCodeOfDestinationStation { get; set; }
        public string businessOrganisation { get; set; }
        public string businessOrganisationNumber { get; set; }
        public string businessOrganisationAbbreviationDe { get; set; }
        public string businessOrganisationAbbreviationFr { get; set; }
        public string businessOrganisationAbbreviationIt { get; set; }
        public string businessOrganisationAbbreviationEn { get; set; }
        public string businessOrganisationDescriptionDe { get; set; }
        public string businessOrganisationDescriptionFr { get; set; }
        public string businessOrganisationDescriptionIt { get; set; }
        public string businessOrganisationDescriptionEn { get; set; }
        public string fotComment { get; set; }
        public string lv95East { get; set; }
        public string lv95North { get; set; }
        public string wgs84East { get; set; }
        public string wgs84North { get; set; }
        public string height { get; set; }
        public string creationDate { get; set; }
        public string editionDate { get; set; }
        public string status { get; set; }
        
    }
}