-- =============================================
-- HR APPLICANT SYSTEM — SEED DATA
-- Run this once after schema.sql
-- =============================================

INSERT INTO employment_types (label) VALUES
('Full-time'),('Part-time'),('Contract'),('Internship');

INSERT INTO requirement_types (label) VALUES
('Resume'),('Government ID'),
('Transcript of Records'),
('Certificate of Employment'),
('Training Certificates');

INSERT INTO interview_types (label) VALUES
('Face-to-face'),('Online / Video Call'),
('Phone Call'),('Panel Interview');

INSERT INTO assessment_types (label) VALUES
('Written Exam'),('Skills Test'),
('Personality Test'),('Background Check');

-- Default admin account
-- Change password after first login
INSERT INTO users
  (full_name, email, password, role)
VALUES
  ('System Admin','admin@company.com','Admin@1234','admin');
