# Puzzle → AI-Native LMS Rewrite

This repository is being repurposed into an AI-native Learning Management System (LMS).

## Start here

Read the document execution order first:

- `docs/00_AI_EXECUTION_ORDER.md`

Then execute each document in sequence (`01` to `13`) to drive planning, architecture, implementation, and operations.

## Existing runtime (current code)

The existing codebase currently runs as a .NET web app:

```bash
dotnet run --project WebApplication/WebApplication.csproj
```

## Goal

Transition from the current puzzle/demo structure to an LMS that supports:

- Multi-tenant organizations
- Role-based administration
- Course authoring and publishing
- Assessments, grading, and progress tracking
- Reporting, notifications, and auditability
