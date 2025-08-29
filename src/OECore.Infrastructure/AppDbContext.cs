using Microsoft.EntityFrameworkCore;
using OECore.Domain.Entities;

namespace OECore.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Core entities
    public DbSet<User> Users => Set<User>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<UserCompany> UserCompanies => Set<UserCompany>();
    public DbSet<Region> Regions => Set<Region>();
    public DbSet<CompanyRegion> CompanyRegions => Set<CompanyRegion>();

    // Configuration entities
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<Currency> Currencies => Set<Currency>();
    public DbSet<FirstName> FirstNames => Set<FirstName>();
    public DbSet<LastName> LastNames => Set<LastName>();
    public DbSet<ZipAddressCity> ZipAddressCities => Set<ZipAddressCity>();
    public DbSet<RefundReason> RefundReasons => Set<RefundReason>();
    public DbSet<TableMapping> TableMappings => Set<TableMapping>();
    public DbSet<ConfigLog> ConfigLogs => Set<ConfigLog>();
    public DbSet<EmailTextDestination> EmailTextDestinations => Set<EmailTextDestination>();
    public DbSet<EmailText> EmailTexts => Set<EmailText>();
    public DbSet<Behaviour> Behaviours => Set<Behaviour>();
    public DbSet<CommentsTemplate> CommentsTemplates => Set<CommentsTemplate>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<Theme> Themes => Set<Theme>();
    public DbSet<ControlType> ControlTypes => Set<ControlType>();
    public DbSet<CleanJobsConfiguration> CleanJobsConfigurations => Set<CleanJobsConfiguration>();
    public DbSet<ConfirmationOfPersonalDetailsOption> ConfirmationOfPersonalDetailsOptions => Set<ConfirmationOfPersonalDetailsOption>();
    public DbSet<ContactPersonOption> ContactPersonOptions => Set<ContactPersonOption>();
    public DbSet<AbuseOption> AbuseOptions => Set<AbuseOption>();
    public DbSet<OthersCategory> OthersCategories => Set<OthersCategory>();

    // Timetable entities
    public DbSet<TimetableAgency> TimetableAgencies => Set<TimetableAgency>();
    public DbSet<TimetableCalendar> TimetableCalendars => Set<TimetableCalendar>();
    public DbSet<TimetableStop> TimetableStops => Set<TimetableStop>();
    public DbSet<TimetableRoute> TimetableRoutes => Set<TimetableRoute>();
    public DbSet<TimetableTrip> TimetableTrips => Set<TimetableTrip>();
    public DbSet<TimetableStopTime> TimetableStopTimes => Set<TimetableStopTime>();
    public DbSet<TimetableCalendarDate> TimetableCalendarDates => Set<TimetableCalendarDate>();

    // Statistics and Logs entities
    public DbSet<StatisticsLogin> StatisticsLogins => Set<StatisticsLogin>();
    public DbSet<StatisticsUpload> StatisticsUploads => Set<StatisticsUpload>();
    public DbSet<StatisticsDeviceData> StatisticsDeviceData => Set<StatisticsDeviceData>();
    public DbSet<DebugQuery> DebugQueries => Set<DebugQuery>();
    public DbSet<DebugRequestTimeCheck> DebugRequestTimeChecks => Set<DebugRequestTimeCheck>();
    public DbSet<DeviceLog> DeviceLogs => Set<DeviceLog>();
    public DbSet<DeviceIncidentLog> DeviceIncidentLogs => Set<DeviceIncidentLog>();

    // Application Configuration entities
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<Parameter> Parameters => Set<Parameter>();

    // Configuration with Light Dependencies entities
    public DbSet<ReasonCategory> ReasonCategories => Set<ReasonCategory>();
    public DbSet<ReasonSubcategory> ReasonSubcategories => Set<ReasonSubcategory>();
    public DbSet<Station> Stations => Set<Station>();
    public DbSet<Route> Routes => Set<Route>();
    public DbSet<StationRoute> StationRoutes => Set<StationRoute>();
    public DbSet<TrafficType> TrafficTypes => Set<TrafficType>();
    public DbSet<Dashboard> Dashboards => Set<Dashboard>();
    public DbSet<Widget> Widgets => Set<Widget>();

    // Ticketing entities
    public DbSet<TicketingCategory> TicketingCategories => Set<TicketingCategory>();
    public DbSet<TicketingClass> TicketingClasses => Set<TicketingClass>();
    public DbSet<TicketingProduct> TicketingProducts => Set<TicketingProduct>();
    public DbSet<TicketingProductPrice> TicketingProductPrices => Set<TicketingProductPrice>();
    public DbSet<TicketingTicket> TicketingTickets => Set<TicketingTicket>();
    public DbSet<TicketingTicketLine> TicketingTicketLines => Set<TicketingTicketLine>();
    public DbSet<TicketingTicketImage> TicketingTicketImages => Set<TicketingTicketImage>();

    // NOVA entities
    public DbSet<NovaTicket> NovaTickets => Set<NovaTicket>();
    public DbSet<NovaProductData> NovaProductData => Set<NovaProductData>();
    public DbSet<NovaCompanyProductData> NovaCompanyProductData => Set<NovaCompanyProductData>();

    // INCIDENTS entities
    public DbSet<Incident> Incidents => Set<Incident>();
    public DbSet<IncidentImage> IncidentImages => Set<IncidentImage>();
    public DbSet<IncidentExportReport> IncidentExportReports => Set<IncidentExportReport>();
    public DbSet<IncidentsLog> IncidentsLogs => Set<IncidentsLog>();
    public DbSet<IncidentTask> IncidentTasks => Set<IncidentTask>();
    public DbSet<Turn> Turns => Set<Turn>();
    public DbSet<TaskType> TaskTypes => Set<TaskType>();
    public DbSet<TaskType1> TaskType1 => Set<TaskType1>();
    public DbSet<TaskType3> TaskType3 => Set<TaskType3>();

    // FORMS entities
    public DbSet<SurveyTemplate> SurveyTemplates => Set<SurveyTemplate>();
    public DbSet<Survey> Surveys => Set<Survey>();
    public DbSet<FormSection> FormSections => Set<FormSection>();
    public DbSet<FormQuestion> FormQuestions => Set<FormQuestion>();
    public DbSet<FormAnswer> FormAnswers => Set<FormAnswer>();
    public DbSet<SurveyTemplateCompany> SurveyTemplateCompanies => Set<SurveyTemplateCompany>();
    public DbSet<SurveyTemplateSection> SurveyTemplateSections => Set<SurveyTemplateSection>();

    // DOCBOX entities
    public DbSet<DocboxDocument> DocboxDocuments => Set<DocboxDocument>();
    public DbSet<DocboxFolder> DocboxFolders => Set<DocboxFolder>();
    public DbSet<DocboxDocumentUserRead> DocboxDocumentUserReads => Set<DocboxDocumentUserRead>();
    public DbSet<DocboxFavorite> DocboxFavorites => Set<DocboxFavorite>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}




