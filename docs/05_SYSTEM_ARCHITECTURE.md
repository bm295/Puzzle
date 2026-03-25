# System Architecture — LMS Rewrite

## Recommended architecture

- Modular monolith for MVP (clear internal domain modules)
- API-first backend (REST now, GraphQL optional later)
- Server-rendered or SPA frontend (decision can follow team preference)

## Backend modules

1. Identity & Access
2. Course Authoring
3. Enrollment & Cohorts
4. Assessment & Grading
5. Progress & Analytics
6. Notifications
7. Audit & Compliance

## Cross-cutting concerns

- Authorization policy engine
- Validation and idempotency
- Audit log pipeline
- Observability (traces, metrics, logs)
- Background jobs for notifications and reporting

## Data and integration boundaries

- Single primary relational database for MVP
- Object storage abstraction for assignment attachments
- Email provider abstraction

## Architecture decisions (ADRs to create)

- ADR-001: Multi-tenancy model
- ADR-002: Grading event-sourcing or mutable ledger
- ADR-003: Notification delivery strategy

## Change log

- v1.0: Initial architecture target.
