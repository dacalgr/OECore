# Database Documentation

## Overview
This document describes the database structure for the OECore application, which has been migrated from Entity Framework 6 to Entity Framework Core 9.

## Current Status
- **Total Tables**: 82
- **Current Migration**: `20250829112946_AddDocboxSystem`
- **Database Engine**: PostgreSQL
- **EF Core Version**: 9.0

## Systems Overview

### 1. Core Identity System (6 tables)
- **User Management**: `user`, `profile`, `user_company`
- **Organization**: `company`, `region`, `company_region`
- **Features**: Multi-company support, role-based access, soft delete

### 2. Configuration System (28 tables)
- **Basic Config**: `tbl_CONFIG_Countries`, `tbl_CONFIG_Currencies`, `tbl_CONFIG_Languages`
- **User Data**: `tbl_CONFIG_Firstnames`, `tbl_CONFIG_LastNames`, `tbl_CONFIG_ZipAddressCity`
- **Business Logic**: `tbl_CONFIG_Behaviours`, `tbl_CONFIG_CommentsTemplates`, `tbl_CONFIG_ControlTypes`
- **Abuse Management**: `tbl_CONFIG_AbuseOptions`, `tbl_CONFIG_ConfirmationOfPersonalDetailsOptions`, `tbl_CONFIG_ContactPersonOptions`
- **Reasons & Categories**: `tbl_CONFIG_ReasonsCategories`, `tbl_CONFIG_ReasonsSubcategories`, `tbl_CONFIG_RefundReasons`
- **Transport**: `tbl_CONFIG_Stations`, `tbl_CONFIG_Routes`, `tbl_CONFIG_StationsRoutes`, `tbl_CONFIG_TrafficTypes`
- **UI/UX**: `tbl_CONFIG_Themes`, `tbl_CONFIG_Dashboards`, `tbl_CONFIG_Widgets`
- **System**: `tbl_CONFIG_Applications`, `tbl_CONFIG_Parameters`, `tbl_CONFIG_Log`, `tbl_CONFIG_TableMapping`
- **Cleanup**: `tbl_CONFIG_CleanJobsConfiguration`
- **Email**: `tbl_CONFIG_EmailTexts`, `tbl_CONFIG_EmailTexts_Destinations`
- **Others**: `tbl_CONFIG_OthersCategories`

### 3. TIMETABLE System (7 tables)
- **GTFS Standard**: `tbl_TIMETABLE_agency`, `tbl_TIMETABLE_calendar`, `tbl_TIMETABLE_calendar_dates`
- **Routes & Stops**: `tbl_TIMETABLE_routes`, `tbl_TIMETABLE_stops`, `tbl_TIMETABLE_stop_times`
- **Trips**: `tbl_TIMETABLE_trips`
- **Features**: GTFS compliance, calendar management, stop times

### 4. Statistics & Logs System (7 tables)
- **User Activity**: `tbl_STATISTICS_Logins`, `tbl_STATISTICS_Uploads`
- **Device Data**: `tbl_STATISTICS_devicesData`
- **Debug**: `tbl_DEBUG_Queries`, `tbl_DEBUG_RequestTimeCheck`
- **Device Logs**: `tbl_DEVICE_LOGS_DeviceLogs`, `tbl_DEVICE_LOGS_IncidentLogs`
- **Features**: Performance monitoring, device tracking, debug logging

### 5. TICKETING System (7 tables)
- **Products**: `tbl_TICKETING_Categories`, `tbl_TICKETING_Classes`, `tbl_TICKETING_Products`, `tbl_TICKETING_ProductPrices`
- **Tickets**: `tbl_TICKETING_Tickets`, `tbl_TICKETING_TicketsLines`, `tbl_TICKETING_TicketsImages`
- **Features**: Product catalog, pricing, ticket management, image storage

### 6. NOVA System (3 tables)
- **Tickets**: `tbl_NOVA_Tickets`
- **Products**: `tbl_NOVA_ProductData`
- **Company Relations**: `tbl_CONFIG_Companies_NOVA_ProductData`
- **Features**: Multilingual support, geolocation, payment processing

### 7. INCIDENTS System (9 tables)
- **Core Incident**: `tblIncident` - Main incident entity with passenger/tutor data, payments, geolocation
- **Images**: `tblIncidentImage` - Image storage for incidents and receipts
- **Export**: `tblIncidentExportReport` - Export data for external systems (SAP, CSV)
- **Audit**: `tblIncidentsLog` - Audit logging for incident changes
- **Tasks**: `tblTask` - Task management for control operations
- **Turns**: `tblTurn` - Work shift management
- **Task Types**: `tblTaskType`, `tblTaskType1`, `tblTaskType3` - Task categorization
- **Features**: Complete incident lifecycle, abuse detection, payment processing, geolocation, export functionality

