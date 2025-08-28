## API Guidelines

### Routing and Versioning
- Attribute routing with `api/v{version:apiVersion}/[controller]`
- Use Microsoft.AspNetCore.Mvc.Versioning or URL versioning

### Contracts
- Use request/response DTOs; do not expose EF entities
- Nullable reference types enabled; validate all inputs

### Validation
- DataAnnotations or FluentValidation; return 400 with details

### Errors
Return a consistent payload (Problem Details-like):
```json
{
  "traceId": "...",
  "status": 400,
  "title": "Validation failed",
  "errors": { "Field": ["Reason"] }
}
```

### Pagination/Filtering
- Support `page`, `pageSize` (defaults with caps)
- Sorting via `sort` (e.g., `name,-createdAt`)
- Filtering via query parameters; document in Swagger

### Swagger/OpenAPI
- Enable Swagger in all environments; include XML comments
- Group by version

### Security
- JWT Bearer auth; `[Authorize]` on protected endpoints
- CORS restricted to known origins
- HTTPS enforced



