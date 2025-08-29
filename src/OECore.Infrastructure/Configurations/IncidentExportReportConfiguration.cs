using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class IncidentExportReportConfiguration : IEntityTypeConfiguration<IncidentExportReport>
{
    public void Configure(EntityTypeBuilder<IncidentExportReport> builder)
    {
        builder.ToTable("tblIncidentExportReport");
        builder.HasKey(e => e.IncidentId);
        
        builder.Property(e => e.IncidentId).HasColumnName("incidentId");
        builder.Property(e => e.Quittungsnummer).HasColumnName("quittungsnummer").HasMaxLength(150);
        builder.Property(e => e.Laufnummer).HasColumnName("laufnummer");
        builder.Property(e => e.UserId).HasColumnName("userID");
        builder.Property(e => e.PersonalNummer).HasColumnName("personalNummer").HasMaxLength(500);
        builder.Property(e => e.PartnerTuId).HasColumnName("partnerTuID");
        builder.Property(e => e.PartnerTu).HasColumnName("partnerTu").HasMaxLength(80);
        builder.Property(e => e.Kontrollart).HasColumnName("kontrollart");
        builder.Property(e => e.Linie).HasColumnName("linie").HasMaxLength(160);
        builder.Property(e => e.LinieNr).HasColumnName("linieNr").HasMaxLength(100);
        builder.Property(e => e.Richtung).HasColumnName("richtung").HasMaxLength(256);
        builder.Property(e => e.Kontrollhaltestelle).HasColumnName("kontrollhaltestelle").HasMaxLength(256);
        builder.Property(e => e.Strafantragscode).HasColumnName("strafantragscode").HasMaxLength(80);
        builder.Property(e => e.Kontrolldatum).HasColumnName("kontrolldatum").HasColumnType("timestamp");
        builder.Property(e => e.GeschlechtFahrgast).HasColumnName("geschlechtFahrgast").HasMaxLength(10);
        builder.Property(e => e.NachnameFahrgast).HasColumnName("nachnameFahrgast").HasMaxLength(500);
        builder.Property(e => e.VornameFahrgast).HasColumnName("vornameFahrgast").HasMaxLength(500);
        builder.Property(e => e.GeburtsdatumFahrgast).HasColumnName("geburtsdatumFahrgast").HasColumnType("timestamp");
        builder.Property(e => e.WohnortFahrgast).HasColumnName("wohnortFahrgast").HasMaxLength(500);
        builder.Property(e => e.StrasseFahrgast).HasColumnName("strasseFahrgast").HasMaxLength(500);
        builder.Property(e => e.HausnummerFahrgast).HasColumnName("hausnummerFahrgast").HasMaxLength(500);
        builder.Property(e => e.WohnlandFahrgast).HasColumnName("wohnlandFahrgast").HasMaxLength(20);
        builder.Property(e => e.PostleitzahlFahrgast).HasColumnName("postleitzahlFahrgast").HasMaxLength(500);
        builder.Property(e => e.AdresseFahrgast).HasColumnName("adresseFahrgast").HasMaxLength(500);
        builder.Property(e => e.ZusatzadresseFahrgast).HasColumnName("zusatzadresseFahrgast").HasMaxLength(500);
        builder.Property(e => e.BürgerortFahrgast).HasColumnName("bürgerortFahrgast").HasMaxLength(500);
        builder.Property(e => e.MailAdresse).HasColumnName("mailAdresse").HasMaxLength(64);
        builder.Property(e => e.MobileNummer).HasColumnName("mobileNummer").HasMaxLength(160);
        builder.Property(e => e.GeschlechtErzieher).HasColumnName("geschlechtErzieher").HasMaxLength(10);
        builder.Property(e => e.NachnameErzieher).HasColumnName("nachnameErzieher").HasMaxLength(500);
        builder.Property(e => e.VornameErzieher).HasColumnName("vornameErzieher").HasMaxLength(500);
        builder.Property(e => e.AdresseErzieher).HasColumnName("adresseErzieher").HasMaxLength(500);
        builder.Property(e => e.WohnortErzieher).HasColumnName("wohnortErzieher").HasMaxLength(500);
        builder.Property(e => e.WohnlandErzieher).HasColumnName("wohnlandErzieher").HasMaxLength(500);
        builder.Property(e => e.StrasseErzieher).HasColumnName("strasseErzieher").HasMaxLength(500);
        builder.Property(e => e.HausnummerErzieher).HasColumnName("hausnummerErzieher").HasMaxLength(500);
        builder.Property(e => e.PostleitzahlErzieher).HasColumnName("postleitzahlErzieher").HasMaxLength(40);
        builder.Property(e => e.ZusatzadresseErzieher).HasColumnName("zusatzadresseErzieher").HasMaxLength(500);
        builder.Property(e => e.TutorEmail).HasColumnName("tutorEmail").HasMaxLength(500);
        builder.Property(e => e.TutorPhone).HasColumnName("tutorPhone").HasMaxLength(50);
        builder.Property(e => e.Ausweisart).HasColumnName("ausweisart").HasMaxLength(30);
        builder.Property(e => e.Ausweisnummer).HasColumnName("ausweisnummer").HasMaxLength(500);
        builder.Property(e => e.Zemisnummer).HasColumnName("zemisnummer").HasMaxLength(500);
        builder.Property(e => e.AusstellungsortDesAusweises).HasColumnName("ausstellungsortDesAusweises").HasMaxLength(500);
        builder.Property(e => e.Beanstandungsgrund1).HasColumnName("beanstandungsgrund1").HasMaxLength(500);
        builder.Property(e => e.Beanstandungsgrund2).HasColumnName("beanstandungsgrund2").HasMaxLength(500);
        builder.Property(e => e.Beanstandungsgrund3).HasColumnName("beanstandungsgrund3").HasMaxLength(500);
        builder.Property(e => e.Beanstandungsgrund4).HasColumnName("beanstandungsgrund4").HasMaxLength(500);
        builder.Property(e => e.Währung).HasColumnName("währung").HasMaxLength(30);
        builder.Property(e => e.Wechselkurs).HasColumnName("wechselkurs").HasColumnType("numeric");
        builder.Property(e => e.BarzahlungInChf).HasColumnName("barzahlungInCHF").HasColumnType("numeric");
        builder.Property(e => e.BarzahlungInFremdwahrung).HasColumnName("barzahlungInFremdwahrung").HasColumnType("numeric");
        builder.Property(e => e.Kreditkartenzahlung).HasColumnName("kreditkartenzahlung").HasColumnType("numeric");
        builder.Property(e => e.Onlinekartenzahlung).HasColumnName("onlinekartenzahlung").HasColumnType("numeric");
        builder.Property(e => e.Grundgebühr).HasColumnName("grundgebühr").HasColumnType("numeric");
        builder.Property(e => e.Fahrpreispauschale).HasColumnName("fahrpreispauschale").HasColumnType("numeric");
        builder.Property(e => e.Bearbeitungssgebuhr).HasColumnName("bearbeitungssgebuhr").HasColumnType("numeric");
        builder.Property(e => e.Missbrauchsgebuhr).HasColumnName("missbrauchsgebuhr").HasColumnType("numeric");
        builder.Property(e => e.Falschungsgebühr).HasColumnName("falschungsgebühr").HasColumnType("numeric");
        builder.Property(e => e.Zeitzuschlagsgebuhr).HasColumnName("zeitzuschlagsgebuhr").HasColumnType("numeric");
        builder.Property(e => e.DiverseGebuhren).HasColumnName("diverseGebuhren").HasColumnType("numeric");
        builder.Property(e => e.RuckgeldInChf).HasColumnName("ruckgeldInCHF").HasColumnType("numeric");
        builder.Property(e => e.VerhaltenKunde1).HasColumnName("verhaltenKunde1").HasMaxLength(20);
        builder.Property(e => e.BemerkungKontrolleur).HasColumnName("bemerkungKontrolleur").HasMaxLength(4000);
        builder.Property(e => e.Storno).HasColumnName("storno");
        builder.Property(e => e.BegrundungStorno).HasColumnName("begrundungStorno").HasMaxLength(500);
        builder.Property(e => e.Zone).HasColumnName("zone").HasMaxLength(500);
        builder.Property(e => e.Wagennummer).HasColumnName("wagennummer").HasMaxLength(500);
        builder.Property(e => e.ExportTime).HasColumnName("exportTime").HasColumnType("timestamp");
        builder.Property(e => e.ExportedToCsv).HasColumnName("exportedToCsv").HasColumnType("timestamp");
        builder.Property(e => e.Domain).HasColumnName("domain").HasMaxLength(500);
        builder.Property(e => e.CompanyCode).HasColumnName("companyCode").HasMaxLength(20);
        builder.Property(e => e.Total).HasColumnName("total").HasColumnType("numeric");
        builder.Property(e => e.Name).HasColumnName("name").HasMaxLength(500);
        builder.Property(e => e.LastName).HasColumnName("lastName").HasMaxLength(500);
        builder.Property(e => e.EmployerId).HasColumnName("employerId");
        builder.Property(e => e.EmployerName).HasColumnName("employerName").HasMaxLength(100);
        builder.Property(e => e.ControlTimeStamp).HasColumnName("controlTimeStamp").HasColumnType("timestamp");
        builder.Property(e => e.PersId).HasColumnName("persID").HasMaxLength(50);
        builder.Property(e => e.HbkKey).HasColumnName("hbkKey").HasMaxLength(50);
        builder.Property(e => e.TutorPersId).HasColumnName("tutorPersID").HasMaxLength(50);
        builder.Property(e => e.TutorHbkKey).HasColumnName("tutorHbkKey").HasMaxLength(50);
        builder.Property(e => e.Begrundung1erFall).HasColumnName("begrundung1erFall").HasMaxLength(1000);
        builder.Property(e => e.AbuseOption).HasColumnName("AbuseOption").HasMaxLength(500);
        builder.Property(e => e.ConfirmationOfPersonalDetailsOption).HasColumnName("ConfirmationOfPersonalDetailsOption").HasMaxLength(500);
        builder.Property(e => e.ContactPersonOption).HasColumnName("ContactPersonOption").HasMaxLength(500);
        builder.Property(e => e.ForgeryComment).HasColumnName("ForgeryComment").HasMaxLength(500);
        builder.Property(e => e.TimeClarification).HasColumnName("TimeClarification");
        builder.Property(e => e.PersonalDetailsComment).HasColumnName("PersonalDetailsComment").HasMaxLength(500);
        builder.Property(e => e.PassengerPreferredLanguage).HasColumnName("PassengerPreferredLanguage").HasMaxLength(10);
        builder.Property(e => e.ConfirmedNoBackendAccess).HasColumnName("ConfirmedNOBackendAccess");
        builder.Property(e => e.ConfirmedNoPaymentProviderAccess).HasColumnName("ConfirmedNOPaymentProviderAccess");
        builder.Property(e => e.ConfirmedWithNoPayment).HasColumnName("ConfirmedWithNOPayment");
        builder.Property(e => e.PayrexxGatewayId).HasColumnName("PayrexxGatewayId");
        builder.Property(e => e.RefundAttempt).HasColumnName("RefundAttempt");
        builder.Property(e => e.QrGenerations).HasColumnName("QRGenerations");
        builder.Property(e => e.QrDownloads).HasColumnName("QRDownloads");
        builder.Property(e => e.PrintingAttempts).HasColumnName("PrintingAttempts");
        builder.Property(e => e.MailSendings).HasColumnName("MailSendings");

        // Relationship
        builder.HasOne(e => e.Incident).WithMany(e => e.ExportReports).HasForeignKey(e => e.IncidentId).OnDelete(DeleteBehavior.Restrict);
    }
}
