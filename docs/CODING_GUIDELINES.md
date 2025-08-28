## Coding Guidelines

Aligned with `AIInstructions.md`.

### Naming
- PascalCase: classes, methods, public members
- camelCase: locals, private fields
- UPPERCASE: constants
- Interfaces prefixed with `I`

### Style
- C# 10+ features where appropriate (records, pattern matching, nullability)
- Prefer LINQ and expressions for clarity; avoid premature micro-optimizations
- Use `var` when type is obvious
- Treat warnings as errors; enable nullable reference types

### Structure
- Thin controllers; place logic in application services
- Use DI; avoid service locators and statics
- Prefer EF Core directly; introduce repositories only when needed
- Use AutoMapper for large mapping surfaces (optional)

### Error Handling
- Exceptions for exceptional paths only
- Centralize handling; log with context and correlation IDs
- Return meaningful HTTP status codes and problem details

### Validation
- DataAnnotations or FluentValidation; fail fast on invalid models

### Performance
- Async/await for I/O
- Cache where beneficial; design for pagination
- Avoid N+1 queries and chatty APIs

### Testing
- xUnit/NUnit/MSTest; Moq/NSubstitute
- Integration tests for controllers and persistence



