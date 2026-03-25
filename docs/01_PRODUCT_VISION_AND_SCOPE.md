# Product Vision and Scope — LMS Rewrite

## Vision

Build a modern, AI-native Learning Management System that supports the full learning lifecycle for institutions and organizations:

- Course authoring
- Enrollment and cohort management
- Content delivery (sync/async)
- Assessments and grading
- Progress tracking and analytics
- Certification/completion workflows

## Strategic goals

1. Replace puzzle/demo behavior with production-grade LMS foundations.
2. Ship an MVP in progressive milestones without architecture rework.
3. Enable AI agents to safely implement features with strong guardrails.

## In-scope (MVP)

- Multi-tenant organization support
- Role-based access: Admin, Instructor, Learner
- Course structure: Course → Module → Lesson
- Assignments, quizzes, and submissions
- Gradebook with manual/auto grading support
- Basic learner dashboard and instructor dashboard
- Notifications (in-app + email)
- Audit logging for critical actions

## Out-of-scope (MVP)

- Marketplace/billing engine
- Full SCORM/xAPI ingestion
- Advanced proctoring
- Social network/feed features
- Native mobile apps (web responsive only)

## Success metrics

- Time-to-first-course creation < 30 minutes
- 95%+ successful submission rate
- P95 page response under 500ms for core pages
- <1% failed notification deliveries

## Stakeholders

- Product owner
- Engineering lead
- Design lead
- Compliance/security owner
- Pilot instructors and learners

## Risks

- Scope creep from “all-in-one LMS” expectations
- Underestimated compliance constraints (FERPA/GDPR regions)
- AI-generated code quality variability

## Assumptions

- Existing .NET stack remains the platform base.
- Initial DB is relational (PostgreSQL or SQL Server).
- Auth can start local and later federate (OIDC/SAML).

## Change log

- v1.0: Initial LMS rewrite vision.
