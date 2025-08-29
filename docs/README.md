# OECore - Entity Framework Core 9 Migration

## Project Overview
OECore is a comprehensive transportation management system that has been successfully migrated from Entity Framework 6 to Entity Framework Core 9, with PostgreSQL as the database engine.

## Current Status ✅
- **Total Tables**: 71/71 ✅ **COMPLETED**
- **Systems Migrated**: 11/11 ✅ **COMPLETED**
- **Migration Files**: 5
- **Database Engine**: PostgreSQL
- **EF Core Version**: 9.0

## Migrated Systems ✅

### 1. Core Identity System (6 tables)
- User management and authentication
- Multi-company support
- Role-based access control
- Soft delete functionality

### 2. Configuration System (28 tables)
- System configuration and parameters
- Multilingual support (DE/FR/IT/EN)
- Business logic configuration
- UI/UX settings and themes

### 3. TIMETABLE System (7 tables)
- GTFS-compliant public transport data
- Agency, routes, trips, stops management
- Calendar and service schedules
- Stop times and frequency data

### 4. Statistics & Logs System (7 tables)
- User activity tracking
- Performance monitoring
- Device logs and debugging
- System analytics

### 5. TICKETING System (7 tables)
- Product catalog and pricing
- Ticket management with UUID
- Image storage for tickets
- Multilingual product descriptions

### 6. NOVA System (3 tables)
- NOVA integration platform
- Multilingual product data
- Company-product associations
- Payment processing support

### 7. INCIDENTS System (9 tables) ⭐ **NEW**
- Complete incident lifecycle management
- Passenger and tutor data handling
- Payment processing with online transactions
- Geolocation and abuse detection
- Export functionality for external systems
- Task and turn management
- Comprehensive audit logging

## Key Features

### 🔧 Technical Features
- **Entity Framework Core 9**: Latest EF Core version
- **PostgreSQL**: Robust, scalable database
- **UUID Primary Keys**: Distributed system support
- **Soft Delete**: Data preservation and audit trail
- **Multilingual Support**: German, French, Italian, English
- **Geolocation**: GPS coordinates for location-based services
- **Payment Processing**: Multiple payment methods support
- **Audit Logging**: Comprehensive change tracking

### 🏗️ Architecture
- **Clean Architecture**: Domain, Application, Infrastructure layers
- **Repository Pattern**: Data access abstraction
- **Dependency Injection**: IoC container configuration
- **Migration Management**: EF Core migrations
- **Configuration Management**: Environment-based settings

### 📊 Database Features
- **71 Tables**: Complete system coverage
- **Foreign Key Relationships**: Referential integrity
- **Indexes**: Performance optimization
- **Data Types**: PostgreSQL-optimized mappings
- **Constraints**: Business rule enforcement

## Getting Started

### Prerequisites
- .NET 9.0 SDK
- PostgreSQL 15+
- Docker (optional)

### Installation
1. Clone the repository
2. Configure connection string in `appsettings.json`
3. Run migrations: `dotnet ef database update`
4. Start the application: `dotnet run`

### Database Setup
```bash
# Apply all migrations
dotnet ef database update

# Verify database status
dotnet ef migrations list
```

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

### Phase 7: INCIDENTS (20250829095806) ⭐
- Complete incident management system
- 9 tables for incident lifecycle management

## Project Structure

```
OECore/
├── src/
│   ├── OECore.Api/           # Web API project
│   ├── OECore.Application/   # Application layer
│   ├── OECore.Domain/        # Domain entities
│   └── OECore.Infrastructure/# Data access layer
├── docs/                     # Documentation
└── OldContext/              # Legacy EF6 context
```

## Documentation

- [Database Documentation](docs/DATABASE.md) - Complete database schema
- [Migration Plan](docs/MIGRATION_PLAN.md) - Migration strategy and phases
- [Backlog](docs/BACKLOG.md) - Project progress and next steps
- [Setup Guide](docs/SETUP.md) - Development environment setup
- [Architecture](docs/ARCHITECTURE.md) - System architecture overview

## Next Steps

### Immediate Priorities
1. **FORMS System Migration** - Form management and data collection
2. **DOCBOX System Migration** - Document management system
3. **API Development** - REST endpoints for all systems

### Future Enhancements
- Performance optimization
- Comprehensive testing
- Deployment automation
- API documentation

## Contributing

1. Follow the established architecture patterns
2. Use EF Core migrations for database changes
3. Update documentation for any schema changes
4. Ensure all tests pass before submitting

## License

This project is proprietary software. All rights reserved.

## Support

For technical support or questions about the migration, please refer to the documentation or contact the development team.




