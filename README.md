## OECore

Opinionated .NET API template guided by `AIInstructions.md`.

### Prerequisites
- .NET SDK 8.0+
- PowerShell 5.1+ (or PowerShell 7)
- Git
- IDE: Visual Studio 2022 or VS Code (C# Dev Kit)

### Quickstart (scaffold locally)
```bash
# from repo root
dotnet --version
dotnet new sln -n OECore
dotnet new webapi -n OECore.Api -o src/OECore.Api --use-controllers
dotnet sln OECore.sln add src/OECore.Api/OECore.Api.csproj

# optional: enable analyzers, nullable, warnings as errors
dotnet new editorconfig

# run
dotnet run --project src/OECore.Api/OECore.Api.csproj
```

Then open `https://localhost:7229/swagger` (see `src/OECore.Api/Properties/launchSettings.json`).

### PostgreSQL
- Start DB (Docker):
```bash
docker run -d --name oecore-postgres -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=postgres -e POSTGRES_DB=OECore -p 5432:5432 postgres:16-alpine
```
- Connection string: `Host=localhost;Port=5432;Database=OECore;Username=postgres;Password=postgres`
- Store it via User Secrets under `ConnectionStrings:Default`

### Project Layout
- `src/OECore.Api` — ASP.NET Core API
- `src/OECore.Application` — application services (TBD)
- `src/OECore.Domain` — domain model (TBD)
- `src/OECore.Infrastructure` — EF Core and integrations (TBD)
- `tests/` — unit and integration tests

See `docs/SETUP.md` to prepare the environment, and `docs/ARCHITECTURE.md` for structure.


