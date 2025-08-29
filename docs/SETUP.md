## Environment Setup

### Install
- Install .NET SDK 8.0+: `https://dotnet.microsoft.com/download`
- Visual Studio 2022 (ASP.NET + web workload) or VS Code with C# Dev Kit
- Git: `https://git-scm.com/downloads`
- GitHub CLI: `https://cli.github.com/`
- PostgreSQL 14+ (or Docker Desktop to run PostgreSQL in a container)

### Verify
```bash
dotnet --info
git --version
gh --version
```

### Bootstrap Solution
```bash
# from repo root
dotnet new sln -n OECore
mkdir src
dotnet new webapi -n OECore.Api -o src/OECore.Api --use-controllers
dotnet sln OECore.sln add src/OECore.Api/OECore.Api.csproj

# enable nullable + warnings as errors
dotnet new editorconfig

# local dotnet tools (EF + format)
dotnet new tool-manifest
dotnet tool install dotnet-ef
dotnet tool install dotnet-format
```

### Database (PostgreSQL)
- Local install: `https://www.postgresql.org/download/`
- Or run via Docker:
```bash
docker run -d --name oecore-postgres -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=postgres -e POSTGRES_DB=OECore \
  -p 5432:5432 postgres:16-alpine
```

Sample connection string:
```
Host=localhost;Port=5432;Database=OECore;Username=postgres;Password=postgres;Pooling=true;Maximum Pool Size=50
```

Set as user secret (recommended during development):
```bash
dotnet user-secrets init --project src/OECore.Api/OECore.Api.csproj
dotnet user-secrets set "ConnectionStrings:Default" "Host=localhost;Port=5432;Database=OECore;Username=postgres;Password=postgres" \
  --project src/OECore.Api/OECore.Api.csproj
```

### Recommended NuGet Packages
- Swashbuckle.AspNetCore (Swagger)
- Microsoft.EntityFrameworkCore
- Npgsql.EntityFrameworkCore.PostgreSQL
- Microsoft.EntityFrameworkCore.Design
- FluentValidation.AspNetCore (optional)
- AutoMapper.Extensions.Microsoft.DependencyInjection (optional)

Add packages (example, adjust once projects exist):
```bash
dotnet add src/OECore.Api/OECore.Api.csproj package Swashbuckle.AspNetCore
dotnet add src/OECore.Api/OECore.Api.csproj package Microsoft.EntityFrameworkCore
dotnet add src/OECore.Api/OECore.Api.csproj package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add src/OECore.Api/OECore.Api.csproj package Microsoft.EntityFrameworkCore.Design
```

### Run
```bash
dotnet run --project src/OECore.Api/OECore.Api.csproj
```

Open `https://localhost:7229/swagger` (or the HTTPS port in `launchSettings.json`).

### Git Hygiene
```bash
git config core.autocrlf true
git config pull.rebase false
```

### PATH Configuration (Windows)
If Git or GitHub CLI commands are not recognized, add these paths to your system PATH:

**Git**: `C:\Program Files\Git\bin`
**GitHub CLI**: `C:\Program Files\GitHub CLI`

#### How to add to PATH permanently:
1. Press `Windows + R`, type `sysdm.cpl` and press Enter
2. Go to "Advanced" tab → "Environment Variables..."
3. Under "System variables", find "Path" and click "Edit"
4. Click "New" and add each path:
   - `C:\Program Files\Git\bin`
   - `C:\Program Files\GitHub CLI`
5. Click "OK" on all dialogs

#### Alternative: Command line (permanent)
```cmd
setx PATH "%PATH%;C:\Program Files\Git\bin;C:\Program Files\GitHub CLI"
```

#### Alternative: PowerShell (current session only)
```powershell
$env:PATH += ";C:\Program Files\Git\bin;C:\Program Files\GitHub CLI"
```

**Note**: After adding to PATH, open a new terminal for changes to take effect.

### Next
- See `ARCHITECTURE.md` and `CODING_GUIDELINES.md` before adding code.
- Track progress in `BACKLOG.md`.