### 8. FORMS System (7 tables)
- **Templates**: `tbl_FORMS_SurveyTemplates` - Reusable survey templates
- **Surveys**: `tbl_FORMS_Surveys` - Survey instances completed by users
- **Sections**: `tbl_FORMS_Sections` - Form organization and structure
- **Questions**: `tbl_FORMS_Questions` - Question definitions with types and validations
- **Answers**: `tbl_FORMS_Answers` - User responses to questions
- **Relations**: `tbl_FORMS_SurveyTemplates_Companies`, `tbl_FORMS_SurveyTemplates_Sections` - Template associations
- **Features**: Multi-tenant surveys, question types (text, numeric, dropdown), validations, audit logging

### 9. DOCBOX System (4 tables) ⭐ **NEW**
- **Documents**: `tbl_DOCBOX_Documents` - Document management with metadata and access control
- **Folders**: `tbl_DOCBOX_Folders` - Hierarchical folder organization
- **User Reads**: `tbl_DOCBOX_DocumentsUsersRead` - Document reading tracking by users
- **Favorites**: `tbl_DOCBOX_Favorites` - User favorite documents
- **Features**: Multi-tenant document storage, hierarchical organization, access control, offline sync, multilingual support

## Key Features

### Multilingual Support
- **Languages**: German, French, Italian, English
- **Fields**: `name_de`, `name_fr`, `name_it`, `nameEN`, `nameDE`, `nameFR`, `nameIT`
- **Systems**: Configuration, NOVA, INCIDENTS

### Soft Delete
- **Pattern**: `dtDeleted` or `deleted` fields
- **Systems**: All major systems implement soft delete
- **Benefits**: Data preservation, audit trail

### UUID Keys
- **Usage**: Primary keys for main entities
- **Systems**: User, Company, Incident, Task, Turn
- **Benefits**: Distributed systems, security

### Geolocation
- **Fields**: `latitude`, `longitude` (decimal/numeric)
- **Systems**: INCIDENTS, NOVA, Tasks, Turns
- **Features**: GPS tracking, location-based services

### Payment Processing
- **Fields**: `total`, `cash`, `deduction`, `currency`, `paymentMode`
- **Systems**: INCIDENTS, TICKETING, NOVA
- **Features**: Multiple payment methods, online transactions

### Audit & Logging
- **Tables**: `tblIncidentsLog`, `tbl_CONFIG_Log`, `tbl_DEVICE_LOGS_*`
- **Features**: Change tracking, operation logging, device monitoring

## Migration History

### Phase 1: Core Identity (20250819124105)
- User, Profile, Company, Region entities
- Basic organizational structure

### Phase 2: Configuration (20250828155628)
- Complete configuration system
- 28 tables for system configuration

### Phase 3: TIMETABLE (20250828155628)
- GTFS-compliant timetable system
- 7 tables for public transport data

### Phase 4: Statistics & Logs (20250828155628)
- Monitoring and logging system
- 7 tables for analytics and debugging

### Phase 5: TICKETING (20250829065609)
- Complete ticketing system
- 7 tables for product and ticket management

### Phase 6: NOVA (20250829081553)
- NOVA system integration
- 3 tables with multilingual support

### Phase 7: INCIDENTS (20250829095806)
- Complete incident management system
- 9 tables for incident lifecycle management

### Phase 8: FORMS (20250829104823)
- Complete form and survey management system
- 7 tables for survey templates, questions, and responses

### Phase 9: DOCBOX (20250829112946) ⭐ **NEW**
- Complete document management and storage system
- 4 tables for documents, folders, user reads, and favorites

## Database Schema

### Naming Conventions
- **Tables**: `tbl_*` prefix for legacy compatibility
- **Columns**: camelCase with original names preserved
- **Relationships**: Foreign keys follow EF Core conventions

### Data Types
- **Timestamps**: `timestamp` (PostgreSQL)
- **Decimals**: `numeric` for financial data
- **UUIDs**: `uuid` for primary keys
- **Text**: `text` for large content, `character varying(n)` for limited strings

### Indexes
- **Primary Keys**: Automatic indexes
- **Foreign Keys**: Automatic indexes
- **Performance**: Additional indexes on frequently queried fields

## Next Steps
- **API Development**: REST endpoints for all systems
- **Performance Optimization**: Query optimization and indexing


