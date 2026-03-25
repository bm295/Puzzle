# Security, Privacy, and Compliance Baseline

## Security controls

- Password hashing using modern adaptive algorithm
- MFA-ready design (optional MVP)
- RBAC enforcement at endpoint and business layer
- CSRF protection for cookie-based auth
- Rate limiting for auth and submission endpoints

## Privacy controls

- Data minimization in profiles and analytics
- Retention policies for submissions and audit logs
- Data export/delete workflows (region-dependent)

## Compliance baseline

- FERPA-oriented student record protections
- GDPR readiness for EU users if enabled
- Auditability of grade changes and role changes

## Threat model focus

- Horizontal privilege escalation
- Grade tampering
- Insecure file upload handling
- Tenant data leakage

## Security verification checklist

- Authorization tests for every protected endpoint
- File scanning and content-type restrictions
- Encryption in transit and at rest
- Secrets management policy documented

## Change log

- v1.0: Security and compliance baseline.
