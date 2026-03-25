# AI Agent Workflow and Guardrails

## Objective

Enable AI-assisted implementation while preserving correctness, safety, and maintainability.

## Standard workflow

1. Read execution order doc and dependencies.
2. Propose plan with small, reviewable increments.
3. Implement one vertical slice per PR.
4. Run tests/lint/static checks.
5. Generate migration notes and risk notes.
6. Request human approval at gate boundaries.

## PR sizing policy

- Preferred: < 500 lines net change per PR
- Max scope: one feature + related tests + docs

## Required outputs per PR

- Updated docs (if behavior changed)
- Automated test coverage for new behavior
- Security impact note
- Rollback strategy note

## Guardrails

- Never bypass authorization checks.
- Never merge schema changes without migration scripts.
- Never introduce breaking API changes without versioning.
- Always include observability hooks for critical workflows.

## Escalation triggers

- Unclear requirement or conflicting docs
- Security/compliance ambiguity
- Data migration risk affecting existing records

## Change log

- v1.0: AI-native build workflow.
