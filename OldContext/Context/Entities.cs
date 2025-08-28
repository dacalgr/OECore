namespace OpenEyeBackendEntities
{
    using OpenEyeBackendEntities.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    

    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
            //Database.SetInitializer<Entities>(null);

            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180; // seconds
        }

        public int UpdateParentFolders(Nullable<int> parentID)
        {
            int parentIDParameter = parentID.HasValue ? parentID.Value : -1;
                //new ObjectParameter("ParentID", typeof(int));


            string sqlCommand = $@"
                SET NOCOUNT ON;
		        /*******************************************************************
		        *******************************************************************/
		        -- Generate virtualPath and hierarchy for folders
		        WITH children
		        AS 
			        (
				        --Find the root record - This is called your Anchor
				        SELECT    id
					          , name
					          , CAST('' AS nvarchar(MAX)) AS PathName
					          , CAST(id AS nvarchar(MAX)) AS Hierarchy
				        FROM      tbl_DOCBOX_Folders
				        WHERE     ParentID is null
				        UNION ALL
				        -- Find all other records in the table - This is the Recursive Member
				        -- Make sure your anchor record is NOT a part of this data set or
				        -- you'll get an infinite loop problem
				        SELECT    child.id
					          , child.name
					          , PathName = parent.PathName + '/' + child.name
					          , Hierarchy =  parent.Hierarchy + '/' + CAST(child.id AS nvarchar(MAX))
				        FROM      tbl_DOCBOX_Folders AS child
						        INNER JOIN children AS parent ON child.ParentID = parent.ID
			         )
			 
		        UPDATE tbl_DOCBOX_Folders SET virtualPath = c.PathName, hierarchy = c.Hierarchy
		        FROM children c
		        INNER JOIN dbo.tbl_DOCBOX_Folders f ON c.id = f.id;
		
		
		
		        /*******************************************************************
		        *******************************************************************/
		        -- Regenate profiles for parent folder
		        WITH children 
		        AS 
			        (
				        --Find the root record - This is called your Anchor
				        SELECT    id
					          , name
					          , CAST('' AS nvarchar(MAX)) AS PathName
					          , CAST(id AS nvarchar(MAX)) AS Hierarchy
					          , ROW_NUMBER() OVER ( ORDER BY id ) AS RN
					          , 1 AS Level				  
				        FROM      tbl_DOCBOX_Folders
				        WHERE     ParentID is null
				        UNION ALL
				        -- Find all other records in the table - This is the Recursive Member
				        -- Make sure your anchor record is NOT a part of this data set or
				        -- you'll get an infinite loop problem
				        SELECT    child.id
					          , child.name
					          , PathName = parent.PathName + '/' + child.name
					          , Hierarchy = parent.Hierarchy + '/' + CAST(child.id AS nvarchar(MAX))
					          , parent.RN
					          , Level + 1
				        FROM      tbl_DOCBOX_Folders AS child
						        INNER JOIN children AS parent ON child.ParentID = parent.ID
                        WHERE child.dtDeleted is NULL
			         )
		 
		 		
		        INSERT INTO [dbo].tbl_DOCBOX_FoldersProfile 
		        SELECT F.*
		        FROM
		          ( SELECT DISTINCT F.parentId folderId,
							        FP.profileId
		           FROM
			         ( SELECT iTVF.id parentId,
					          cr.id,
					          CR.RN,
					          '/' + CR.Hierarchy + '/' HIERARCHY,
											           cr. NAME,
											           cr.PathName,
											           cr. LEVEL
			          FROM children CR CROSS APPLY
				        ( SELECT CRI.HIERARCHY, CRI.RN, cri.id, cri. NAME, cri.PathName, cri. LEVEL
				         FROM children CRI
				         WHERE CR.RN = CRI.RN
				           AND CR. LEVEL >= CRI. LEVEL ) iTVF ) F --

		           INNER JOIN tbl_DOCBOX_FoldersProfile FP ON F.id = FP.folderId
		           WHERE F.HIERARCHY LIKE '%/' + CAST(F.parentId AS VARCHAR) + '/%'
			         -- AND F.parentId = 1 
			        ) F
		        LEFT JOIN tbl_DOCBOX_FoldersProfile FP ON F.folderId = FP.folderId
		        AND F.profileId = FP.profileId
		        WHERE FP.folderId IS NULL AND F.folderId <> {(parentID.HasValue ? parentID.Value.ToString() : "NULL")}
		        ORDER BY F.folderId
";

            using (var con = new SqlConnection("Entities"))
            using (var cmd = new SqlCommand(sqlCommand, con))
            {
                con.Open();
                return cmd.ExecuteNonQuery();
            }


            //return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateParentFolders", parentIDParameter);
        }


        public virtual DbSet<tbl_BACKEND_ColumnsConfiguration> tbl_BACKEND_ColumnsConfiguration { get; set; }
        public virtual DbSet<tbl_BACKEND_FieldsConfiguration> tbl_BACKEND_FieldsConfiguration { get; set; }
        public virtual DbSet<tbl_BACKUP_Bills> tbl_BACKUP_Bills { get; set; }
        public virtual DbSet<tbl_BACKUP_Companies> tbl_BACKUP_Companies { get; set; }
        public virtual DbSet<tbl_BACKUP_Companies_Regions> tbl_BACKUP_Companies_Regions { get; set; }
        public virtual DbSet<tbl_BACKUP_IDCardType> tbl_BACKUP_IDCardType { get; set; }
        public virtual DbSet<tbl_BACKUP_Regions> tbl_BACKUP_Regions { get; set; }
        public virtual DbSet<tbl_CONFIG_Agency> tbl_CONFIG_Agency { get; set; }
        public virtual DbSet<tbl_CONFIG_Applications> tbl_CONFIG_Applications { get; set; }
        public virtual DbSet<tbl_CONFIG_Applications_Parameters_Values> tbl_CONFIG_Applications_Parameters_Values { get; set; }
        public virtual DbSet<tbl_CONFIG_Behaviours> tbl_CONFIG_Behaviours { get; set; }
        public virtual DbSet<tbl_CONFIG_BelegRole> tbl_CONFIG_BelegRole { get; set; }
        public virtual DbSet<tbl_CONFIG_CardTypes> tbl_CONFIG_CardTypes { get; set; }
        public virtual DbSet<tbl_CONFIG_CleanJobs> tbl_CONFIG_CleanJobs { get; set; }
        public virtual DbSet<tbl_CONFIG_CleanJobsConfiguration> tbl_CONFIG_CleanJobsConfiguration { get; set; }
        public virtual DbSet<tbl_CONFIG_CodeScanTypes> tbl_CONFIG_CodeScanTypes { get; set; }
        public virtual DbSet<tbl_CONFIG_CodeScanTypes_Companies> tbl_CONFIG_CodeScanTypes_Companies { get; set; }
        public virtual DbSet<tbl_CONFIG_CommentsTemplates> tbl_CONFIG_CommentsTemplates { get; set; }
        public virtual DbSet<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
        public virtual DbSet<tbl_CONFIG_ConfigurationData> tbl_CONFIG_ConfigurationData { get; set; }
        //public virtual DbSet<tbl_CONFIG_ConfigurationData_SqLite> tbl_CONFIG_ConfigurationData_SqLite { get; set; }
        public virtual DbSet<tbl_CONFIG_ControlTypes> tbl_CONFIG_ControlTypes { get; set; }
        public virtual DbSet<tbl_CONFIG_Countries> tbl_CONFIG_Countries { get; set; }
        public virtual DbSet<tbl_CONFIG_Currencies> tbl_CONFIG_Currencies { get; set; }
        public virtual DbSet<tbl_CONFIG_Dashboards> tbl_CONFIG_Dashboards { get; set; }
        public virtual DbSet<tbl_CONFIG_Dashboards_Applications> tbl_CONFIG_Dashboards_Applications { get; set; }
        public virtual DbSet<tbl_CONFIG_Dashboards_Widgets> tbl_CONFIG_Dashboards_Widgets { get; set; }
        public virtual DbSet<tbl_CONFIG_DispoStats> tbl_CONFIG_DispoStats { get; set; }
        public virtual DbSet<tbl_CONFIG_EmailTexts> tbl_CONFIG_EmailTexts { get; set; }
        public virtual DbSet<tbl_CONFIG_EmailTexts_Destinations> tbl_CONFIG_EmailTexts_Destinations { get; set; }
        public virtual DbSet<tbl_CONFIG_Firstnames> tbl_CONFIG_Firstnames { get; set; }
        public virtual DbSet<tbl_CONFIG_LastNames> tbl_CONFIG_LastNames { get; set; }
        public virtual DbSet<tbl_CONFIG_Log> tbl_CONFIG_Log { get; set; }
        public virtual DbSet<tbl_CONFIG_OthersCategories> tbl_CONFIG_OthersCategories { get; set; }
        public virtual DbSet<tbl_CONFIG_Parameters> tbl_CONFIG_Parameters { get; set; }
        public virtual DbSet<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }
        public virtual DbSet<tbl_CONFIG_ReasonsCategories> tbl_CONFIG_ReasonsCategories { get; set; }
        public virtual DbSet<tbl_CONFIG_ReasonsSubcategories> tbl_CONFIG_ReasonsSubcategories { get; set; }
        public virtual DbSet<tbl_CONFIG_RefundReasons> tbl_CONFIG_RefundReasons { get; set; }
        public virtual DbSet<tbl_CONFIG_Regions> tbl_CONFIG_Regions { get; set; }
        public virtual DbSet<tbl_CONFIG_Routes> tbl_CONFIG_Routes { get; set; }
        public virtual DbSet<tbl_CONFIG_Stations> tbl_CONFIG_Stations { get; set; }
        public virtual DbSet<tbl_CONFIG_StationsRoutes> tbl_CONFIG_StationsRoutes { get; set; }
        public virtual DbSet<tbl_CONFIG_TableMapping> tbl_CONFIG_TableMapping { get; set; }
        public virtual DbSet<tbl_CONFIG_Themes> tbl_CONFIG_Themes { get; set; }
        public virtual DbSet<tbl_CONFIG_TrafficTypes> tbl_CONFIG_TrafficTypes { get; set; }
        public virtual DbSet<tbl_CONFIG_Widgets> tbl_CONFIG_Widgets { get; set; }
        public virtual DbSet<tbl_CONFIG_Widgets_Parameters_Values> tbl_CONFIG_Widgets_Parameters_Values { get; set; }
        public virtual DbSet<tbl_CONFIG_ZipAddressCity> tbl_CONFIG_ZipAddressCity { get; set; }
        public virtual DbSet<tbl_DEBUG_Queries> tbl_DEBUG_Queries { get; set; }
        public virtual DbSet<tbl_DEBUG_RequestTimeCheck> tbl_DEBUG_RequestTimeCheck { get; set; }
        public virtual DbSet<tbl_DEVICE_LOGS_DeviceLogs> tbl_DEVICE_LOGS_DeviceLogs { get; set; }
        public virtual DbSet<tbl_DEVICE_LOGS_IncidentLogs> tbl_DEVICE_LOGS_IncidentLogs { get; set; }
        public virtual DbSet<tbl_DISPO_LineStats> tbl_DISPO_LineStats { get; set; }
        public virtual DbSet<tbl_DISPO_LineStats_Temp> tbl_DISPO_LineStats_Temp { get; set; }
        public virtual DbSet<tbl_DISPO_TU2Line> tbl_DISPO_TU2Line { get; set; }
        public virtual DbSet<tbl_DISPO_TU2Line_Temp> tbl_DISPO_TU2Line_Temp { get; set; }
        public virtual DbSet<tbl_DOCBOX_Documents> tbl_DOCBOX_Documents { get; set; }
        public virtual DbSet<tbl_DOCBOX_DocumentsUsersRead> tbl_DOCBOX_DocumentsUsersRead { get; set; }
        public virtual DbSet<tbl_DOCBOX_Folders> tbl_DOCBOX_Folders { get; set; }
        //public virtual DbSet<tbl_DOCBOX_Tags> tbl_DOCBOX_Tags { get; set; }
        public virtual DbSet<tbl_DOCBOX_Favorites> tbl_DOCBOX_Favorites { get; set; }
        public virtual DbSet<tbl_FORMS_Answers> tbl_FORMS_Answers { get; set; }
        public virtual DbSet<tbl_FORMS_Questions> tbl_FORMS_Questions { get; set; }
        public virtual DbSet<tbl_FORMS_Sections> tbl_FORMS_Sections { get; set; }
        public virtual DbSet<tbl_FORMS_Surveys> tbl_FORMS_Surveys { get; set; }
        public virtual DbSet<tbl_FORMS_SurveyTemplates> tbl_FORMS_SurveyTemplates { get; set; }
        public virtual DbSet<tbl_FORMS_SurveyTemplates_Companies> tbl_FORMS_SurveyTemplates_Companies { get; set; }
        public virtual DbSet<tbl_FORMS_SurveyTemplates_Sections> tbl_FORMS_SurveyTemplates_Sections { get; set; }
       // public virtual DbSet<tbl_IDCardType> tbl_IDCardType { get; set; }
        //public virtual DbSet<tbl_LITE_Regions> tbl_LITE_Regions { get; set; }
        //public virtual DbSet<tbl_STATISTICS_devicesData> tbl_STATISTICS_devicesData { get; set; }


        public virtual DbSet<tbl_MONITOR_Data> tbl_MONITOR_Data { get; set; }
        public virtual DbSet<tbl_MONITOR_RoleConfiguration> tbl_MONITOR_RoleConfiguration { get; set; }
        public virtual DbSet<tbl_MONITOR_UserConfiguration> tbl_MONITOR_UserConfiguration { get; set; }
        public virtual DbSet<tbl_MONITOR_ReminderUserExpirationEmail> tbl_MONITOR_ReminderUserExpirationEmail { get; set; }
        public virtual DbSet<tbl_MONITOR_WorldlineStornoTask> tbl_MONITOR_WorldlineStornoTask { get; set; }
        public virtual DbSet<tbl_MONITOR_InactiveUserData> tbl_MONITOR_InactiveUserData { get; set; }

        public virtual DbSet<tbl_NOVA_Tickets> tbl_NOVA_Tickets { get; set; }
        public virtual DbSet<tbl_NOVA_ProductData> tbl_NOVA_ProductData { get; set; }
        public virtual DbSet<tbl_STATISTICS_Logins> tbl_STATISTICS_Logins { get; set; }
        public virtual DbSet<tbl_STATISTICS_Uploads> tbl_STATISTICS_Uploads { get; set; }
        public virtual DbSet<tbl_TICKETING_Categories> tbl_TICKETING_Categories { get; set; }
        public virtual DbSet<tbl_TICKETING_Classes> tbl_TICKETING_Classes { get; set; }
        public virtual DbSet<tbl_TICKETING_ProductPrices> tbl_TICKETING_ProductPrices { get; set; }
        public virtual DbSet<tbl_TICKETING_Products> tbl_TICKETING_Products { get; set; }
        public virtual DbSet<tbl_TICKETING_Tickets> tbl_TICKETING_Tickets { get; set; }
        public virtual DbSet<tbl_TICKETING_TicketsLines> tbl_TICKETING_TicketsLines { get; set; }
        public virtual DbSet<tbl_TICKETING_TicketsImages> tbl_TICKETING_TicketsImages { get; set; }
        public virtual DbSet<tblAudit> tblAudits { get; set; }
        public virtual DbSet<tblBalanceHistory> tblBalanceHistories { get; set; }
        public virtual DbSet<tblBillLine> tblBillLines { get; set; }
        public virtual DbSet<tblBillLinesLog> tblBillLinesLogs { get; set; }
        public virtual DbSet<tblBill> tblBills { get; set; }
        public virtual DbSet<tblBlacklist> tblBlacklists { get; set; }
        public virtual DbSet<tblBlackListFile> tblBlackListFiles { get; set; }
        public virtual DbSet<tblCardType> tblCardTypes { get; set; }
        public virtual DbSet<tblCashCheckHistory> tblCashCheckHistories { get; set; }
        public virtual DbSet<tblCompany> tblCompanies { get; set; }
        public virtual DbSet<tblCompanies_Regions> tblCompanies_Regions { get; set; }
        //public virtual DbSet<tblCompaniesTeam> tblCompaniesTeams { get; set; }
        public virtual DbSet<tblCompanyMapping> tblCompanyMappings { get; set; }
        public virtual DbSet<tblConfigurationData> tblConfigurationDatas { get; set; }
        public virtual DbSet<tblContact> tblContacts { get; set; }
        public virtual DbSet<tblControlBase> tblControlBases { get; set; }
        public virtual DbSet<tblControlType> tblControlTypes { get; set; }
        public virtual DbSet<tblDomainExportTime> tblDomainExportTimes { get; set; }
        public virtual DbSet<tblDeltavistaLog> tblDeltavistaLogs { get; set; }
        public virtual DbSet<tblEmployer> tblEmployers { get; set; }
        public virtual DbSet<tblExportConfiguration> tblExportConfigurations { get; set; }
        //public virtual DbSet<tblHistoricalIncident> tblHistoricalIncidents { get; set; }
        public virtual DbSet<tblIncidentExportReport> tblIncidentExportReports { get; set; }
        public virtual DbSet<tblIncidentImage> tblIncidentImages { get; set; }
        public virtual DbSet<tblIncident> tblIncidents { get; set; }
        public virtual DbSet<tblIncidentsLog> tblIncidentsLogs { get; set; }
        public virtual DbSet<tblLanguage> tblLanguages { get; set; }
        public virtual DbSet<tblLog> tblLogs { get; set; }
        public virtual DbSet<tblLog_ConfigValues> tblLog_ConfigValues { get; set; }
        // public virtual DbSet<tblMandatoryConfiguration> tblMandatoryConfigurations { get; set; }

        public virtual DbSet<tblMailing> tblMailing { get; set; }
        
        public virtual DbSet<tblMultilingualText> tblMultilingualTexts { get; set; }
        public virtual DbSet<tblName> tblNames { get; set; }

        public virtual DbSet<tblNewPinkExportRecord> tblNewPinkExportRecords { get; set; }
        public virtual DbSet<tblOtherTaskCategory> tblOtherTaskCategories { get; set; }
        public virtual DbSet<tblPaymentMode> tblPaymentModes { get; set; }
        public virtual DbSet<tblRegion> tblRegions { get; set; }
        public virtual DbSet<tblSurname> tblSurnames { get; set; }
        public virtual DbSet<tblTaskExportReport> tblTaskExportReports { get; set; }
        public virtual DbSet<tblTask> tblTasks { get; set; }
        public virtual DbSet<tblTasksLog> tblTasksLogs { get; set; }
        public virtual DbSet<tblTaskType> tblTaskTypes { get; set; }
        public virtual DbSet<tblTaskType1> tblTaskType1 { get; set; }
        public virtual DbSet<tblTaskType3> tblTaskType3 { get; set; }
       // public virtual DbSet<tblTeam> tblTeams { get; set; }
        public virtual DbSet<tblTurn> tblTurns { get; set; }
        public virtual DbSet<tblTurnsLog> tblTurnsLogs { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUsers_Companies> tblUsers_Companies { get; set; }
        public virtual DbSet<tblUsers_Favorites> tblUsers_Favorites { get; set; }
        public virtual DbSet<tblUsers_Profiles> tblUsers_Profiles { get; set; }
        public virtual DbSet<exportedIncident> exportedIncidents { get; set; }
       // public virtual DbSet<tbl_Blacklist_Short> tbl_Blacklist_Short { get; set; }
        public virtual DbSet<tbl_CONFIG_Behaviours_Companies_back> tbl_CONFIG_Behaviours_Companies_back { get; set; }
        public virtual DbSet<tblBlacklistStaging> tblBlacklistStagings { get; set; }
        public virtual DbSet<tblRoute> tblRoutes { get; set; }

        public virtual DbSet<tblPayrexxPayments> tblPayrexxPayments { get; set; }

        //R1 2021 Digitallisierung Bemerkungszettel
        public virtual DbSet<tbl_CONFIG_AbuseOptions> tbl_CONFIG_AbuseOptions { get; set; }
        public virtual DbSet<tbl_CONFIG_ConfirmationOfPersonalDetailsOptions> tbl_CONFIG_ConfirmationOfPersonalDetailsOptions { get; set; }
        public virtual DbSet<tbl_CONFIG_ContactPersonOptions> tbl_CONFIG_ContactPersonOptions { get; set; }
        public virtual DbSet<tblAbuseOptions> tblAbuseOptions { get; set; }
        public virtual DbSet<tblConfirmationOfPersonalDetailsOptions> tblConfirmationOfPersonalDetailsOptions { get; set; }
        public virtual DbSet<tblContactPersonOptions> tblContactPersonOptions { get; set; }

        public virtual DbSet<tbl_APPCONFIG_Actions> tbl_APPCONFIG_Actions { get; set; }
        public virtual DbSet<tbl_APPCONFIG_ActionsConfiguration> tbl_APPCONFIG_ActionsConfiguration { get; set; }


        //public virtual DbSet<tblTurns_MIGRATION> tblTurns_MIGRATION { get; set; }
        public virtual DbSet<vw_balanceHistory> vw_balanceHistory { get; set; }
        public virtual DbSet<vw_billLinesView> vw_billLinesView { get; set; }
        public virtual DbSet<vw_cashCheckHistory> vw_cashCheckHistory { get; set; }
        public virtual DbSet<vw_CONFIG_otherCategories> vw_CONFIG_otherCategories { get; set; }
        public virtual DbSet<vw_confirmedLines> vw_confirmedLines { get; set; }
        public virtual DbSet<vw_deltavista> vw_deltavista { get; set; }
        public virtual DbSet<vw_dispoStats> vw_dispoStats { get; set; }
        public virtual DbSet<vw_incidents> vw_incidents { get; set; }
        public virtual DbSet<vw_incidentsView> vw_incidentsView { get; set; }
        public virtual DbSet<vw_lastSynchronization> vw_lastSynchronization { get; set; }
        public virtual DbSet<vw_LastUploads> vw_LastUploads { get; set; }
        public virtual DbSet<vw_login_statistics> vw_login_statistics { get; set; }
        public virtual DbSet<vw_sold_tickets> vw_sold_tickets { get; set; }

        public virtual DbSet<vw_sold_NOVATickets> vw_sold_NOVAtickets { get; set; }
        public virtual DbSet<vw_ticketingProductPrices> vw_ticketingProductPrices { get; set; }
        public virtual DbSet<vw_ticketsView> vw_ticketsView { get; set; }
        
        public virtual DbSet<vw_turnsExported> vw_turnsExported { get; set; }
        public virtual DbSet<vw_userContacts> vw_userContacts { get; set; }
        public virtual DbSet<tbl_AgreementDocuments> tbl_AgreementDocuments { get; set; }

        public virtual DbSet<tblOnlinePaymentsStatus> tblOnlinePaymentsStatus { get; set; }

        public virtual DbSet<tblDeviceContact>  tblDeviceContact { get; set; }
        public virtual DbSet<tblSpecialPassenger> tblSpecialPassengers { get; set; }
        public virtual DbSet<tblSpecialComment> tblSpecialComments { get; set; }

        public virtual DbSet<tbl_TIMETABLE_AtlasAPI> tbl_TIMETABLE_AtlasAPI { get; set; }
        public virtual DbSet<tbl_TIMETABLE_BusinessOffices> tbl_TIMETABLE_BusinessOffices { get; set; }
        public virtual DbSet<tbl_TIMETABLE_Lines_Future> tbl_TIMETABLE_Lines_Future { get; set; }
        public virtual DbSet<tbl_TIMETABLE_Lines_Today> tbl_TIMETABLE_Lines_Today { get; set; }
        public virtual DbSet<tbl_TIMETABLE_Stations_Future> tbl_TIMETABLE_Stations_Future { get; set; }
        public virtual DbSet<tbl_TIMETABLE_Stations_Today> tbl_TIMETABLE_Stations_Today { get; set; }
        public virtual DbSet<tbl_TIMETABLE_agency> tbl_TIMETABLE_agency { get; set; }
        public virtual DbSet<tbl_TIMETABLE_routes> tbl_TIMETABLE_routes { get; set; }
        public virtual DbSet<tbl_TIMETABLE_trips> tbl_TIMETABLE_trips { get; set; }
        public virtual DbSet<tbl_TIMETABLE_stops> tbl_TIMETABLE_stops { get; set; }
        public virtual DbSet<tbl_TIMETABLE_stop_times> tbl_TIMETABLE_stop_times { get; set; }        
        public virtual DbSet<tbl_TIMETABLE_calendar> tbl_TIMETABLE_calendar { get; set; }
        public virtual DbSet<tbl_TIMETABLE_calendar_dates> tbl_TIMETABLE_calendar_dates { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.surcharge)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.fare)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.fee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.abuse)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.forgery)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.time_penalties)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.miscellaneus)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Bills>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_BACKUP_Regions>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Agency>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Agency>()
                .HasMany(e => e.tbl_CONFIG_Routes)
                .WithOptional(e => e.tbl_CONFIG_Agency)
                .HasForeignKey(e => e.agencyid);

            modelBuilder.Entity<tbl_CONFIG_Applications>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Applications>()
                .HasMany(e => e.tbl_CONFIG_Applications_Parameters_Values)
                .WithRequired(e => e.tbl_CONFIG_Applications)
                .HasForeignKey(e => e.applicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Applications>()
                .HasMany(e => e.tbl_CONFIG_Applications1)
                .WithOptional(e => e.tbl_CONFIG_Applications2)
                .HasForeignKey(e => e.parentId);

            modelBuilder.Entity<tbl_CONFIG_Applications>()
                .HasMany(e => e.tbl_CONFIG_Dashboards_Applications)
                .WithRequired(e => e.tbl_CONFIG_Applications)
                .HasForeignKey(e => e.applicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Applications>()
                .HasMany(e => e.tbl_CONFIG_Widgets)
                .WithOptional(e => e.tbl_CONFIG_Applications)
                .HasForeignKey(e => e.applicationId);

            modelBuilder.Entity<tbl_CONFIG_Behaviours>()
                .Property(e => e.text_it)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_Behaviours>()
                .Property(e => e.text_de)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_Behaviours>()
                .Property(e => e.text_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_Behaviours>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Behaviours>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithMany(e => e.tbl_CONFIG_Behaviours)
                .Map(m => m.ToTable("tbl_CONFIG_Behaviours_Companies").MapLeftKey("behaviourId").MapRightKey("companyId"));

            modelBuilder.Entity<tbl_CONFIG_BelegRole>()
                .HasMany(e => e.tbl_TICKETING_Products)
                .WithRequired(e => e.tbl_CONFIG_BelegRole)
                .HasForeignKey(e => e.belegRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_CardTypes>()
                .Property(e => e.text_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_CardTypes>()
                .Property(e => e.text_it)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_CardTypes>()
                .Property(e => e.companyId)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_CardTypes>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CardTypes>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithMany(e => e.tbl_CONFIG_CardTypes)
                .Map(m => m.ToTable("tbl_CONFIG_CardTypes_Companies").MapLeftKey("cardTypeId").MapRightKey("companyId"));

            modelBuilder.Entity<tbl_CONFIG_CleanJobs>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CleanJobs>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CleanJobs>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CleanJobs>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithOptional(e => e.tbl_CONFIG_CleanJobs)
                .HasForeignKey(e => e.cleanJobId);

            modelBuilder.Entity<tbl_CONFIG_CleanJobsConfiguration>()
                .Property(e => e.lastExecution)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CleanJobsConfiguration>()
                .Property(e => e.nextExecution)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CodeScanTypes>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CodeScanTypes>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CodeScanTypes>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CodeScanTypes>()
                .HasMany(e => e.tbl_CONFIG_CodeScanTypes_Companies)
                .WithRequired(e => e.tbl_CONFIG_CodeScanTypes)
                .HasForeignKey(e => e.codeScanTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_CodeScanTypes_Companies>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CommentsTemplates>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_CommentsTemplates>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithMany(e => e.tbl_CONFIG_CommentsTemplates)
                .Map(m => m.ToTable("tbl_CONFIG_CommentsTemplates_Companies").MapLeftKey("commentsTemplateId").MapRightKey("companyId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_CodeScanTypes_Companies)
                .WithRequired(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_FORMS_Surveys)
                .WithRequired(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_FORMS_SurveyTemplates_Companies)
                .WithRequired(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_TICKETING_Tickets)
                .WithRequired(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tblIncidents)
                .WithOptional(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.firmId);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tblTasks)
                .WithOptional(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.firmId);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tblUsers_Companies)
                .WithRequired(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tblControlBases)
                .WithOptional(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.companyId);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tbl_CONFIG_Companies)
                .HasForeignKey(e => e.employerOf);

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_Profiles)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_Companies_Profiles").MapLeftKey("companyId").MapRightKey("profileId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_Regions)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_Companies_Regions").MapLeftKey("company").MapRightKey("region"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_OthersCategories)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_OthersCategories_Companies").MapLeftKey("companyId").MapRightKey("othersCategoryId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_ReasonsCategories)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_ReasonsCategories_Companies").MapLeftKey("companyId").MapRightKey("reasonsCategoryId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_ReasonsSubcategories)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_ReasonsSubcategories_Companies").MapLeftKey("companyId").MapRightKey("reasonsSubcategoryId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_Routes)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_Routes_Companies").MapLeftKey("companyId").MapRightKey("routeId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_CONFIG_EmailTexts)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_CONFIG_EmailTexts_Companies").MapLeftKey("companyId").MapRightKey("emailTextId"));

            modelBuilder.Entity<tbl_CONFIG_Companies>()
                .HasMany(e => e.tbl_TICKETING_Products)
                .WithMany(e => e.tbl_CONFIG_Companies)
                .Map(m => m.ToTable("tbl_TICKETING_ProductCompanies").MapLeftKey("companyId").MapRightKey("productId"));

            modelBuilder.Entity<tbl_CONFIG_ConfigurationData>()
                .Property(e => e.DataKey)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_ConfigurationData>()
                .Property(e => e.DataValue)
                .IsUnicode(false);

            //modelBuilder.Entity<tbl_CONFIG_ConfigurationData_SqLite>()
            //    .Property(e => e.DataKey)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_CONFIG_ConfigurationData_SqLite>()
            //    .Property(e => e.DataValue)
            //    .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_ConfirmationOfPersonalDetailsOptions>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Countries>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Currencies>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Dashboards>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Dashboards>()
                .HasMany(e => e.tbl_CONFIG_Dashboards_Applications)
                .WithRequired(e => e.tbl_CONFIG_Dashboards)
                .HasForeignKey(e => e.dashboardId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Dashboards>()
                .HasMany(e => e.tbl_CONFIG_Dashboards_Widgets)
                .WithRequired(e => e.tbl_CONFIG_Dashboards)
                .HasForeignKey(e => e.dashboardId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Dashboards>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tbl_CONFIG_Dashboards)
                .HasForeignKey(e => e.dashboardId);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr0000)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr0600)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr0900)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr1300)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr1600)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.moFr1900)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.saSo0000)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.saSo0600)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.saSo1300)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.saSo1900)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.gewichtungKgZuSq)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.kontrolStart)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_DispoStats>()
                .HasMany(e => e.tbl_CONFIG_Profiles)
                .WithMany(e => e.tbl_CONFIG_DispoStats)
                .Map(m => m.ToTable("tbl_CONFIG_DispoStats_AccessProfiles").MapLeftKey("DispoStats_Id").MapRightKey("AccessProfile_Id"));

            modelBuilder.Entity<tbl_CONFIG_Firstnames>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_LastNames>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_OthersCategories>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_EmailTexts>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Parameters>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Parameters>()
                .HasMany(e => e.tbl_CONFIG_Applications_Parameters_Values)
                .WithRequired(e => e.tbl_CONFIG_Parameters)
                .HasForeignKey(e => e.parameterId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Parameters>()
                .HasMany(e => e.tbl_CONFIG_Widgets_Parameters_Values)
                .WithRequired(e => e.tbl_CONFIG_Parameters)
                .HasForeignKey(e => e.parameterId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tblUsers_Profiles)

                .WithRequired(e => e.tbl_CONFIG_Profiles)
                .HasForeignKey(e => e.profileId)

                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tbl_DISPO_LineStats)
                .WithMany(e => e.tbl_CONFIG_Profiles)
                .Map(m => m.ToTable("tbl_DISPO_Profile2Line").MapLeftKey("Profile_Id").MapRightKey("LineStats_Id"));

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tbl_DISPO_LineStats_Temp)

                .WithMany(e => e.tbl_CONFIG_Profiles)
                .Map(m => m.ToTable("tbl_DISPO_Profile2Line_Temp").MapLeftKey("Profile_Id").MapRightKey("LineStats_Id"));

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tbl_DOCBOX_Documents)
                .WithMany(e => e.tbl_CONFIG_Profiles)
                .Map(m => m.ToTable("tbl_DOCBOX_DocumentsProfiles").MapLeftKey("profileId").MapRightKey("documentId"));

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tbl_DOCBOX_Folders)
                .WithMany(e => e.tbl_CONFIG_Profiles)
                .Map(m => m.ToTable("tbl_DOCBOX_FoldersProfile").MapLeftKey("profileId").MapRightKey("folderId"));

            modelBuilder.Entity<tbl_CONFIG_Profiles>()
                .HasMany(e => e.tblContacts)
                .WithMany(e => e.tbl_CONFIG_Profiles)
                .Map(m => m.ToTable("tblUsers_AccessProfiles").MapLeftKey("profileId").MapRightKey("userId"));

            modelBuilder.Entity<tbl_CONFIG_ReasonsCategories>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_ReasonsSubcategories>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_ReasonsCategories>()
                .HasMany<tbl_CONFIG_Companies>(g => g.tbl_CONFIG_Companies_TicketControl)
                .WithMany(g => g.tbl_CONFIG_ReasonsCategories_TicketControl)
                .Map(cs =>
                {
                    cs.MapLeftKey("reasonCategoryId");
                    cs.MapRightKey("companyId");
                    cs.ToTable("tbl_CONFIG_ReasonsCategories_TicketControl_Companies");
                });
            modelBuilder.Entity<tbl_CONFIG_ReasonsCategories>()
                .HasMany<tbl_CONFIG_Companies>(g => g.tbl_CONFIG_Companies_ExternerTU)
                .WithMany(g => g.tbl_CONFIG_ReasonsCategories_ExternerTU)
                .Map(cs =>
                {
                    cs.MapLeftKey("reasonCategoryId");
                    cs.MapRightKey("companyId");
                    cs.ToTable("tbl_CONFIG_ReasonsCategories_ExternerTU_Companies");
                });

            modelBuilder.Entity<tbl_DOCBOX_Folders>()
                .HasMany<tbl_CONFIG_Companies>(s => s.tbl_CONFIG_Companies_Write)
                .WithMany(c => c.tbl_DOCBOX_FoldersWrite)
                .Map(cs =>
                {
                    cs.MapLeftKey("folderId");
                    cs.MapRightKey("companyId");
                    cs.ToTable("tbl_DOCBOX_FolderWriteProfiles");
                });

            modelBuilder.Entity<tbl_CONFIG_AbuseOptions>()
            .HasMany<tbl_CONFIG_ReasonsSubcategories>(g => g.tbl_CONFIG_ReasonsSubcategories)
            .WithOptional(s => s.tbl_CONFIG_AbuseOptions)
            .HasForeignKey<int?>(s => s.abuseOptionId);


            modelBuilder.Entity<tbl_CONFIG_RefundReasons>()
                .Property(e => e.text_de)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_RefundReasons>()
                .Property(e => e.text_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_RefundReasons>()
                .Property(e => e.text_it)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_RefundReasons>()
                .Property(e => e.langRef)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CONFIG_RefundReasons>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Regions>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Regions>()
                .HasMany(e => e.tbl_FORMS_Surveys)
                .WithRequired(e => e.tbl_CONFIG_Regions)
                .HasForeignKey(e => e.regionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Routes>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Routes>()
                .HasMany(e => e.tbl_CONFIG_Stations)
                .WithMany(e => e.tbl_CONFIG_Routes)
                .Map(m => m.ToTable("tbl_CONFIG_Routes_Stations").MapLeftKey("routeId").MapRightKey("stationId"));

            modelBuilder.Entity<tbl_CONFIG_Stations>()
                .Property(e => e.straaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_CONFIG_Stations>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Themes>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Themes>()
                .HasMany(e => e.tbl_CONFIG_Dashboards)
                .WithOptional(e => e.tbl_CONFIG_Themes)
                .HasForeignKey(e => e.themeId);

            modelBuilder.Entity<tbl_CONFIG_TrafficTypes>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_TrafficTypes>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_TrafficTypes>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_TrafficTypes>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithOptional(e => e.tbl_CONFIG_TrafficTypes)
                .HasForeignKey(e => e.trafficTypeId);

            modelBuilder.Entity<tbl_CONFIG_Widgets>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_CONFIG_Widgets>()
                .HasMany(e => e.tbl_CONFIG_Dashboards_Widgets)
                .WithRequired(e => e.tbl_CONFIG_Widgets)
                .HasForeignKey(e => e.widgetId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_Widgets>()
                .HasMany(e => e.tbl_CONFIG_Widgets_Parameters_Values)
                .WithRequired(e => e.tbl_CONFIG_Widgets)
                .HasForeignKey(e => e.widgetId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_CONFIG_ZipAddressCity>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DEBUG_Queries>()
                .Property(e => e.query)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEBUG_RequestTimeCheck>()
                .Property(e => e.startTime)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DEBUG_RequestTimeCheck>()
                .Property(e => e.endTime)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.tag)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.timestamp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.response)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.deviceid)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.imei)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.file)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.versionnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.datetime)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.mode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.request)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.incidentid)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.starttime)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.log)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.error)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.taskid)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.data)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.turnid)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.stoptime)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.json)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.tasktype)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.exception)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.updateblacklist)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_DeviceLogs>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DEVICE_LOGS_IncidentLogs>()
                .Property(e => e.timestamp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_DISPO_LineStats>()
                .Property(e => e.ControlStartDate)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DISPO_LineStats>()
                .HasMany(e => e.tbl_DISPO_TU2Line)
                .WithRequired(e => e.tbl_DISPO_LineStats)
                .HasForeignKey(e => e.Line_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_DISPO_LineStats_Temp>()
                .Property(e => e.ControlStartDate)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DISPO_LineStats_Temp>()
                .HasMany(e => e.tbl_DISPO_TU2Line_Temp)
                .WithRequired(e => e.tbl_DISPO_LineStats_Temp)
                .HasForeignKey(e => e.Line_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .Property(e => e.validFrom)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .Property(e => e.validTo)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .Property(e => e.dateCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .Property(e => e.dateModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .Property(e => e.dateDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Documents>()
                .HasMany(e => e.tbl_DOCBOX_DocumentsUsersRead)
                .WithRequired(e => e.tbl_DOCBOX_Documents)
                .HasForeignKey(e => e.documentId)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tbl_DOCBOX_Documents>()
            //    .HasMany(e => e.tbl_DOCBOX_Tags)
            //    .WithMany(e => e.tbl_DOCBOX_Documents)
            //    .Map(m => m.ToTable("tbl_DOCBOX_DocumentsTags").MapLeftKey("documentId").MapRightKey("tagId"));

            modelBuilder.Entity<tbl_DOCBOX_DocumentsUsersRead>()
                .Property(e => e.versionDate)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_DocumentsUsersRead>()
                .Property(e => e.readDate)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Folders>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_DOCBOX_Folders>()
                .HasMany(e => e.tbl_DOCBOX_Documents)
                .WithOptional(e => e.tbl_DOCBOX_Folders)
                .HasForeignKey(e => e.folderID);

            modelBuilder.Entity<tbl_DOCBOX_Folders>()
                .HasMany(e => e.tbl_DOCBOX_FoldersChildren)
                .WithOptional(e => e.tbl_DOCBOX_FolderParent)
                .HasForeignKey(e => e.parentId);

            //modelBuilder.Entity<tbl_DOCBOX_Tags>()
            //    .Property(e => e.dtDeleted)
            //    .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Answers>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Answers>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Answers>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .Property(e => e.minValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .Property(e => e.maxValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Questions>()
                .HasMany(e => e.tbl_FORMS_Answers)
                .WithRequired(e => e.tbl_FORMS_Questions)
                .HasForeignKey(e => e.questionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_Sections>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Sections>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Sections>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Sections>()
                .HasMany(e => e.tbl_FORMS_SurveyTemplates_Sections)
                .WithRequired(e => e.tbl_FORMS_Sections)
                .HasForeignKey(e => e.sectionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtClosed)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtUploaded)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtExported)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .Property(e => e.dtBalanced)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_Surveys>()
                .HasMany(e => e.tbl_FORMS_Answers)
                .WithRequired(e => e.tbl_FORMS_Surveys)
                .HasForeignKey(e => e.surveyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .HasMany(e => e.tbl_FORMS_Surveys)
                .WithRequired(e => e.tbl_FORMS_SurveyTemplates)
                .HasForeignKey(e => e.templateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .HasMany(e => e.tbl_FORMS_SurveyTemplates_Companies)
                .WithRequired(e => e.tbl_FORMS_SurveyTemplates)
                .HasForeignKey(e => e.templateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates>()
                .HasMany(e => e.tbl_FORMS_SurveyTemplates_Sections)
                .WithRequired(e => e.tbl_FORMS_SurveyTemplates)
                .HasForeignKey(e => e.surveyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates_Companies>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates_Companies>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates_Sections>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates_Sections>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_FORMS_SurveyTemplates_Sections>()
                .HasMany(e => e.tbl_FORMS_Questions)
                .WithRequired(e => e.tbl_FORMS_SurveyTemplates_Sections)
                .HasForeignKey(e => e.surveySectionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_STATISTICS_Logins>()
                .Property(e => e.latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tbl_STATISTICS_Logins>()
                .Property(e => e.longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tbl_STATISTICS_Logins>()
                .Property(e => e.imei)
                .IsFixedLength();

            modelBuilder.Entity<tbl_STATISTICS_Logins>()
                .Property(e => e.mac)
                .IsFixedLength();

            modelBuilder.Entity<tbl_STATISTICS_Uploads>()
                .Property(e => e.imei)
                .IsFixedLength();

            modelBuilder.Entity<tbl_STATISTICS_Uploads>()
                .Property(e => e.mac)
                .IsFixedLength();

            modelBuilder.Entity<tbl_TICKETING_Categories>()
                .HasMany(e => e.tbl_TICKETING_Products)
                .WithRequired(e => e.tbl_TICKETING_Categories)
                .HasForeignKey(e => e.categoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Categories>()
                .HasMany(e => e.tbl_TICKETING_Tickets)
                .WithRequired(e => e.tbl_TICKETING_Categories)
                .HasForeignKey(e => e.categoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Classes>()
                .HasMany(e => e.tbl_TICKETING_ProductPrices)
                .WithRequired(e => e.tbl_TICKETING_Classes)
                .HasForeignKey(e => e.idClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Products>()
                .HasMany(e => e.tbl_TICKETING_ProductPrices)
                .WithRequired(e => e.tbl_TICKETING_Products)
                .HasForeignKey(e => e.idProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Products>()
                .HasMany(e => e.tbl_TICKETING_Tickets)
                .WithRequired(e => e.tbl_TICKETING_Products)
                .HasForeignKey(e => e.productID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.timeStamp)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.uploaded)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.exported)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.balanced)
                .HasPrecision(3);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .Property(e => e.longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .HasMany(e => e.tbl_TICKETING_TicketsLines)
                .WithRequired(e => e.tbl_TICKETING_Tickets)
                .HasForeignKey(e => e.ticketID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_Tickets>()
                .HasMany(e => e.tbl_TICKETING_TicketsImages)
                .WithRequired(e => e.tbl_TICKETING_Tickets)
                .HasForeignKey(e => e.ticketID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_TICKETING_TicketsLines>()
                .Property(e => e.price)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tbl_TICKETING_TicketsLines>()
                .Property(e => e.quittungJSON)
                .IsUnicode(false);

            modelBuilder.Entity<tblAudit>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<tblAudit>()
                .Property(e => e.method)
                .IsUnicode(false);

            modelBuilder.Entity<tblAudit>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<tblAudit>()
                .Property(e => e.sqliteVersion)
                .IsUnicode(false);

            modelBuilder.Entity<tblAudit>()
                .Property(e => e.freeField1)
                .IsUnicode(false);

            modelBuilder.Entity<tblBalanceHistory>()
                .Property(e => e.balanceDay)
                .HasPrecision(3);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.surcharge)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.fare)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.fee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.abuse)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.forgery)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.time_penalties)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.miscellaneus)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBill>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.vorname)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.comments_de)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.comments_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.comments_it)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklist>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlackListFile>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlackListFile>()
                .Property(e => e.sftpHost)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlackListFile>()
                .Property(e => e.sftpUser)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlackListFile>()
                .Property(e => e.sftpPwd)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlackListFile>()
                .HasMany(e => e.tbl_CONFIG_Companies)
                .WithMany(e => e.tblBlackListFiles)
                .Map(m => m.ToTable("tblBlackListFilesCompanies").MapLeftKey("FileId").MapRightKey("CompanyId"));

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.text_it)
                .IsUnicode(false);

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.text_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.companyId)
                .IsUnicode(false);

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.dtModified)
                .HasPrecision(3);

            modelBuilder.Entity<tblCardType>()
                .Property(e => e.dtCreated)
                .HasPrecision(3);

            modelBuilder.Entity<tblCashCheckHistory>()
                .Property(e => e.cashCheckDay)
                .HasPrecision(3);

            modelBuilder.Entity<tblCompany>()
                .HasMany(e => e.tblCompanies_Regions)
                .WithRequired(e => e.tblCompany)
                .HasForeignKey(e => e.company)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tblCompany>()
            //    .HasMany(e => e.tblCompaniesTeams)
            //    .WithOptional(e => e.tblCompany)
            //    .HasForeignKey(e => e.companyId);

            //modelBuilder.Entity<tblCompany>()
            //    .HasMany(e => e.tblTeams)
            //    .WithOptional(e => e.tblCompany)
            //    .HasForeignKey(e => e.company);

            modelBuilder.Entity<tblCompany>()
                .HasMany(e => e.tblEmployers)
                .WithOptional(e => e.tblCompany)
                .HasForeignKey(e => e.companyId);

            modelBuilder.Entity<tblConfigurationData>()
                .Property(e => e.DataKey)
                .IsUnicode(false);

            modelBuilder.Entity<tblConfigurationData>()
                .Property(e => e.DataValue)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tblContact)
                .HasForeignKey(e => e.contactId);

            modelBuilder.Entity<tblControlBase>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tblControlBase>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tblControlBas)
                .HasForeignKey(e => e.controlBase);

            modelBuilder.Entity<tblDeltavistaLog>()
                .Property(e => e.error_message)
                .IsUnicode(false);

            modelBuilder.Entity<tblDeltavistaLog>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<tblDeltavistaLog>()
                .Property(e => e.incident)
                .IsUnicode(false);

            modelBuilder.Entity<tblDeviceContact>()
            .HasMany<tbl_CONFIG_Companies>(c => c.tbl_CONFIG_Companies)
            .WithMany(s => s.tblDeviceContact)
            .Map(cs =>
            {
                cs.MapLeftKey("deviceContactId");
                cs.MapRightKey("companyId");
                cs.ToTable("tblDeviceContact_Companies");
            });


            modelBuilder.Entity<tblEmployer>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tblEmployer)
                .HasForeignKey(e => e.employer);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.domain)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.task)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.task_test)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.incident)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.incident_test)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.picture_test)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.ticketsales)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.ticketsales_test)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.forms)
                .IsUnicode(false);

            modelBuilder.Entity<tblExportConfiguration>()
                .Property(e => e.forms_test)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.citzenship)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorName)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorZip)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorCitizenship)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorCity)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorCountry)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.tutorExtra)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.remaining)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.deduction)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.cash)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<tblHistoricalIncident>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblHistoricalIncident>()
                .HasMany(e => e.tblBillLines)
                .WithOptional(e => e.tblHistoricalIncident)
                .HasForeignKey(e => e.historicalIncidentId);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.kontrolldatum)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.geburtsdatumFahrgast)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.kreditkartenzahlung)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.grundgebühr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.fahrpreispauschale)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.bearbeitungssgebuhr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.missbrauchsgebuhr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.falschungsgebühr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.zeitzuschlagsgebuhr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.diverseGebuhren)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.ruckgeldInCHF)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.exportTime)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.exportedToCsv)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.companyCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblIncidentExportReport>()
                .Property(e => e.controlTimeStamp)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncidentImage>()
                .Property(e => e.imageContent)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.birthdate)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.citzenship)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorName)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorZip)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorBirthdate)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorCitizenship)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorCity)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorCountry)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.tutorExtra)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.startTime)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.modified)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.exportedToSAP)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.uploadedDate)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.alreadySentSMS)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.sentMailOK)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.closedDate)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.lastModificationDate)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblIncident>()
                .Property(e => e.controlTimeStamp)
                .HasPrecision(3);

            modelBuilder.Entity<tblIncident>()
                .HasMany(e => e.tblBillLines)
                .WithOptional(e => e.tblIncident)
                .HasForeignKey(e => e.incidentId);

            modelBuilder.Entity<tblIncident>()
                .HasMany(e => e.tblIncidentImages)
                .WithOptional(e => e.tblIncident)
                .HasForeignKey(e => e.incident);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .Property(e => e.shortName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblLanguage>()
                .HasMany(e => e.tbl_DOCBOX_Documents)
                .WithOptional(e => e.tblLanguage)
                .HasForeignKey(e => e.langID);

            modelBuilder.Entity<tblLanguage>()
                .HasMany(e => e.tblUsers)
                .WithOptional(e => e.tblLanguage)
                .HasForeignKey(e => e.language);

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<tblRegion>()
                .HasMany(e => e.tblCompanies)
                .WithOptional(e => e.tblRegion)
                .HasForeignKey(e => e.region);

            modelBuilder.Entity<tblRegion>()
                .HasMany(e => e.tblCompanies_Regions)
                .WithRequired(e => e.tblRegion)
                .HasForeignKey(e => e.region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaskExportReport>()
                .Property(e => e.dateTimeFrom)
                .HasPrecision(3);

            modelBuilder.Entity<tblTaskExportReport>()
                .Property(e => e.dateTimeTo)
                .HasPrecision(3);

            modelBuilder.Entity<tblTaskExportReport>()
                .Property(e => e.exportTime)
                .HasPrecision(3);

            modelBuilder.Entity<tblTaskExportReport>()
                .Property(e => e.exportedToCsv)
                .HasPrecision(3);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblTask>()
                .HasMany(e => e.tblTaskTypes)
                .WithOptional(e => e.tblTask)
                .HasForeignKey(e => e.taskId);

            modelBuilder.Entity<tblTaskType>()
                .HasMany(e => e.tblTaskType1)
                .WithOptional(e => e.tblTaskType)
                .HasForeignKey(e => e.taskTypeId);

            modelBuilder.Entity<tblTaskType>()
                .HasMany(e => e.tblTaskType3)
                .WithOptional(e => e.tblTaskType)
                .HasForeignKey(e => e.taskTypeId);

            //modelBuilder.Entity<tblTeam>()
            //    .HasMany(e => e.tblCompaniesTeams)
            //    .WithOptional(e => e.tblTeam)
            //    .HasForeignKey(e => e.teamId);

            modelBuilder.Entity<tblTurn>()
                .Property(e => e.latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblTurn>()
                .Property(e => e.longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<tblTurn>()
                .HasMany(e => e.tblTasks)
                .WithOptional(e => e.tblTurn)
                .HasForeignKey(e => e.turnId);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tbl_DOCBOX_DocumentsUsersRead)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUsers_Companies)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasOptional(e => e.tblUsers_Favorites)
                .WithRequired(e => e.tblUser);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUsers_Profiles)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .HasMany<tbl_CONFIG_Companies>(u => u.tblCMSCompanies)
                .WithMany(c => c.tblCMSUsers)
                .Map(cs =>
                {
                    cs.MapLeftKey("userId");
                    cs.MapRightKey("companyId");
                    cs.ToTable("tblCMSUser_Companies");
                });

            modelBuilder.Entity<tbl_MONITOR_CMSUserRequest>()
                .HasRequired(r => r.user)
                .WithMany(u => u.requestUsers)
                .HasForeignKey(r => r.userId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_MONITOR_CMSUserRequest>()
                .HasOptional(r => r.validationUser)
                .WithMany(u => u.validationUsers)
                .HasForeignKey(r => r.validationUserId)
                .WillCascadeOnDelete(false);



            modelBuilder.Entity<tblUsers_Favorites>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<exportedIncident>()
                .Property(e => e.exportedToSAP)
                .HasPrecision(3);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.vorname)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.comments_de)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.comments_fr)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.comments_it)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbl_Blacklist_Short>()
            //    .Property(e => e.comments)
            //    .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.vorname)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.comments_de)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.comments_fr)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.comments_it)
                .IsUnicode(false);

            modelBuilder.Entity<tblBlacklistStaging>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<vw_balanceHistory>()
                .Property(e => e.balanceDay)
                .HasPrecision(3);

            modelBuilder.Entity<vw_cashCheckHistory>()
                .Property(e => e.cashCheckDay)
                .HasPrecision(3);

            modelBuilder.Entity<vw_CONFIG_otherCategories>()
                .Property(e => e.langRef)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CONFIG_otherCategories>()
                .Property(e => e.dtDeleted)
                .HasPrecision(3);

            modelBuilder.Entity<vw_deltavista>()
                .Property(e => e.error_message)
                .IsUnicode(false);

            modelBuilder.Entity<vw_deltavista>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<vw_deltavista>()
                .Property(e => e.incident)
                .IsUnicode(false);

            modelBuilder.Entity<vw_dispoStats>()
                .Property(e => e.ControlStartDate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.STARTDATE)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.birthdate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.citzenship)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorAddress)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorZip)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorBirthdate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorCitizenship)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorCity)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorCountry)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.tutorExtra)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.startTime)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.modified)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.exportedToSAP)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.uploadedDate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.alreadySentSMS)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.alreadySentEmail)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidents>()
                .Property(e => e.closedDate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.startTime)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.birthdate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorName)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorCity)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorAddress)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorZip)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.tutorExtra)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.refundReasonDe)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.refundReasonFr)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.refundReasonIt)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.citzenship)
                .IsUnicode(false);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.straaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.exportedToSAP)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<vw_incidentsView>()
                .Property(e => e.closedDate)
                .HasPrecision(3);

            modelBuilder.Entity<vw_lastSynchronization>()
                .Property(e => e.imei)
                .IsFixedLength();

            modelBuilder.Entity<vw_lastSynchronization>()
                .Property(e => e.mac)
                .IsFixedLength();

            modelBuilder.Entity<vw_LastUploads>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<vw_login_statistics>()
                .Property(e => e.imei)
                .IsFixedLength();

            modelBuilder.Entity<vw_login_statistics>()
                .Property(e => e.mac)
                .IsFixedLength();

            modelBuilder.Entity<vw_sold_tickets>()
                .Property(e => e.timeStamp)
                .HasPrecision(3);

            modelBuilder.Entity<vw_sold_tickets>()
                .Property(e => e.uploaded)
                .HasPrecision(3);

            modelBuilder.Entity<vw_sold_tickets>()
                .Property(e => e.exported)
                .HasPrecision(3);

            modelBuilder.Entity<vw_sold_tickets>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<vw_sold_tickets>()
                .Property(e => e.balanced)
                .HasPrecision(3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.timeStamp)
                .HasPrecision(3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.class1Type0Price)
                .HasPrecision(38, 3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.class1Type1Price)
                .HasPrecision(38, 3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.class2Type0Price)
                .HasPrecision(38, 3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.class2Type1Price)
                .HasPrecision(38, 3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.amount)
                .HasPrecision(38, 3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.deleted)
                .HasPrecision(3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.uploaded)
                .HasPrecision(3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.exported)
                .HasPrecision(3);

            modelBuilder.Entity<vw_ticketsView>()
                .Property(e => e.balanced)
                .HasPrecision(3);

        }
    }
}
