# AI Prompts and Task Templates (LMS)

Use these templates to keep AI agent outputs consistent and reviewable.

## Template A: Feature implementation prompt

"Implement `[feature]` for LMS using existing architecture docs. Include:
1) DB migration
2) API endpoints
3) authorization policy
4) tests (unit + integration)
5) docs updates
Limit PR scope to one vertical slice."

## Template B: Bugfix prompt

"Diagnose and fix `[bug]` in LMS.
Provide:
- root cause
- minimal fix
- regression test
- risk assessment and rollback note."

## Template C: Refactor prompt

"Refactor `[module]` for maintainability without changing behavior.
Must preserve API contracts and add/adjust tests proving parity."

## Template D: Security review prompt

"Review `[feature/module]` for authz/authn, input validation, tenant isolation, logging, and secret handling.
Output findings by severity with concrete remediation steps."

## Template E: Release readiness prompt

"Evaluate release candidate `[version]` against QA and ops checklists.
Return GO/NO-GO with blocking issues and mitigation plan."

## Change log

- v1.0: Prompt starter set for AI-native LMS delivery.
