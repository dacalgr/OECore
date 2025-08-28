## Security

### Authentication/Authorization
- JWT Bearer authentication; store keys/secrets securely (User Secrets locally)
- Authorization via roles/policies; prefer policy-based `[Authorize(Policy = "...")]`

### Transport and CORS
- Enforce HTTPS redirection
- Restrictive CORS; allow only known origins, headers, and methods

### Data Protection
- Do not log secrets or PII; use structured logging
- Validate and sanitize inputs; follow OWASP ASVS

### Configuration
- Use `appsettings.json` + environment overrides + User Secrets
- Never commit secrets



