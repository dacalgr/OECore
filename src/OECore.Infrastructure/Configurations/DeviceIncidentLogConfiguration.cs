using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DeviceIncidentLogConfiguration : IEntityTypeConfiguration<DeviceIncidentLog>
{
    public void Configure(EntityTypeBuilder<DeviceIncidentLog> builder)
    {
        builder.ToTable("tbl_DEVICE_LOGS_IncidentLogs");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TStamp)
            .HasColumnName("tStamp");
            
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp");
            
        builder.Property(e => e.DbVersion)
            .HasColumnName("dbversion");
            
        builder.Property(e => e.Message)
            .HasColumnName("message");
            
        builder.Property(e => e.IncidentId)
            .HasColumnName("incidentid");
            
        builder.Property(e => e.DeviceId)
            .HasColumnName("deviceid");
            
        builder.Property(e => e.Imei)
            .HasColumnName("imei");
            
        builder.Property(e => e.UserId)
            .HasColumnName("userid");
            
        builder.Property(e => e.DbLastUpdate)
            .HasColumnName("dblastupdate");
            
        builder.Property(e => e.Version)
            .HasColumnName("version");
            
        builder.Property(e => e.DateTime)
            .HasColumnName("datetime");
            
        builder.Property(e => e.Mode)
            .HasColumnName("mode");
            
        builder.Property(e => e.Total)
            .HasColumnName("total");
            
        builder.Property(e => e.FirmName)
            .HasColumnName("firmname");
            
        builder.Property(e => e.TutorBirthLand)
            .HasColumnName("tutorbirthland");
            
        builder.Property(e => e.TutorCity)
            .HasColumnName("tutorcity");
            
        builder.Property(e => e.TutorTitleId)
            .HasColumnName("tutortitleid");
            
        builder.Property(e => e.CardTypeId)
            .HasColumnName("cardtypeid");
            
        builder.Property(e => e.TutorName)
            .HasColumnName("tutorname");
            
        builder.Property(e => e.WagenNummer)
            .HasColumnName("wagennummer");
            
        builder.Property(e => e.TutorBirthDate)
            .HasColumnName("tutorbirthdate");
            
        builder.Property(e => e.HausNummer)
            .HasColumnName("hausnummer");
            
        builder.Property(e => e.TaskId)
            .HasColumnName("taskid");
            
        builder.Property(e => e.City)
            .HasColumnName("city");
            
        builder.Property(e => e.StartTime)
            .HasColumnName("starttime");
            
        builder.Property(e => e.TurnId)
            .HasColumnName("turnid");
            
        builder.Property(e => e.ReceiptPrinted)
            .HasColumnName("receiptprinted");
            
        builder.Property(e => e.FirmId)
            .HasColumnName("firmid");
            
        builder.Property(e => e.Place)
            .HasColumnName("place");
            
        builder.Property(e => e.TutorHausNummer)
            .HasColumnName("tutorhausnummer");
            
        builder.Property(e => e.CoAddress)
            .HasColumnName("coaddress");
            
        builder.Property(e => e.RegionId)
            .HasColumnName("regionid");
            
        builder.Property(e => e.ExportedToSap)
            .HasColumnName("exportedtosap");
            
        builder.Property(e => e.Station)
            .HasColumnName("station");
            
        builder.Property(e => e.Extra)
            .HasColumnName("extra");
            
        builder.Property(e => e.Cancelled)
            .HasColumnName("cancelled");
            
        builder.Property(e => e.RegionName)
            .HasColumnName("regionname");
            
        builder.Property(e => e.CountryCode)
            .HasColumnName("countrycode");
            
        builder.Property(e => e.CancelledReason)
            .HasColumnName("cancelledreason");
            
        builder.Property(e => e.Number)
            .HasColumnName("number");
            
        builder.Property(e => e.TutorZip)
            .HasColumnName("tutorzip");
            
        builder.Property(e => e.ConfirmedLine)
            .HasColumnName("confirmedline");
            
        builder.Property(e => e.Modified)
            .HasColumnName("modified");
            
        builder.Property(e => e.Country)
            .HasColumnName("country");
            
        builder.Property(e => e.Email)
            .HasColumnName("email");
            
        builder.Property(e => e.Cash)
            .HasColumnName("cash");
            
        builder.Property(e => e.Images)
            .HasColumnName("images");
            
        builder.Property(e => e.SendEmail)
            .HasColumnName("sendemail");
            
        builder.Property(e => e.BirthLand)
            .HasColumnName("birthland");
            
        builder.Property(e => e.TitleId)
            .HasColumnName("titleid");
            
        builder.Property(e => e.UploadedDate)
            .HasColumnName("uploadeddate");
            
        builder.Property(e => e.PaymentMode)
            .HasColumnName("paymentmode");
            
        builder.Property(e => e.SendSms)
            .HasColumnName("sendsms");
            
        builder.Property(e => e.ClosedDate)
            .HasColumnName("closeddate");
            
        builder.Property(e => e.Timezone)
            .HasColumnName("timezone");
            
        builder.Property(e => e.Citizenship)
            .HasColumnName("citizenship");
            
        builder.Property(e => e.DeltaVistaResult)
            .HasColumnName("deltavistaresult");
            
        builder.Property(e => e.TutorExtra)
            .HasColumnName("tutorextra");
            
        builder.Property(e => e.BillLines)
            .HasColumnName("billlines");
            
        builder.Property(e => e.Currency)
            .HasColumnName("currency");
            
        builder.Property(e => e.ZemisNr)
            .HasColumnName("zemisnr");
            
        builder.Property(e => e.ParentId)
            .HasColumnName("parentid");
            
        builder.Property(e => e.ResidencePermitId)
            .HasColumnName("residencepermitid");
            
        builder.Property(e => e.CategoryCardTypeId)
            .HasColumnName("categorycardtypeid");
            
        builder.Property(e => e.Remaining)
            .HasColumnName("remaining");
            
        builder.Property(e => e.TutorFirstName)
            .HasColumnName("tutorfirstname");
            
        builder.Property(e => e.TutorCoAddress)
            .HasColumnName("tutorcoaddress");
            
        builder.Property(e => e.Name)
            .HasColumnName("name");
            
        builder.Property(e => e.BirthDate)
            .HasColumnName("birthdate");
            
        builder.Property(e => e.DeltaVistaResponse)
            .HasColumnName("deltavistaresponse");
            
        builder.Property(e => e.Deduction)
            .HasColumnName("deduction");
            
        builder.Property(e => e.TutorAddress)
            .HasColumnName("tutoraddress");
            
        builder.Property(e => e.Zip)
            .HasColumnName("zip");
            
        builder.Property(e => e.TutorCountry)
            .HasColumnName("tutorcountry");
            
        builder.Property(e => e.FirstName)
            .HasColumnName("firstname");
            
        builder.Property(e => e.IsOpen)
            .HasColumnName("isopen");
            
        builder.Property(e => e.IsAnon)
            .HasColumnName("isanon");
            
        builder.Property(e => e.Balanced)
            .HasColumnName("balanced");
            
        builder.Property(e => e.Address)
            .HasColumnName("address");
            
        builder.Property(e => e.Route)
            .HasColumnName("route");
            
        builder.Property(e => e.ConfirmedLineComments)
            .HasColumnName("confirmedlinecomments");
            
        builder.Property(e => e.BehaviorCode)
            .HasColumnName("behaviorcode");
            
        builder.Property(e => e.LastModificationDate)
            .HasColumnName("lastmodificationdate");
            
        builder.Property(e => e.Telephone)
            .HasColumnName("telephone");
            
        builder.Property(e => e.TutorCountryCode)
            .HasColumnName("tutorcountrycode");
            
        builder.Property(e => e.Step)
            .HasColumnName("step");
            
        builder.Property(e => e.Comments)
            .HasColumnName("comments");
            
        builder.Property(e => e.Zone)
            .HasColumnName("zone");
            
        builder.Property(e => e.Factor)
            .HasColumnName("factor");
            
        builder.Property(e => e.AnonymousReason)
            .HasColumnName("anonymousreason");
            
        builder.Property(e => e.Change)
            .HasColumnName("change");
            
        builder.Property(e => e.StartLatitude)
            .HasColumnName("startlatitude");
            
        builder.Property(e => e.StartLongitude)
            .HasColumnName("startlongitude");
            
        builder.Property(e => e.VersionNumber)
            .HasColumnName("versionnumber");
            
        builder.Property(e => e.File)
            .HasColumnName("file");
            
        builder.Property(e => e.Response)
            .HasColumnName("response");
    }
}
