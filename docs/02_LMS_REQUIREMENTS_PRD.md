# Product Requirements Document (PRD) — LMS

## Functional requirements

### FR-01 Authentication and identity
- User sign up/in (email + password for MVP)
- Password reset
- Session management

### FR-02 Organization and roles
- Create organizations (tenants)
- Invite users
- Assign roles: Admin, Instructor, Learner

### FR-03 Course lifecycle
- Create/edit/publish/archive courses
- Draft and publish states
- Version metadata for course content changes

### FR-04 Curriculum structure
- Modules and lessons with ordering
- Lesson content types: text, video link, file, external URL

### FR-05 Enrollment
- Instructor enrolls learners manually
- Self-enrollment via token/link (optional setting)

### FR-06 Assessments
- Quizzes (MCQ + short answer)
- Assignments with file submission
- Due dates and late status

### FR-07 Grading
- Auto grade for objective quiz items
- Manual override by instructor
- Gradebook export CSV

### FR-08 Learner progress
- Lesson completion tracking
- Course progress percentage
- “At-risk” indicators

### FR-09 Communication
- Announcement posting at course level
- Notification preferences

### FR-10 Reporting
- Enrollment count, completion rate, average score
- Instructor view by course/cohort

## Non-functional requirements

- NFR-01 Availability target: 99.5% (MVP)
- NFR-02 P95 latency < 500ms (core APIs)
- NFR-03 Audit trails for permissions, grades, and publish events
- NFR-04 Accessibility: WCAG 2.1 AA baseline
- NFR-05 Security: OWASP ASVS-aligned controls (MVP subset)

## Constraints

- Must evolve from current repository structure.
- Must support AI-assisted incremental delivery via small PRs.

## Acceptance criteria (MVP)

- Admin can create course and assign instructor.
- Instructor can publish course and create graded quiz.
- Learner can enroll, submit, and view grade.
- Dashboard surfaces progress and completion.

## Change log

- v1.0: MVP requirements baseline.
