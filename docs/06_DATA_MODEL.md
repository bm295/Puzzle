# Data Model Specification

## Storage strategy

- Primary OLTP relational database
- Strict foreign keys for tenant integrity
- Soft-delete for user-generated content where required

## Initial schema groups

### Identity
- users
- organizations
- memberships
- role_assignments

### Learning
- courses
- modules
- lessons
- enrollments

### Assessment
- assessments
- questions
- submissions
- submission_files
- grades

### Communication and operations
- announcements
- notifications
- notification_deliveries
- audit_logs

## Data integrity rules

- All tables include `organization_id` except global config tables.
- Unique constraints:
  - membership(user_id, organization_id)
  - enrollment(user_id, course_id)
- Indexes on due dates, course publish status, and learner progress queries.

## Migration policy

- Forward-only migrations
- Rollback scripts for critical releases
- Seed data separated from schema migrations

## Change log

- v1.0: Initial schema planning document.
