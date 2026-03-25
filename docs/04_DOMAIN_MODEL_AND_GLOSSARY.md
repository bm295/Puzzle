# Domain Model and Glossary

## Core entities

- Organization (tenant boundary)
- User (identity)
- RoleAssignment (user role per org/course)
- Course
- Module
- Lesson
- Enrollment
- Assessment (quiz/assignment)
- Question
- Submission
- Grade
- Announcement
- Notification
- AuditLog

## Relationships

- Organization has many Users, Courses.
- Course has many Modules, Assessments, Enrollments.
- Module has ordered Lessons.
- Assessment has Questions and Submissions.
- Submission may have one or many Grade records (regrade trail).

## Glossary

- Tenant: isolated organization data boundary.
- Cohort: subgroup of learners within course run.
- Publish: transition from draft to learner-visible.
- Late submission: submitted after due date.
- Completion: policy-defined learner finished state.

## Invariants

- A learner cannot submit to an unpublished assessment.
- A grade change must be auditable.
- Enrollment must belong to same tenant as course and user.

## Change log

- v1.0: Domain baseline.
