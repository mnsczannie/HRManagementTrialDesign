-- =============================================
-- HR APPLICANT SYSTEM — SCHEMA
-- Run this once on Azure SQL
-- =============================================

CREATE TABLE users (
    user_id     INT IDENTITY(1,1) PRIMARY KEY,
    full_name   NVARCHAR(100),
    email       NVARCHAR(100) UNIQUE NOT NULL,
    password    NVARCHAR(255) NOT NULL,
    role        NVARCHAR(20) CHECK (role IN
                  ('admin','hr_staff','hr_manager'))
                  NOT NULL,
    is_active   BIT DEFAULT 1,
    created_at  DATETIME DEFAULT GETDATE()
);

CREATE TABLE applicants (
    applicant_id  INT IDENTITY(1,1) PRIMARY KEY,
    full_name     NVARCHAR(100),
    email         NVARCHAR(100) UNIQUE NOT NULL,
    password      NVARCHAR(255) NOT NULL,
    phone         NVARCHAR(20),
    address       NVARCHAR(MAX),
    birthdate     DATE,
    gender        NVARCHAR(10),
    city          NVARCHAR(100),
    province      NVARCHAR(100),
    zip_code      NVARCHAR(10),
    school        NVARCHAR(200),
    degree        NVARCHAR(200),
    year_grad     NVARCHAR(10),
    skills        NVARCHAR(MAX),
    company       NVARCHAR(200),
    position      NVARCHAR(200),
    duration      NVARCHAR(100),
    is_active     BIT DEFAULT 1,
    created_at    DATETIME DEFAULT GETDATE()
);

CREATE TABLE departments (
    department_id  INT IDENTITY(1,1) PRIMARY KEY,
    name           NVARCHAR(100) NOT NULL
);

CREATE TABLE positions (
    position_id    INT IDENTITY(1,1) PRIMARY KEY,
    title          NVARCHAR(100) NOT NULL,
    department_id  INT,
    FOREIGN KEY (department_id)
        REFERENCES departments(department_id)
);

CREATE TABLE employment_types (
    type_id  INT IDENTITY(1,1) PRIMARY KEY,
    label    NVARCHAR(50) NOT NULL
);

CREATE TABLE requirement_types (
    req_type_id  INT IDENTITY(1,1) PRIMARY KEY,
    label        NVARCHAR(100) NOT NULL
);

CREATE TABLE interview_types (
    interview_type_id  INT IDENTITY(1,1) PRIMARY KEY,
    label              NVARCHAR(100) NOT NULL
);

CREATE TABLE assessment_types (
    assessment_type_id  INT IDENTITY(1,1) PRIMARY KEY,
    label               NVARCHAR(100) NOT NULL
);

CREATE TABLE job_vacancies (
    vacancy_id          INT IDENTITY(1,1) PRIMARY KEY,
    position_id         INT,
    department_id       INT,
    employment_type_id  INT,
    description         NVARCHAR(MAX),
    qualifications      NVARCHAR(MAX),
    slots               INT,
    status              NVARCHAR(10)
                          CHECK (status IN ('open','closed'))
                          DEFAULT 'open',
    posted_by           INT,
    posted_at           DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (position_id)
        REFERENCES positions(position_id),
    FOREIGN KEY (department_id)
        REFERENCES departments(department_id),
    FOREIGN KEY (employment_type_id)
        REFERENCES employment_types(type_id),
    FOREIGN KEY (posted_by)
        REFERENCES users(user_id)
);

CREATE TABLE vacancy_requirements (
    req_id       INT IDENTITY(1,1) PRIMARY KEY,
    vacancy_id   INT,
    req_type_id  INT,
    FOREIGN KEY (vacancy_id)
        REFERENCES job_vacancies(vacancy_id),
    FOREIGN KEY (req_type_id)
        REFERENCES requirement_types(req_type_id)
);

CREATE TABLE applications (
    application_id  INT IDENTITY(1,1) PRIMARY KEY,
    applicant_id    INT,
    vacancy_id      INT,
    status          NVARCHAR(30)
                      CHECK (status IN (
                        'draft','submitted','under_review',
                        'screened','interview_scheduled',
                        'interviewed','accepted','rejected'))
                      DEFAULT 'draft',
    submitted_at    DATETIME,
    last_updated    DATETIME DEFAULT GETDATE(),
    CONSTRAINT no_duplicate UNIQUE (applicant_id, vacancy_id),
    FOREIGN KEY (applicant_id)
        REFERENCES applicants(applicant_id),
    FOREIGN KEY (vacancy_id)
        REFERENCES job_vacancies(vacancy_id)
);

