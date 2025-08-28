## Old Context (reference)

This folder contains the legacy EF6 context and entities for reference during the migration.

### Snapshot
- Context class: `OpenEyeBackendEntities.Entities : System.Data.Entity.DbContext`
- Provider: SQL Server (`System.Data.SqlClient`)
- Entities: ≈190 `DbSet<>` properties declared
- Views detected: 18 files named `vw_*.cs`
- Table-like classes detected: 100+ files named `tbl_*.cs`
- Custom SQL usage present (raw SQL in `Entities.cs`)

### Notes for EF Core + PostgreSQL
- Replace EF6 APIs with EF Core Fluent API configurations
- Adjust SQL Server-specific types to PostgreSQL types (e.g., `datetime` → `timestamptz`, `money` → `numeric(18,2)`)
- Keys: prefer identity/bigint or UUID; configure sequences as needed
- Naming: adopt snake_case (`UseSnakeCaseNamingConvention`) to match PostgreSQL conventions
- Views: model as read-only entities or database views with `ToView(...)`
- Stored procedures/raw SQL: move to application services or use EF Core `FromSql` with parameterization

Use this folder only as a guideline; do not reference it from new projects.


