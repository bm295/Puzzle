# AI-Native LMS Rewrite — Document Execution Order

This repository should be rewritten into a **Learning Management System (LMS)** using an AI-native workflow (AI agents + human approvals).

This file is the master run-order for all project documents.

---

## How to use this sequence

- AI agents must process documents **in numeric order**.
- A document can only be executed when its dependencies are approved.
- Every phase must produce artifacts (PRs, design outputs, test evidence) before moving forward.

---

## Execution order (required)

1. **01_PRODUCT_VISION_AND_SCOPE.md**  
   Define business goals, product boundaries, and non-goals.
2. **02_LMS_REQUIREMENTS_PRD.md**  
   Define functional and non-functional requirements.
3. **03_PERSONAS_AND_JOURNEYS.md**  
   Validate personas and user journeys against requirements.
4. **04_DOMAIN_MODEL_AND_GLOSSARY.md**  
   Lock shared language and domain entities.
5. **05_SYSTEM_ARCHITECTURE.md**  
   Select architecture and module boundaries.
6. **06_DATA_MODEL.md**  
   Define relational schema, constraints, and migrations strategy.
7. **07_API_AND_EVENTS_SPEC.md**  
   Define service contracts, API shapes, and event topics.
8. **08_SECURITY_PRIVACY_COMPLIANCE.md**  
   Apply compliance, access control, and data governance rules.
9. **09_AI_AGENT_WORKFLOW_AND_GUARDRAILS.md**  
   Define how AI agents plan, code, review, and escalate.
10. **10_IMPLEMENTATION_PLAN_AND_MILESTONES.md**  
    Break work into epics/sprints with measurable exits.
11. **11_TEST_QA_AND_ACCEPTANCE.md**  
    Define quality gates, test matrix, and release criteria.
12. **12_OPERATIONS_SRE_OBSERVABILITY.md**  
    Define deployment, monitoring, backup, and incident response.
13. **13_PROMPTS_AND_TASK_TEMPLATES.md**  
    Use standardized prompts for implementation consistency.

---

## Stage gates

- **Gate A (Discovery complete):** docs 01-04 approved.
- **Gate B (Design complete):** docs 05-08 approved.
- **Gate C (Build-ready):** docs 09-11 approved.
- **Gate D (Run-ready):** doc 12 approved.
- **Gate E (Scale-ready):** doc 13 adopted and measured.

---

## Definition of done for each document

Each doc is considered executable only when:

- Decision owners are identified.
- Open questions are enumerated.
- Risks and assumptions are explicit.
- Acceptance criteria are testable.
- A change log section exists.