CREATE TABLE applicant_documents (
    doc_id        INT IDENTITY(1,1) PRIMARY KEY,
    applicant_id  INT,
    req_type_id   INT,
    file_path     NVARCHAR(500),
    remarks       NVARCHAR(MAX),
    status        NVARCHAR(10)
                    CHECK (status IN ('submitted','missing'))
                    DEFAULT 'missing',
    uploaded_at   DATETIME,
    FOREIGN KEY (applicant_id)
        REFERENCES applicants(applicant_id),
    FOREIGN KEY (req_type_id)
        REFERENCES requirement_types(req_type_id)
);

CREATE TABLE screening_results (
    screening_id    INT IDENTITY(1,1) PRIMARY KEY,
    application_id  INT UNIQUE,
    reviewed_by     INT,
    result          NVARCHAR(15)
                      CHECK (result IN
                        ('qualified','not_qualified')),
    remarks         NVARCHAR(MAX),
    reviewed_at     DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (application_id)
        REFERENCES applications(application_id),
    FOREIGN KEY (reviewed_by)
        REFERENCES users(user_id)
);

CREATE TABLE interview_schedules (
    schedule_id        INT IDENTITY(1,1) PRIMARY KEY,
    application_id     INT,
    interviewer_id     INT,
    interview_type_id  INT,
    scheduled_date     DATE,
    scheduled_time     TIME,
    location           NVARCHAR(255),
    status             NVARCHAR(15)
                         CHECK (status IN (
                           'scheduled','completed','cancelled'))
                         DEFAULT 'scheduled',
    created_by         INT,
    created_at         DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (application_id)
        REFERENCES applications(application_id),
    FOREIGN KEY (interviewer_id)
        REFERENCES users(user_id),
    FOREIGN KEY (interview_type_id)
        REFERENCES interview_types(interview_type_id),
    FOREIGN KEY (created_by)
        REFERENCES users(user_id)
);

CREATE TABLE interview_evaluations (
    evaluation_id   INT IDENTITY(1,1) PRIMARY KEY,
    schedule_id     INT,
    application_id  INT,
    score           DECIMAL(5,2),
    remarks         NVARCHAR(MAX),
    result          NVARCHAR(5)
                      CHECK (result IN ('pass','fail')),
    recommendation  NVARCHAR(MAX),
    evaluated_by    INT,
    evaluated_at    DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (schedule_id)
        REFERENCES interview_schedules(schedule_id),
    FOREIGN KEY (application_id)
        REFERENCES applications(application_id),
    FOREIGN KEY (evaluated_by)
        REFERENCES users(user_id)
);

CREATE TABLE hiring_decisions (
    decision_id     INT IDENTITY(1,1) PRIMARY KEY,
    application_id  INT UNIQUE,
    final_decision  NVARCHAR(10)
                      CHECK (final_decision IN
                        ('accepted','rejected')),
    remarks         NVARCHAR(MAX),
    decided_by      INT,
    decided_at      DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (application_id)
        REFERENCES applications(application_id),
    FOREIGN KEY (decided_by)
        REFERENCES users(user_id)
);

CREATE TABLE status_history (
    history_id      INT IDENTITY(1,1) PRIMARY KEY,
    application_id  INT,
    old_status      NVARCHAR(30),
    new_status      NVARCHAR(30),
    changed_by      INT,
    changed_at      DATETIME DEFAULT GETDATE(),
    remarks         NVARCHAR(MAX),
    FOREIGN KEY (application_id)
        REFERENCES applications(application_id),
    FOREIGN KEY (changed_by)
        REFERENCES users(user_id)
);

CREATE TABLE audit_logs (
    log_id        INT IDENTITY(1,1) PRIMARY KEY,
    user_id       INT,
    action        NVARCHAR(255),
    target        NVARCHAR(100),
    target_id     INT,
    performed_at  DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id)
        REFERENCES users(user_id)
);