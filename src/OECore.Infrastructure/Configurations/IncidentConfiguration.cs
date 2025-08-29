using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class IncidentConfiguration : IEntityTypeConfiguration<Incident>
{
    public void Configure(EntityTypeBuilder<Incident> builder)
    {
        builder.ToTable("tblIncident");
        builder.HasKey(e => e.Id);
        
        // Basic properties
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.TurnId).HasColumnName("turnID");
        builder.Property(e => e.TaskId).HasColumnName("taskID");
        builder.Property(e => e.UserId).HasColumnName("userId");
        builder.Property(e => e.CardTypeId).HasColumnName("cardTypeId");
        builder.Property(e => e.CategoryCardTypeId).HasColumnName("categoryCardTypeId");
        builder.Property(e => e.QuitNo).HasColumnName("quitNo").HasMaxLength(50);
        builder.Property(e => e.FirmId).HasColumnName("firmId");
        builder.Property(e => e.Image).HasColumnName("image");
        builder.Property(e => e.Comments).HasColumnName("comments").HasMaxLength(4000);
        builder.Property(e => e.Thumbnail).HasColumnName("thumbnail");
        builder.Property(e => e.Step).HasColumnName("step");
        builder.Property(e => e.ParentId).HasColumnName("parentID");
        builder.Property(e => e.Cancelled).HasColumnName("cancelled");
        builder.Property(e => e.CancelledReason).HasColumnName("cancelledReason").HasMaxLength(4000);
        builder.Property(e => e.CancelledReasonId).HasColumnName("cancelledReasonID");
        builder.Property(e => e.AutoIncrement).HasColumnName("autoIncrement");
        builder.Property(e => e.ConfirmedWarningMailSent).HasColumnName("ConfirmedWarningMailSent");

        // Passenger data
        builder.Property(e => e.BehaviorCode).HasColumnName("behaviorCode").HasMaxLength(50);
        builder.Property(e => e.Name).HasColumnName("name").HasMaxLength(4000);
        builder.Property(e => e.Firstname).HasColumnName("firstname").HasMaxLength(4000);
        builder.Property(e => e.Address).HasColumnName("address").HasMaxLength(4000);
        builder.Property(e => e.Zip).HasColumnName("zip").HasMaxLength(4000);
        builder.Property(e => e.Email).HasColumnName("email").HasMaxLength(500);
        builder.Property(e => e.Birthdate).HasColumnName("birthdate").HasColumnType("timestamp");
        builder.Property(e => e.BirthLand).HasColumnName("birthLand").HasMaxLength(50);
        builder.Property(e => e.Citizenship).HasColumnName("citzenship").HasMaxLength(4000);
        builder.Property(e => e.TitleId).HasColumnName("titleId");
        builder.Property(e => e.City).HasColumnName("city").HasMaxLength(4000);
        builder.Property(e => e.Country).HasColumnName("country").HasMaxLength(4000);
        builder.Property(e => e.CountryCode).HasColumnName("countryCode").HasMaxLength(40);
        builder.Property(e => e.Extra).HasColumnName("extra").HasMaxLength(4000);
        builder.Property(e => e.ZemisNr).HasColumnName("zemisNr").HasMaxLength(50);
        builder.Property(e => e.ResidencePermitId).HasColumnName("residencePermitId");
        builder.Property(e => e.IsAnon).HasColumnName("isAnon");
        builder.Property(e => e.Hausnummer).HasColumnName("hausnummer").HasMaxLength(40);
        builder.Property(e => e.CoAddress).HasColumnName("coAddress").HasMaxLength(50);
        builder.Property(e => e.Telephone).HasColumnName("telephone").HasMaxLength(50);
        builder.Property(e => e.AnonymousReason).HasColumnName("anonymousReason").HasMaxLength(1000);
        builder.Property(e => e.PersId).HasColumnName("persID").HasMaxLength(50);
        builder.Property(e => e.HbkKey).HasColumnName("hbkKey").HasMaxLength(50);
        builder.Property(e => e.Scanned).HasColumnName("scanned");
        builder.Property(e => e.AmpDataModified).HasColumnName("AMPDataModified");
        builder.Property(e => e.PassengerPreferredLanguage).HasColumnName("passengerPreferredLanguage").HasMaxLength(25);

        // Tutor data
        builder.Property(e => e.TutorName).HasColumnName("tutorName").HasMaxLength(4000);
        builder.Property(e => e.TutorFirstname).HasColumnName("tutorFirstname").HasMaxLength(4000);
        builder.Property(e => e.TutorAddress).HasColumnName("tutorAddress").HasMaxLength(4000);
        builder.Property(e => e.TutorZip).HasColumnName("tutorZip").HasMaxLength(4000);
        builder.Property(e => e.TutorEmail).HasColumnName("tutorEmail").HasMaxLength(500);
        builder.Property(e => e.TutorPhone).HasColumnName("tutorPhone").HasMaxLength(50);
        builder.Property(e => e.TutorBirthdate).HasColumnName("tutorBirthdate").HasColumnType("timestamp");
        builder.Property(e => e.TutorCitizenship).HasColumnName("tutorCitizenship").HasMaxLength(4000);
        builder.Property(e => e.TutorTitleId).HasColumnName("tutorTitleId");
        builder.Property(e => e.TutorCity).HasColumnName("tutorCity").HasMaxLength(4000);
        builder.Property(e => e.TutorCountry).HasColumnName("tutorCountry").HasMaxLength(4000);
        builder.Property(e => e.TutorCountryCode).HasColumnName("tutorCountryCode").HasMaxLength(40);
        builder.Property(e => e.TutorExtra).HasColumnName("tutorExtra").HasMaxLength(4000);
        builder.Property(e => e.TutorHausnummer).HasColumnName("tutorHausnummer").HasMaxLength(40);
        builder.Property(e => e.TutorCoAddress).HasColumnName("tutorCoAddress").HasMaxLength(50);
        builder.Property(e => e.TutorPersId).HasColumnName("tutorPersID").HasMaxLength(50);
        builder.Property(e => e.TutorHbkKey).HasColumnName("tutorHbkKey").HasMaxLength(50);

        // Incident deployment
        builder.Property(e => e.SendSms).HasColumnName("sendSMS");
        builder.Property(e => e.MailRequestFlag).HasColumnName("mailRequestFlag");
        builder.Property(e => e.MailNumber).HasColumnName("MailNumber");
        builder.Property(e => e.ReceiptPrinted).HasColumnName("receiptPrinted");
        builder.Property(e => e.PrintNumber).HasColumnName("PrintNumber");
        builder.Property(e => e.RefundAttempt).HasColumnName("RefundAttempt");
        builder.Property(e => e.QrGenerations).HasColumnName("QRGenerations");
        builder.Property(e => e.QrDownloads).HasColumnName("QRDownloads");
        builder.Property(e => e.DownloadToken).HasColumnName("DownloadToken");
        builder.Property(e => e.AlreadySentSms).HasColumnName("alreadySentSMS").HasColumnType("timestamp");
        builder.Property(e => e.SentMailOk).HasColumnName("sentMailOK").HasColumnType("timestamp");
        builder.Property(e => e.MailRetryNumber).HasColumnName("mailRetryNumber");
        builder.Property(e => e.SmtpLastResponse).HasColumnName("SMTPLastResponse").HasMaxLength(5000);

        // Dates
        builder.Property(e => e.StartTime).HasColumnName("startTime").HasColumnType("timestamp");
        builder.Property(e => e.Timezone).HasColumnName("timezone").HasMaxLength(100);
        builder.Property(e => e.Modified).HasColumnName("modified").HasColumnType("timestamp");
        builder.Property(e => e.DtNotified).HasColumnName("DtNotified").HasColumnType("timestamp");
        builder.Property(e => e.ExportedToSap).HasColumnName("exportedToSAP").HasColumnType("timestamp");
        builder.Property(e => e.UploadedDate).HasColumnName("uploadedDate").HasColumnType("timestamp");
        builder.Property(e => e.Deleted).HasColumnName("deleted").HasColumnType("timestamp");
        builder.Property(e => e.StartTimeReceived).HasColumnName("startTimeReceived");
        builder.Property(e => e.ClosedDate).HasColumnName("closedDate").HasColumnType("timestamp");
        builder.Property(e => e.LastModificationDate).HasColumnName("lastModificationDate").HasColumnType("timestamp");
        builder.Property(e => e.Balanced).HasColumnName("balanced").HasColumnType("timestamp");
        builder.Property(e => e.ControlTimeStamp).HasColumnName("controlTimeStamp").HasColumnType("timestamp");
        builder.Property(e => e.CashChecked).HasColumnName("cashChecked").HasColumnType("timestamp");
        builder.Property(e => e.DtProcessed).HasColumnName("dtProcessed").HasColumnType("timestamp");

        // Payment data
        builder.Property(e => e.Remaining).HasColumnName("remaining").HasColumnType("numeric");
        builder.Property(e => e.Deduction).HasColumnName("deduction").HasColumnType("numeric");
        builder.Property(e => e.Cash).HasColumnName("cash").HasColumnType("numeric");
        builder.Property(e => e.Total).HasColumnName("total").HasColumnType("numeric");
        builder.Property(e => e.Currency).HasColumnName("currency").HasMaxLength(50);
        builder.Property(e => e.PaymentMode).HasColumnName("paymentMode");
        builder.Property(e => e.Factor).HasColumnName("factor").HasColumnType("numeric");
        builder.Property(e => e.Change).HasColumnName("change").HasColumnType("numeric");
        builder.Property(e => e.IsOnlinePaid).HasColumnName("IsOnlinePaid");
        builder.Property(e => e.OnlineTransactionId).HasColumnName("onlineTransactionID").HasMaxLength(1000);
        builder.Property(e => e.ConfirmedWithNoPayment).HasColumnName("ConfirmedWithNOPayment");
        builder.Property(e => e.ConfirmedNoBackendAccess).HasColumnName("ConfirmedNOBackendAccess");
        builder.Property(e => e.ConfirmedNoPaymentProviderAccess).HasColumnName("ConfirmedNOPaymentProviderAccess");
        builder.Property(e => e.PayrexxGatewayId).HasColumnName("PayrexxGatewayId");
        builder.Property(e => e.PaymentMethod).HasColumnName("PaymentMethod");

        // Incident location
        builder.Property(e => e.Place).HasColumnName("place").HasMaxLength(4000);
        builder.Property(e => e.Route).HasColumnName("route").HasMaxLength(1000);
        builder.Property(e => e.Number).HasColumnName("number").HasMaxLength(4000);
        builder.Property(e => e.Station).HasColumnName("station").HasMaxLength(1000);

        // Incident status
        builder.Property(e => e.IsOpen).HasColumnName("isOpen");
        builder.Property(e => e.Zone).HasColumnName("zone").HasMaxLength(50);
        builder.Property(e => e.Wagennummer).HasColumnName("wagennummer").HasMaxLength(200);
        builder.Property(e => e.ConfirmedLine).HasColumnName("confirmedLine");
        builder.Property(e => e.ConfirmedLineComments).HasColumnName("confirmedLineComments").HasMaxLength(4000);
        builder.Property(e => e.Region).HasColumnName("region");
        builder.Property(e => e.RegionName).HasColumnName("regionName").HasMaxLength(100);
        builder.Property(e => e.Latitude).HasColumnName("latitude").HasColumnType("numeric");
        builder.Property(e => e.Longitude).HasColumnName("longitude").HasColumnType("numeric");
        builder.Property(e => e.RouteNumber).HasColumnName("routeNumber").HasMaxLength(100);

        // Abuse
        builder.Property(e => e.AbuseOption).HasColumnName("AbuseOption");
        builder.Property(e => e.ConfirmationOfPersonalDetailsOption).HasColumnName("ConfirmationOfPersonalDetailsOption");
        builder.Property(e => e.ContactPersonOption).HasColumnName("ContactPersonOption");
        builder.Property(e => e.ForgeryComment).HasColumnName("forgeryComment");
        builder.Property(e => e.TimeClarification).HasColumnName("timeClarification");
        builder.Property(e => e.PersonalDetailsComment).HasColumnName("personalDetailsComment");
        builder.Property(e => e.IsAbuse).HasColumnName("isAbuse");

        // Relationships
        builder.HasOne(e => e.Company).WithMany().HasForeignKey(e => e.FirmId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(e => e.IncidentTask).WithMany(e => e.Incidents).HasForeignKey(e => e.TaskId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(e => e.Turn).WithMany(e => e.Incidents).HasForeignKey(e => e.TurnId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(e => e.IncidentImages).WithOne(e => e.Incident).HasForeignKey(e => e.IncidentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(e => e.ExportReports).WithOne(e => e.Incident).HasForeignKey(e => e.IncidentId).OnDelete(DeleteBehavior.Cascade);
    }
}
