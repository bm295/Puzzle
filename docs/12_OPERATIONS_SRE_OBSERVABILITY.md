# Operations, SRE, and Observability

## Deployment model

- Environment tiers: dev, staging, production
- Immutable build artifacts
- Automated database migration step with approvals

## Observability

- Structured logs with correlation IDs
- Metrics:
  - API latency/error rate
  - Submission throughput/failure rate
  - Notification success rate
- Distributed tracing for key transactions

## Reliability practices

- Backup policy with restore drills
- Incident severity matrix (SEV-1 to SEV-4)
- Error budget tracking per release window

## Operational runbooks

- Auth outage recovery
- Queue backlog mitigation
- Data correction process for grading incidents

## Change log

- v1.0: Ops and reliability baseline.
