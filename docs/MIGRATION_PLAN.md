## Migration Plan (OldContext → EF Core + PostgreSQL)

This plan prioritizes the first entities to migrate from the legacy EF6 context.

### Phase 1 — Identity & Organization (foundational)
- Users: `tblUser`
- Profiles: `tblUsers_Profiles`, `tbl_CONFIG_Profiles`
- Companies: `tblCompany`, `tblCompanies_Regions`, `tblCompanyMapping`
- User-company linking: `tblUsers_Companies`

Rationale: Enables authentication/authorization and scoping of data by company/region from day one.

### Phase 2 — Minimal Configuration (only what app needs early)
- Applications & settings: `tbl_CONFIG_Applications`, `tbl_CONFIG_Applications_Parameters_Values`
- Parameters: `tbl_CONFIG_Parameters`
- Taxonomy basics (optional early): `tbl_CONFIG_Countries`, `tbl_CONFIG_Currencies`

Rationale: Keep config surface minimal to avoid over-migration. Expand as features require.

### Phase 3 — Ticketing Core
- Catalog: `tbl_TICKETING_Products`, `tbl_TICKETING_Classes`, `tbl_TICKETING_Categories`, `tbl_TICKETING_ProductPrices`
- Sales: `tbl_TICKETING_Tickets`, `tbl_TICKETING_TicketsLines`, `tbl_TICKETING_TicketsImages`
- Views (read-only): `vw_ticketsView`, `vw_ticketingProductPrices`, `vw_sold_tickets`, `vw_sold_NOVATickets`

Rationale: Core business flows for products and tickets.

### Phase 4 — Monitoring & Statistics (defer until needed)
- Monitoring: `tbl_MONITOR_Data`, `tbl_MONITOR_UserConfiguration`, `tbl_MONITOR_RoleConfiguration`, `tbl_MONITOR_CMSUserRequest`, `tbl_MONITOR_InactiveUserData`, `tbl_MONITOR_WorldlineStornoTask`
- Stats: `tbl_STATISTICS_Logins`, `tbl_STATISTICS_Uploads`, `tbl_STATISTICS_devicesData`

Rationale: Useful for observability but not critical to unblock core features.

### Phase 5 — Forms & Document Box (feature-driven)
- Forms: `tbl_FORMS_Surveys`, `tbl_FORMS_Questions`, `tbl_FORMS_Answers`, `tbl_FORMS_Sections`, `tbl_FORMS_SurveyTemplates`, `tbl_FORMS_SurveyTemplates_Sections`, `tbl_FORMS_SurveyTemplates_Companies`
- Documents: `tbl_DOCBOX_Documents`, `tbl_DOCBOX_Folders`, `tbl_DOCBOX_Favorites`, `tbl_DOCBOX_DocumentsUsersRead`
- Related views: `vw_billLinesView`, `vw_cashCheckHistory`, `vw_LastUploads`, etc.

Rationale: Larger surface area; migrate when the related features are in scope.

### Phase 6 — DISPO/GTFS/Timetable & Others (as required)
- DISPO: `tbl_DISPO_LineStats`, `tbl_DISPO_LineStats_Temp`, `tbl_DISPO_TU2Line`, `tbl_DISPO_TU2Line_Temp`
- Timetable/GTFS: `tbl_TIMETABLE_*`
- LITE/Regions: `tbl_LITE_Regions`

Rationale: Specialized domains; bring over when needed by features.

### Exclusions / Defer
- Backups & staging: `tbl_BACKUP_*`, `tblBlacklistStaging`
- Debug helpers: `tbl_DEBUG_*`
- Legacy or SQL Server–specific patterns that don’t translate well: review case-by-case

### EF Core + PostgreSQL Mapping Guidelines
- Use Fluent API and `UseSnakeCaseNamingConvention()` for snake_case in PostgreSQL
- Keys: prefer bigint identities or UUIDs; rename PK to `id` where feasible
- Timestamps: `created_at`, `updated_at` (UTC); optional `deleted_at` for soft delete
- Types: map SQL Server `datetime` → `timestamptz`, `money` → `numeric(18,2)`
- Views: map as read-only with `.ToView("vw_name")`; no primary keys
- Large text/blobs: use `text`/`bytea`

### Next Steps
- Confirm Phase 1 entities and fields to include
- I’ll model EF Core entities and configurations in `Infrastructure`, add `DbSet<>`s to `AppDbContext`, and create the initial migration


