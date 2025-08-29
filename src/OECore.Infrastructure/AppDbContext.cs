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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}




