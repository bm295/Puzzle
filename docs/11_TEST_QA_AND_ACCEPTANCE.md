# Test, QA, and Acceptance Strategy

## Test pyramid

- Unit tests: domain logic and policies
- Integration tests: API + DB + background job flows
- E2E tests: critical user journeys

## Critical acceptance scenarios

1. Instructor publishes course and learner can access it.
2. Learner submits assignment and instructor grades it.
3. Role restriction prevents learner from grading.
4. Grade changes create immutable audit entries.

## Quality gates

- All tests pass in CI
- No critical/high security findings unresolved
- Migration scripts validated in staging clone
- API contract checks pass

## Performance checks

- Course list endpoint P95 < 500ms
- Submission endpoint stable under expected peak class load

## Release readiness checklist

- Rollback plan tested
- Monitoring alerts configured
- On-call runbook reviewed

## Change log

- v1.0: QA baseline.
