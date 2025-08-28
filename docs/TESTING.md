## Testing Strategy

### Projects
- `tests/OECore.Tests` — unit tests (xUnit)
- `tests/OECore.IntegrationTests` — API/integration tests

### Unit Tests
- One class per SUT; arrange-act-assert
- Name: `MethodName_ShouldDo_WhenCondition`
- Mock dependencies with Moq/NSubstitute

### Integration Tests
- Use `WebApplicationFactory<Program>` to host API in-memory
- For persistence tests, target a real PostgreSQL instance (Docker recommended)
- Seed test data via a separate DbContext using an isolated database/schema
- Use a unique database per test run or transactional cleanup

### Commands
```bash
dotnet test
```

Run PostgreSQL for tests (example):
```bash
docker run -d --rm --name oecore-testdb -e POSTGRES_PASSWORD=postgres -e POSTGRES_USER=postgres -e POSTGRES_DB=OECore_Test \
  -p 5433:5432 postgres:16-alpine
```

### Coverage
- Aim for meaningful coverage on business logic and critical paths



