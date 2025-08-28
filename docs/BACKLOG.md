## Backlog & Checklist

- [ ] Initialize solution and API project
  - [ ] `dotnet new sln -n OECore`
  - [ ] `dotnet new webapi -n OECore.Api -o src/OECore.Api --use-controllers`
  - [ ] `dotnet sln OECore.sln add src/OECore.Api/OECore.Api.csproj`
- [ ] Add editorconfig, enable nullable, warnings as errors
- [ ] Add Swagger and XML comments
- [ ] Setup Global Exception Handling middleware
- [ ] Add EF Core with PostgreSQL (Npgsql)
  - [ ] Add packages: `Microsoft.EntityFrameworkCore`, `Npgsql.EntityFrameworkCore.PostgreSQL`, `Microsoft.EntityFrameworkCore.Design`
  - [ ] Create `DbContext` and register in DI with `UseNpgsql`
  - [ ] Configure `ConnectionStrings:Default` via User Secrets
  - [ ] Add initial migration and update database
- [ ] Create `Application`, `Domain`, `Infrastructure` projects
- [ ] Configure DI and mappings
- [ ] Add Health Checks
- [ ] Implement JWT auth + authorization policies + CORS
- [ ] Add caching (IMemoryCache / distributed)
- [ ] Create test projects and initial tests
- [ ] Add `dotnet-ef` and first migration
- [ ] Setup CI for build/test



