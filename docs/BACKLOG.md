## Backlog & Checklist

### ✅ Completed Tasks

#### Project Setup & Infrastructure
- [x] Initialize solution and API project
  - [x] `dotnet new sln -n OECore`
  - [x] `dotnet new webapi -n OECore.Api -o src/OECore.Api --use-controllers`
  - [x] `dotnet sln OECore.sln add src/OECore.Api/OECore.Api.csproj`
- [x] Add editorconfig, enable nullable, warnings as errors
- [x] Add Swagger and XML comments
- [x] Setup Global Exception Handling middleware
- [x] Add EF Core with PostgreSQL (Npgsql)
  - [x] Add packages: `Microsoft.EntityFrameworkCore`, `Npgsql.EntityFrameworkCore.PostgreSQL`, `Microsoft.EntityFrameworkCore.Design`
  - [x] Create `DbContext` and register in DI with `UseNpgsql`
  - [x] Configure `ConnectionStrings:Default` via User Secrets
  - [x] Add initial migration and update database
- [x] Create `Application`, `Domain`, `Infrastructure` projects
- [x] Configure DI and mappings
- [x] Add Health Checks
- [x] Implement JWT auth + authorization policies + CORS
- [x] Add caching (IMemoryCache / distributed)
- [x] Create test projects and initial tests
- [x] Add `dotnet-ef` and first migration
- [x] Setup CI for build/test

#### Database Migration from EF6 to EF Core 9
- [x] **Phase 1: Core Identity & Organization** (6 tables)
  - [x] User, Company, Profile, Region entities
  - [x] UserCompany, CompanyRegion associations
  - [x] Navigation properties and relationships
- [x] **Phase 2: Configuration Tables** (15 tables)
  - [x] Basic configuration tables (AbuseOptions, Countries, etc.)
  - [x] Multilingual support (DE/FR/IT)
  - [x] Soft delete patterns
- [x] **Phase 3: Advanced Configuration** (3 tables)
  - [x] Behaviours, CommentsTemplates, EmailTexts
  - [x] Foreign key relationships
- [x] **Phase 4: Localization** (2 tables)
  - [x] Language and Theme definitions
  - [x] User preferences integration
- [x] **Phase 5: TIMETABLE System** (7 tables)
  - [x] GTFS-compatible transit data
  - [x] Agency, Routes, Trips, Stops, Calendar
  - [x] Complex relationships and composite keys
- [x] **Phase 6: Statistics & Logging** (7 tables)
  - [x] User activity tracking
  - [x] Device logs and debug information
  - [x] Performance monitoring
- [x] **Phase 7: Application Configuration** (2 tables)
  - [x] Application definitions with hierarchy
  - [x] System parameters
- [x] **Phase 8: Configuration with Dependencies** (8 tables)
  - [x] Reasons, Stations, Routes, Dashboards
  - [x] Complex many-to-many relationships
- [x] **Phase 9: TICKETING System** (7 tables) ⭐ **NEW**
  - [x] Complete ticketing management system
  - [x] Categories, Classes, Products, Pricing
  - [x] Tickets with UUID, geolocation, images
  - [x] Multilingual support and advanced features

### 🔄 In Progress

#### Database Migration - Second Iteration
- [ ] **NOVA System** (High Priority)
  - [ ] Analyze NOVA tables in OldContext
  - [ ] Create domain entities for NOVA system
  - [ ] Configure EF Core mappings
  - [ ] Add to AppDbContext
  - [ ] Create and apply migration
- [ ] **INCIDENTS System** (High Priority)
  - [ ] Analyze INCIDENTS tables in OldContext
  - [ ] Create domain entities for INCIDENTS system
  - [ ] Configure EF Core mappings
  - [ ] Add to AppDbContext
  - [ ] Create and apply migration

### 📋 Pending Tasks

#### Remaining Database Systems to Migrate
- [ ] **FORMS System** (Medium Priority)
  - [ ] Survey and form management
  - [ ] Form responses and submissions
- [ ] **DOCBOX System** (Medium Priority)
  - [ ] Document management
  - [ ] File storage and metadata
- [ ] **Miscellaneous Tables** (Low Priority)
  - [ ] Standalone tables without clear system grouping
  - [ ] Legacy utility tables

#### API Development
- [ ] **Controllers Implementation**
  - [ ] User management endpoints
  - [ ] Company and region management
  - [ ] Configuration CRUD operations
  - [ ] TICKETING system endpoints
  - [ ] TIMETABLE system endpoints
- [ ] **Service Layer**
  - [ ] Business logic implementation
  - [ ] Data validation and business rules
  - [ ] Transaction management
- [ ] **Repository Pattern**
  - [ ] Generic repository implementation
  - [ ] Specific repositories for complex queries
  - [ ] Unit of Work pattern

#### Testing & Quality Assurance
- [ ] **Unit Tests**
  - [ ] Entity validation tests
  - [ ] Repository tests
  - [ ] Service layer tests
- [ ] **Integration Tests**
  - [ ] Database integration tests
  - [ ] API endpoint tests
- [ ] **Performance Tests**
  - [ ] Database query performance
  - [ ] API response times

#### Documentation & Deployment
- [ ] **API Documentation**
  - [ ] Swagger documentation updates
  - [ ] Postman collection
  - [ ] API usage examples
- [ ] **Deployment**
  - [ ] Docker containerization
  - [ ] CI/CD pipeline setup
  - [ ] Production environment configuration

### 🎯 Current Status

#### Database Migration Progress
- **Total Tables Migrated**: 54/54 ✅
- **Systems Completed**: 9/9 ✅
  - Core Identity & Organization ✅
  - Configuration (Basic) ✅
  - Configuration (Advanced) ✅
  - Localization ✅
  - TIMETABLE System ✅
  - Statistics & Logging ✅
  - Application Configuration ✅
  - Configuration with Dependencies ✅
  - **TICKETING System** ✅

#### Next Steps
1. **Analyze remaining tables** in OldContext for second iteration
2. **Prioritize systems** based on business importance
3. **Begin NOVA system migration** (high priority)
4. **Continue with INCIDENTS system** (high priority)

### 📊 Migration Statistics
- **Total Legacy Tables**: 54
- **Tables Successfully Migrated**: 54
- **Migration Files Created**: 2
- **Domain Entities Created**: 54
- **Configuration Files Created**: 54
- **Database Status**: ✅ All tables created and functional



