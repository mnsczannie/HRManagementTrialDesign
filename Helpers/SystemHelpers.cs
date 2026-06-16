using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace trial_hr_system
{
    public static class SystemHelpers
    {
        // =============================================
        // CONNECTION STRING
        // =============================================
        private static readonly string ConnectionString =
            "Server=tcp:hr-applicant-server.database.windows.net,1433;" +
            "Initial Catalog=hr_applicant_db;" +
            "User ID=hradmin;" +
            "Password=Kenmapuddingheadluckey24;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        // =============================================
        // SESSION (set after login)
        // =============================================
        public static int CurrentUserId { get; set; }
        public static string CurrentUserName { get; set; }
        public static string CurrentUserRole { get; set; }

        public static int CurrentApplicantId { get; set; }
        public static string CurrentApplicantName { get; set; }

        // =============================================
        // AUTH — USERS (HR Staff / Admin / Manager)
        // =============================================

        /// <summary>Login for HR users. Returns true and sets session if valid.</summary>
        public static bool LoginUser(string email, string password)
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query = "SELECT user_id, full_name, role, password FROM users WHERE email = @email AND is_active = 1";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashed = reader["password"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(password, hashed))
                            {
                                CurrentUserId = Convert.ToInt32(reader["user_id"]);
                                CurrentUserName = reader["full_name"].ToString();
                                CurrentUserRole = reader["role"].ToString();
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>Login for Applicants. Returns true and sets session if valid.</summary>
        public static bool LoginApplicant(string email, string password)
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query = "SELECT applicant_id, full_name, password FROM applicants WHERE email = @email AND is_active = 1";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashed = reader["password"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(password, hashed))
                            {
                                CurrentApplicantId = Convert.ToInt32(reader["applicant_id"]);
                                CurrentApplicantName = reader["full_name"].ToString();
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static void Logout()
        {
            CurrentUserId = 0;
            CurrentUserName = null;
            CurrentUserRole = null;
            CurrentApplicantId = 0;
            CurrentApplicantName = null;
        }

        // =============================================
        // USERS
        // =============================================

        public static bool RegisterUser(string fullName, string email, string password, string role)
        {
            using (var con = GetConnection())
            {
                con.Open();
                string hashed = BCrypt.Net.BCrypt.HashPassword(password);
                string query = "INSERT INTO users (full_name, email, password, role) VALUES (@name, @email, @password, @role)";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashed);
                    cmd.Parameters.AddWithValue("@role", role);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            return ExecuteQuery("SELECT user_id, full_name, email, role, is_active, created_at FROM users");
        }

        public static bool DeactivateUser(int userId)
        {
            return ExecuteNonQuery("UPDATE users SET is_active = 0 WHERE user_id = @id",
                new SqlParameter("@id", userId));
        }

        // =============================================
        // APPLICANTS
        // =============================================

        public static bool RegisterApplicant(string fullName, string email, string password, string phone,
            string address, DateTime birthdate, string gender, string city, string province, string zipCode,
            string school, string degree, string yearGrad, string skills, string company, string position,
            string duration)
        {
            using (var con = GetConnection())
            {
                con.Open();
                string hashed = BCrypt.Net.BCrypt.HashPassword(password);
                string query = @"INSERT INTO applicants 
                    (full_name, email, password, phone, address, birthdate, gender, city, province, zip_code,
                     school, degree, year_grad, skills, company, position, duration)
                    VALUES (@name, @email, @password, @phone, @address, @birthdate, @gender, @city, @province,
                            @zip, @school, @degree, @yearGrad, @skills, @company, @position, @duration)";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashed);
                    cmd.Parameters.AddWithValue("@phone", (object)phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@address", (object)address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@gender", (object)gender ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@city", (object)city ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@province", (object)province ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@zip", (object)zipCode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@school", (object)school ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@degree", (object)degree ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@yearGrad", (object)yearGrad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@skills", (object)skills ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@company", (object)company ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@position", (object)position ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@duration", (object)duration ?? DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static DataTable GetApplicantById(int applicantId)
        {
            return ExecuteQuery("SELECT * FROM applicants WHERE applicant_id = @id",
                new SqlParameter("@id", applicantId));
        }

        public static DataTable GetAllApplicants()
        {
            return ExecuteQuery("SELECT applicant_id, full_name, email, phone, city, is_active, created_at FROM applicants");
        }

        // =============================================
        // DEPARTMENTS & POSITIONS
        // =============================================

        public static DataTable GetAllDepartments()
        {
            return ExecuteQuery("SELECT * FROM departments");
        }

        public static bool AddDepartment(string name)
        {
            return ExecuteNonQuery("INSERT INTO departments (name) VALUES (@name)",
                new SqlParameter("@name", name));
        }

        public static DataTable GetAllPositions()
        {
            return ExecuteQuery(@"SELECT p.position_id, p.title, d.name AS department
                                  FROM positions p
                                  JOIN departments d ON p.department_id = d.department_id");
        }

        public static DataTable GetPositionsByDepartment(int departmentId)
        {
            return ExecuteQuery("SELECT * FROM positions WHERE department_id = @deptId",
                new SqlParameter("@deptId", departmentId));
        }

        public static bool AddPosition(string title, int departmentId)
        {
            return ExecuteNonQuery("INSERT INTO positions (title, department_id) VALUES (@title, @deptId)",
                new SqlParameter("@title", title),
                new SqlParameter("@deptId", departmentId));
        }

        // =============================================
        // EMPLOYMENT TYPES
        // =============================================

        public static DataTable GetEmploymentTypes()
        {
            return ExecuteQuery("SELECT * FROM employment_types");
        }

        // =============================================
        // JOB VACANCIES
        // =============================================

        public static DataTable GetOpenVacancies()
        {
            return ExecuteQuery(@"SELECT v.vacancy_id, p.title AS position, d.name AS department,
                                         e.label AS employment_type, v.slots, v.status, v.posted_at
                                  FROM job_vacancies v
                                  JOIN positions p ON v.position_id = p.position_id
                                  JOIN departments d ON v.department_id = d.department_id
                                  JOIN employment_types e ON v.employment_type_id = e.type_id
                                  WHERE v.status = 'open'");
        }

        public static DataTable GetAllVacancies()
        {
            return ExecuteQuery(@"SELECT v.vacancy_id, p.title AS position, d.name AS department,
                                         e.label AS employment_type, v.slots, v.status, v.posted_at
                                  FROM job_vacancies v
                                  JOIN positions p ON v.position_id = p.position_id
                                  JOIN departments d ON v.department_id = d.department_id
                                  JOIN employment_types e ON v.employment_type_id = e.type_id");
        }

        public static bool AddVacancy(int positionId, int departmentId, int employmentTypeId,
            string description, string qualifications, int slots)
        {
            return ExecuteNonQuery(@"INSERT INTO job_vacancies 
                (position_id, department_id, employment_type_id, description, qualifications, slots, posted_by)
                VALUES (@posId, @deptId, @empTypeId, @desc, @quals, @slots, @postedBy)",
                new SqlParameter("@posId", positionId),
                new SqlParameter("@deptId", departmentId),
                new SqlParameter("@empTypeId", employmentTypeId),
                new SqlParameter("@desc", description),
                new SqlParameter("@quals", qualifications),
                new SqlParameter("@slots", slots),
                new SqlParameter("@postedBy", CurrentUserId));
        }

        public static bool CloseVacancy(int vacancyId)
        {
            return ExecuteNonQuery("UPDATE job_vacancies SET status = 'closed' WHERE vacancy_id = @id",
                new SqlParameter("@id", vacancyId));
        }

        // =============================================
        // APPLICATIONS
        // =============================================

        public static bool SubmitApplication(int vacancyId)
        {
            return ExecuteNonQuery(@"INSERT INTO applications (applicant_id, vacancy_id, status, submitted_at)
                VALUES (@appId, @vacId, 'submitted', GETDATE())",
                new SqlParameter("@appId", CurrentApplicantId),
                new SqlParameter("@vacId", vacancyId));
        }

        public static DataTable GetApplicationsByApplicant(int applicantId)
        {
            return ExecuteQuery(@"SELECT a.application_id, v.vacancy_id, p.title AS position,
                                         d.name AS department, a.status, a.submitted_at
                                  FROM applications a
                                  JOIN job_vacancies v ON a.vacancy_id = v.vacancy_id
                                  JOIN positions p ON v.position_id = p.position_id
                                  JOIN departments d ON v.department_id = d.department_id
                                  WHERE a.applicant_id = @id",
                new SqlParameter("@id", applicantId));
        }

        public static DataTable GetAllApplications()
        {
            return ExecuteQuery(@"SELECT a.application_id, ap.full_name AS applicant,
                                         p.title AS position, d.name AS department,
                                         a.status, a.submitted_at
                                  FROM applications a
                                  JOIN applicants ap ON a.applicant_id = ap.applicant_id
                                  JOIN job_vacancies v ON a.vacancy_id = v.vacancy_id
                                  JOIN positions p ON v.position_id = p.position_id
                                  JOIN departments d ON v.department_id = d.department_id");
        }

        public static bool UpdateApplicationStatus(int applicationId, string newStatus, string remarks = null)
        {
            // Log old status first
            var old = ExecuteQuery("SELECT status FROM applications WHERE application_id = @id",
                new SqlParameter("@id", applicationId));
            string oldStatus = old.Rows.Count > 0 ? old.Rows[0]["status"].ToString() : "";

            ExecuteNonQuery(@"INSERT INTO status_history (application_id, old_status, new_status, changed_by, remarks)
                VALUES (@appId, @old, @new, @changedBy, @remarks)",
                new SqlParameter("@appId", applicationId),
                new SqlParameter("@old", oldStatus),
                new SqlParameter("@new", newStatus),
                new SqlParameter("@changedBy", CurrentUserId),
                new SqlParameter("@remarks", (object)remarks ?? DBNull.Value));

            return ExecuteNonQuery("UPDATE applications SET status = @status, last_updated = GETDATE() WHERE application_id = @id",
                new SqlParameter("@status", newStatus),
                new SqlParameter("@id", applicationId));
        }

        // =============================================
        // SCREENING
        // =============================================

        public static bool SaveScreeningResult(int applicationId, string result, string remarks)
        {
            return ExecuteNonQuery(@"INSERT INTO screening_results (application_id, reviewed_by, result, remarks)
                VALUES (@appId, @reviewedBy, @result, @remarks)",
                new SqlParameter("@appId", applicationId),
                new SqlParameter("@reviewedBy", CurrentUserId),
                new SqlParameter("@result", result),
                new SqlParameter("@remarks", (object)remarks ?? DBNull.Value));
        }

        public static DataTable GetScreeningResult(int applicationId)
        {
            return ExecuteQuery("SELECT * FROM screening_results WHERE application_id = @id",
                new SqlParameter("@id", applicationId));
        }

        // =============================================
        // INTERVIEW SCHEDULES
        // =============================================

        public static DataTable GetInterviewTypes()
        {
            return ExecuteQuery("SELECT * FROM interview_types");
        }

        public static bool ScheduleInterview(int applicationId, int interviewerId, int interviewTypeId,
            DateTime scheduledDate, TimeSpan scheduledTime, string location)
        {
            return ExecuteNonQuery(@"INSERT INTO interview_schedules 
                (application_id, interviewer_id, interview_type_id, scheduled_date, scheduled_time, location, created_by)
                VALUES (@appId, @interviewer, @typeId, @date, @time, @location, @createdBy)",
                new SqlParameter("@appId", applicationId),
                new SqlParameter("@interviewer", interviewerId),
                new SqlParameter("@typeId", interviewTypeId),
                new SqlParameter("@date", scheduledDate.Date),
                new SqlParameter("@time", scheduledTime),
                new SqlParameter("@location", (object)location ?? DBNull.Value),
                new SqlParameter("@createdBy", CurrentUserId));
        }

        public static DataTable GetInterviewSchedules(int applicationId)
        {
            return ExecuteQuery(@"SELECT s.schedule_id, u.full_name AS interviewer,
                                         t.label AS interview_type, s.scheduled_date,
                                         s.scheduled_time, s.location, s.status
                                  FROM interview_schedules s
                                  JOIN users u ON s.interviewer_id = u.user_id
                                  JOIN interview_types t ON s.interview_type_id = t.interview_type_id
                                  WHERE s.application_id = @id",
                new SqlParameter("@id", applicationId));
        }

        // =============================================
        // INTERVIEW EVALUATIONS
        // =============================================

        public static bool SaveEvaluation(int scheduleId, int applicationId, decimal score,
            string remarks, string result, string recommendation)
        {
            return ExecuteNonQuery(@"INSERT INTO interview_evaluations 
                (schedule_id, application_id, score, remarks, result, recommendation, evaluated_by)
                VALUES (@schedId, @appId, @score, @remarks, @result, @rec, @evalBy)",
                new SqlParameter("@schedId", scheduleId),
                new SqlParameter("@appId", applicationId),
                new SqlParameter("@score", score),
                new SqlParameter("@remarks", (object)remarks ?? DBNull.Value),
                new SqlParameter("@result", result),
                new SqlParameter("@rec", (object)recommendation ?? DBNull.Value),
                new SqlParameter("@evalBy", CurrentUserId));
        }

        // =============================================
        // HIRING DECISIONS
        // =============================================

        public static bool SaveHiringDecision(int applicationId, string decision, string remarks)
        {
            return ExecuteNonQuery(@"INSERT INTO hiring_decisions (application_id, final_decision, remarks, decided_by)
                VALUES (@appId, @decision, @remarks, @decidedBy)",
                new SqlParameter("@appId", applicationId),
                new SqlParameter("@decision", decision),
                new SqlParameter("@remarks", (object)remarks ?? DBNull.Value),
                new SqlParameter("@decidedBy", CurrentUserId));
        }

        public static DataTable GetHiringDecision(int applicationId)
        {
            return ExecuteQuery("SELECT * FROM hiring_decisions WHERE application_id = @id",
                new SqlParameter("@id", applicationId));
        }

        // =============================================
        // AUDIT LOG
        // =============================================

        public static void LogAction(string action, string target, int targetId)
        {
            ExecuteNonQuery(@"INSERT INTO audit_logs (user_id, action, target, target_id)
                VALUES (@userId, @action, @target, @targetId)",
                new SqlParameter("@userId", CurrentUserId),
                new SqlParameter("@action", action),
                new SqlParameter("@target", target),
                new SqlParameter("@targetId", targetId));
        }

        public static DataTable GetAuditLogs()
        {
            return ExecuteQuery(@"SELECT l.log_id, u.full_name AS performed_by, l.action,
                                         l.target, l.target_id, l.performed_at
                                  FROM audit_logs l
                                  JOIN users u ON l.user_id = u.user_id
                                  ORDER BY l.performed_at DESC");
        }

        // =============================================
        // DOCUMENTS
        // =============================================

        public static bool SaveDocument(int applicantId, int reqTypeId, string filePath)
        {
            return ExecuteNonQuery(@"INSERT INTO applicant_documents (applicant_id, req_type_id, file_path, status, uploaded_at)
                VALUES (@appId, @reqType, @path, 'submitted', GETDATE())",
                new SqlParameter("@appId", applicantId),
                new SqlParameter("@reqType", reqTypeId),
                new SqlParameter("@path", filePath));
        }

        public static DataTable GetDocumentsByApplicant(int applicantId)
        {
            return ExecuteQuery(@"SELECT d.doc_id, r.label AS document_type, d.file_path,
                                         d.status, d.uploaded_at
                                  FROM applicant_documents d
                                  JOIN requirement_types r ON d.req_type_id = r.req_type_id
                                  WHERE d.applicant_id = @id",
                new SqlParameter("@id", applicantId));
        }

        // =============================================
        // HELPERS
        // =============================================

        private static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private static bool ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}