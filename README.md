# OECore - .NET Core API Project

A modern .NET Core API project built with clean architecture principles, Entity Framework Core, and PostgreSQL.

## 🚀 Features

- **.NET 9.0** - Latest .NET version
- **Clean Architecture** - Separation of concerns with Domain, Application, Infrastructure, and API layers
- **Entity Framework Core** - Modern ORM with PostgreSQL support
- **PostgreSQL** - Robust, open-source database
- **Swagger/OpenAPI** - API documentation and testing interface
- **Docker Support** - Containerized PostgreSQL database
- **User Secrets** - Secure configuration management
- **EF Core Migrations** - Database schema versioning

## 📋 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (for PostgreSQL)
- [Git](https://git-scm.com/downloads)

## 🛠️ Quick Start

### 1. Clone the Repository
```bash
git clone <your-repo-url>
cd OECore
```

### 2. Start PostgreSQL Database
```bash
docker run --name oecore-postgres -e POSTGRES_PASSWORD=postgres -e POSTGRES_DB=OECoreDev -p 5432:5432 -d postgres:15
```

### 3. Configure Connection String
Set up your database connection string using user secrets:
```bash
cd src/OECore.Api
dotnet user-secrets set "ConnectionStrings:Default" "Host=localhost;Port=5432;Database=OECoreDev;Username=postgres;Password=postgres"
```

### 4. Apply Database Migrations
```bash
dotnet ef database update -s src/OECore.Api/OECore.Api.csproj -p src/OECore.Infrastructure/OECore.Infrastructure.csproj
```

### 5. Run the Application
```bash
dotnet run --project src/OECore.Api/OECore.Api.csproj
```

### 6. Access the API
- **API**: https://localhost:7229
- **Swagger UI**: https://localhost:7229/swagger

## 🏗️ Project Structure

```
OECore/
├── src/
│   ├── OECore.Api/                 # Web API layer
│   ├── OECore.Application/         # Application services & DTOs
│   ├── OECore.Domain/              # Domain entities & business logic
│   └── OECore.Infrastructure/      # Data access & external services
├── docs/                           # Project documentation
│   ├── SETUP.md                    # Detailed setup instructions
│   ├── ARCHITECTURE.md             # Architecture guidelines
│   ├── API_GUIDELINES.md           # API design guidelines
│   ├── CODING_GUIDELINES.md        # Coding standards
│   ├── SECURITY.md                 # Security guidelines
│   ├── TESTING.md                  # Testing strategy
│   ├── BACKLOG.md                  # Development backlog
│   ├── DATABASE.md                 # Database documentation
│   ├── OLD_CONTEXT.md              # Legacy context analysis
│   └── MIGRATION_PLAN.md           # Migration strategy
└── OldContext/                     # Legacy .NET Framework context files
```

## 🗄️ Database Schema

### Core Entities

#### User
- **Identity**: Id, Email, Username, DisplayName
- **Personal Info**: FirstName, LastName, Address, City, Country, Phone
- **Security**: HashPasswordSalt, LastPasswordChangeUTC, ForceResetPassword
- **Timestamps**: ValidFromUtc, ValidToUtc, DeletedUTC, LastLoginUTC, LastBalanceUTC
- **Relations**: EmployerCompany (Company), UserCompanies (many-to-many with Company)

#### Company
- **Identity**: Id, Name, LegalName, CountryCode
- **Timestamps**: CreatedAt, UpdatedAt
- **Relations**: CompanyRegions (many-to-many with Region)

#### Profile
- **Identity**: Id, ShortName, Name
- **Status**: IsActive, DeletedUTC

#### Region
- **Identity**: Id, Name, Code

## 🔧 Development

### Adding New Entities
1. Create entity in `OECore.Domain/Entities/`
2. Create configuration in `OECore.Infrastructure/Configurations/`
3. Add DbSet to `AppDbContext`
4. Generate and apply migration

### Running Migrations
```bash
# Create migration
dotnet ef migrations add MigrationName -s src/OECore.Api/OECore.Api.csproj -p src/OECore.Infrastructure/OECore.Infrastructure.csproj

# Apply migration
dotnet ef database update -s src/OECore.Api/OECore.Api.csproj -p src/OECore.Infrastructure/OECore.Infrastructure.csproj
```

### Building the Project
```bash
dotnet build
```

## 📚 Documentation

- [Setup Guide](docs/SETUP.md) - Detailed environment setup
- [Architecture](docs/ARCHITECTURE.md) - Project architecture overview
- [API Guidelines](docs/API_GUIDELINES.md) - API design principles
- [Coding Guidelines](docs/CODING_GUIDELINES.md) - Code standards
- [Security](docs/SECURITY.md) - Security best practices
- [Testing](docs/TESTING.md) - Testing strategy
- [Database](docs/DATABASE.md) - Database design and conventions

## 🔄 Migration from Legacy System

This project is migrating from a .NET Framework application with Entity Framework 6. See:
- [Migration Plan](docs/MIGRATION_PLAN.md) - Phased migration strategy
- [Old Context Analysis](docs/OLD_CONTEXT.md) - Legacy system analysis

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🆘 Support

For support and questions, please open an issue in the GitHub repository.


