## Architecture

### Projects (planned)
- `src/OECore.Api` — ASP.NET Core API (controllers, filters, DI, startup)
- `src/OECore.Application` — application services, DTOs, orchestrations
- `src/OECore.Domain` — domain entities, value objects, domain services
- `src/OECore.Infrastructure` — EF Core DbContext, repositories, outbound integrations
- `tests/OECore.Tests` — unit tests
- `tests/OECore.IntegrationTests` — API/integration tests

### Dependency Direction
`Api` -> `Application` -> `Domain`
`Infrastructure` -> depends on `Domain` and is referenced by `Api` for DI registration.

### Cross-cutting
- DI: built-in container with constructor injection
- Configuration: `IOptions<T>`
- Logging: Microsoft.Extensions.Logging (optionally Serilog)
- Mapping: AutoMapper (optional)
- Background work: `IHostedService`/`BackgroundService`
- Caching: `IMemoryCache` / distributed cache

### Data Access
- EF Core with Npgsql provider (PostgreSQL)
- Migrations managed via `dotnet-ef`
- Efficient LINQ; avoid N+1 via `Include` or projections
- Pagination for large queries

### API Surface
- Attribute routing, RESTful design, versioning (URL or header)
- Validation via DataAnnotations or FluentValidation
- Global exception handling middleware with consistent error contract
- Swagger/OpenAPI with XML comments



