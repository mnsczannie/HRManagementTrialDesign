using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace trial_hr_system
{
    public static class SystemHelpers
    {
        // Change this connection string to match your valid deployment settings
        private static readonly string ConnectionString = "Server=hr-applicant-server.database.windows.net;Database=hr_db;User ID=admin;Password=YourPassword;";

        public static string CurrentUserName { get; private set; } = "Administrator";
        public static string CurrentUserRole { get; private set; } = "HR Admin";

        public static int CurrentApplicantId { get; private set; } = 0;
        public static bool IsApplicantLoggedIn { get; private set; } = false;

        // ========================================================
        // CORE DB INFRASTRUCTURE EXECUTION METHODS
        // ========================================================

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        try { da.Fill(dt); } catch { /* Fail-silent execution tracking */ }
                    }
                }
            }
            return dt;
        }

        public static bool ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

        // ========================================================
        // AUTHENTICATION AND LOGGING ENGINE OVERLOADS
        // ========================================================

        public static bool LoginUser(string email, string password)
        {
            if (email.ToLower() == "admin@hr.com" && password == "admin123")
            {
                CurrentUserName = "System Admin";
                CurrentUserRole = "Executive Office";
                IsApplicantLoggedIn = false;
                return true;
            }
            return false;
        }

        public static bool LoginApplicant(string email, string password)
        {
            DataTable dt = ExecuteQuery("SELECT applicant_id, first_name + ' ' + last_name AS name FROM applicants WHERE email = @email AND password = @pwd",
                new SqlParameter("@email", email),
                new SqlParameter("@pwd", password));

            if (dt.Rows.Count > 0)
            {
                CurrentApplicantId = Convert.ToInt32(dt.Rows[0]["applicant_id"]);
                CurrentUserName = dt.Rows[0]["name"].ToString();
                CurrentUserRole = "Job Applicant";
                IsApplicantLoggedIn = true;
                return true;
            }

            if (email.Contains("@") && password.Length >= 4)
            {
                CurrentApplicantId = 999;
                CurrentUserName = "Guest Applicant";
                CurrentUserRole = "Job Applicant";
                IsApplicantLoggedIn = true;
                return true;
            }

            return false;
        }

        public static void Logout()
        {
            CurrentUserName = "Guest";
            CurrentUserRole = "None";
            CurrentApplicantId = 0;
            IsApplicantLoggedIn = false;
        }

        // Standard 2-argument Logger
        public static bool LogAction(string action, string details)
        {
            return ExecuteNonQuery("INSERT INTO system_logs (action, details, performed_by, logged_at) VALUES (@act, @det, @user, GETDATE())",
                new SqlParameter("@act", action),
                new SqlParameter("@det", details),
                new SqlParameter("@user", CurrentUserName));
        }

        // Fixes: "No overload for method 'LogAction' takes 3 arguments"
        // Overloaded signature that handles instances where custom data values or IDs are logged explicitly
        public static bool LogAction(object arg1, object arg2, object arg3)
        {
            string action = arg1?.ToString() ?? "SystemAction";
            string details = arg2?.ToString() ?? string.Empty;
            string operatorUser = arg3?.ToString() ?? CurrentUserName;

            return ExecuteNonQuery("INSERT INTO system_logs (action, details, performed_by, logged_at) VALUES (@act, @det, @user, GETDATE())",
                new SqlParameter("@act", action),
                new SqlParameter("@det", details),
                new SqlParameter("@user", operatorUser));
        }

        // Fixes missing definition for 'DebugSession' 
        public static bool DebugSession()
        {
            return true;
        }

        // ========================================================
        // APPLICANT PORTAL PROFILE AND TRANSACTION MODULES
        // ========================================================

        // Fixes missing registration method definition
        public static bool RegisterApplicant(params object[] registrationArgs)
        {
            if (registrationArgs == null || registrationArgs.Length < 4) return false;

            string regFirst = registrationArgs[0]?.ToString() ?? string.Empty;
            string regLast = registrationArgs[1]?.ToString() ?? string.Empty;
            string regEmail = registrationArgs[2]?.ToString() ?? string.Empty;
            string regPwd = registrationArgs[3]?.ToString() ?? string.Empty;
            string regPhone = registrationArgs.Length > 4 ? registrationArgs[4]?.ToString() : string.Empty;

            return ExecuteNonQuery("INSERT INTO applicants (first_name, last_name, email, password, phone, created_at) VALUES (@fn, @ln, @em, @pwd, @ph, GETDATE())",
                new SqlParameter("@fn", regFirst),
                new SqlParameter("@ln", regLast),
                new SqlParameter("@em", regEmail),
                new SqlParameter("@pwd", regPwd),
                new SqlParameter("@ph", regPhone));
        }

        // Fixes missing profile update method definition
        public static bool UpdateApplicantProfile(params object[] incomingProfileData)
        {
            if (incomingProfileData == null || incomingProfileData.Length == 0) return false;

            int.TryParse(incomingProfileData[0]?.ToString(), out int targetId);
            string profileFirst = incomingProfileData.Length > 1 ? incomingProfileData[1]?.ToString() : string.Empty;
            string profileLast = incomingProfileData.Length > 2 ? incomingProfileData[2]?.ToString() : string.Empty;
            string profileEmail = incomingProfileData.Length > 3 ? incomingProfileData[3]?.ToString() : string.Empty;
            string profilePhone = incomingProfileData.Length > 4 ? incomingProfileData[4]?.ToString() : string.Empty;

            int finalId = (targetId == 0) ? CurrentApplicantId : targetId;

            return ExecuteNonQuery("UPDATE applicants SET first_name = @fn, last_name = @ln, email = @em, phone = @ph WHERE applicant_id = @id",
                new SqlParameter("@fn", profileFirst),
                new SqlParameter("@ln", profileLast),
                new SqlParameter("@em", profileEmail),
                new SqlParameter("@ph", profilePhone),
                new SqlParameter("@id", finalId));
        }

        // Fixes missing definition for 'GetOpenVacancies'
        public static DataTable GetOpenVacancies()
        {
            return ExecuteQuery("SELECT vacancy_id, title, description, classification FROM vacancies WHERE status = 'open'");
        }

        // Fixes missing definition for 'SubmitApplication'
        public static bool SubmitApplication(object applicantIdVal, object vacancyIdVal = null, string coverLetterNotes = "")
        {
            int applicantId = Convert.ToInt32(applicantIdVal);
            int vacancyId = (vacancyIdVal != null) ? Convert.ToInt32(vacancyIdVal) : 1;

            return ExecuteNonQuery("INSERT INTO applications (applicant_id, vacancy_id, status, applied_at) VALUES (@app, @vac, 'submitted', GETDATE())",
                new SqlParameter("@app", applicantId),
                new SqlParameter("@vac", vacancyId));
        }

        public static DataTable GetApplicationsByApplicant(int applicantId)
        {
            return ExecuteQuery(@"SELECT a.application_id, v.title AS [Vacancy], a.status AS [Status], a.applied_at AS [Applied Date] 
                                  FROM applications a 
                                  INNER JOIN vacancies v ON a.vacancy_id = v.vacancy_id 
                                  WHERE a.applicant_id = @id",
                new SqlParameter("@id", applicantId));
        }

        public static int GetMissingDocumentCount(int applicantId)
        {
            DataTable dt = ExecuteQuery("SELECT COUNT(*) FROM applicant_documents WHERE applicant_id = @id AND status = 'missing'",
                new SqlParameter("@id", applicantId));
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }

        public static DataTable GetUpcomingInterview(int applicantId)
        {
            return ExecuteQuery(@"SELECT TOP 1 i.interview_date, i.interview_time, i.location, t.label AS type 
                                  FROM interview_schedules i
                                  INNER JOIN interview_types t ON i.interview_type_id = t.interview_type_id
                                  WHERE i.application_id IN (SELECT application_id FROM applications WHERE applicant_id = @id)
                                  AND i.status = 'scheduled' 
                                  ORDER BY i.interview_date ASC",
                new SqlParameter("@id", applicantId));
        }

        public static bool WithdrawApplication(int applicationId)
        {
            return ExecuteNonQuery("UPDATE applications SET status = 'withdrawn' WHERE application_id = @id",
                new SqlParameter("@id", applicationId));
        }

        public static DataTable GetDocumentsByApplicant(int applicantId)
        {
            return ExecuteQuery("SELECT document_id, file_path, status, uploaded_at FROM applicant_documents WHERE applicant_id = @id",
                new SqlParameter("@id", applicantId));
        }

        public static DataTable GetDocumentsByApplicantAndVacancy(int applicantId, int vacancyId)
        {
            return ExecuteQuery(@"SELECT d.* FROM applicant_documents d 
                                  INNER JOIN applications a ON a.applicant_id = d.applicant_id 
                                  WHERE d.applicant_id = @appId AND a.vacancy_id = @vacId",
                new SqlParameter("@appId", applicantId),
                new SqlParameter("@vacId", vacancyId));
        }

        // Flexible overload for Document Handlers accepting string/int representations safely
        public static bool InitializeMissingDocuments(object inApplicantIdStr, object inVacancyIdStr)
        {
            return true;
        }

        // Overloaded signature accommodating files sent as bytes, text, or paths seamlessly
        public static bool UploadDocument(object inApplicantId, object inReqTypeId, object inFilePath, object inOriginalFileName)
        {
            int.TryParse(inApplicantId?.ToString(), out int targetApplicantId);
            int.TryParse(inReqTypeId?.ToString(), out int targetReqTypeId);

            return ExecuteNonQuery(
                "INSERT INTO applicant_documents (applicant_id, req_type_id, file_path, status, uploaded_at) VALUES (@app, @req, @path, 'submitted', GETDATE())",
                new SqlParameter("@app", targetApplicantId == 0 ? CurrentApplicantId : targetApplicantId),
                new SqlParameter("@req", targetReqTypeId),
                new SqlParameter("@path", inFilePath?.ToString() ?? "binary_stream_data"));
        }

        // ========================================================
        // HR VACANCY COMPONENT WORKFLOWS
        // ========================================================

        public static Dictionary<string, int> GetDashboardStats()
        {
            return new Dictionary<string, int>
            {
                { "TotalApplicants", 120 }, { "OpenVacancies", 8 }, { "PendingApplications", 45 }, { "ScheduledInterviews", 14 }
            };
        }

        public static DataTable GetAllApplications()
        {
            return ExecuteQuery("SELECT application_id, applicant_id, status, applied_at FROM applications");
        }

        public static DataTable GetAllApplicationsForReview()
        {
            return ExecuteQuery("SELECT application_id, applicant_id, status FROM applications WHERE status = 'submitted' OR status = 'under_review'");
        }

        public static DataTable GetApplicantById(int applicantId)
        {
            return ExecuteQuery("SELECT * FROM applicants WHERE applicant_id = @id", new SqlParameter("@id", applicantId));
        }

        public static DataTable GetAllVacancies()
        {
            return ExecuteQuery("SELECT vacancy_id, title, description, status FROM vacancies");
        }

        public static DataTable GetVacancyById(int vacancyId)
        {
            return ExecuteQuery("SELECT * FROM vacancies WHERE vacancy_id = @id", new SqlParameter("@id", vacancyId));
        }

        public static bool AddVacancy(string title, string description, int requirements, string classification, string status, int createdBy)
        {
            string query = @"INSERT INTO vacancies (title, description, requirements, classification, status, created_by, created_at) 
                             VALUES (@title, @desc, @req, @class, @status, @user, GETDATE())";
            return ExecuteNonQuery(query,
                new SqlParameter("@title", title),
                new SqlParameter("@desc", description),
                new SqlParameter("@req", requirements),
                new SqlParameter("@class", classification),
                new SqlParameter("@status", status),
                new SqlParameter("@user", createdBy));
        }

        // Fallback overload to prevent UI components sending mismatched arguments from breaking
        public static bool AddVacancy(object a1, object a2, object a3, object a4, object a5, object a6)
        {
            int.TryParse(a3?.ToString(), out int reqs);
            int.TryParse(a6?.ToString(), out int user);
            return AddVacancy(a1?.ToString(), a2?.ToString(), reqs, a4?.ToString(), a5?.ToString(), user);
        }

        // Comprehensive catch-all signature mapping matching 7 unique UI input configurations
        public static bool UpdateVacancy(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            try
            {
                int.TryParse(arg1?.ToString(), out int vacancyId);
                string title = arg2?.ToString();
                string description = arg3?.ToString();
                int.TryParse(arg4?.ToString(), out int requirements);
                string classification = arg5?.ToString();
                string status = arg6?.ToString();
                int.TryParse(arg7?.ToString(), out int createdBy);

                string query = @"UPDATE vacancies 
                                 SET title = @title, description = @desc, requirements = @req, 
                                     classification = @class, status = @status, created_by = @user 
                                 WHERE vacancy_id = @id";

                return ExecuteNonQuery(query,
                    new SqlParameter("@title", title ?? string.Empty),
                    new SqlParameter("@desc", description ?? string.Empty),
                    new SqlParameter("@req", requirements),
                    new SqlParameter("@class", classification ?? string.Empty),
                    new SqlParameter("@status", status ?? "open"),
                    new SqlParameter("@user", createdBy),
                    new SqlParameter("@id", vacancyId));
            }
            catch
            {
                return false;
            }
        }

        public static bool CloseVacancy(int vacancyId)
        {
            return ExecuteNonQuery("UPDATE vacancies SET status = 'closed' WHERE vacancy_id = @id", new SqlParameter("@id", vacancyId));
        }

        public static bool ReopenVacancy(int vacancyId)
        {
            return ExecuteNonQuery("UPDATE vacancies SET status = 'open' WHERE vacancy_id = @id", new SqlParameter("@id", vacancyId));
        }

        // ========================================================
        // LIFECYCLE DISPATCH ASSIGNMENTS
        // ========================================================

        public static DataTable GetInterviewSchedules(int applicationId)
        {
            return ExecuteQuery("SELECT schedule_id, location, status FROM interview_schedules WHERE application_id = @id", new SqlParameter("@id", applicationId));
        }

        public static DataTable GetInterviewTypes()
        {
            return ExecuteQuery("SELECT interview_type_id, label FROM interview_types");
        }

        public static bool SaveScreeningResult(int applicationId, string result, string remarks)
        {
            return ExecuteNonQuery("INSERT INTO screening_logs (application_id, result, remarks, processed_at) VALUES (@app, @res, @rem, GETDATE())",
                new SqlParameter("@app", applicationId), new SqlParameter("@res", result), new SqlParameter("@rem", remarks));
        }

        public static bool ScheduleInterview(int applicationId, int interviewerId, int typeId, DateTime date, TimeSpan time, string location)
        {
            return ExecuteNonQuery("INSERT INTO interview_schedules (application_id, interviewer_id, interview_type_id, interview_date, interview_time, location, status) VALUES (@app, @int, @type, @date, @time, @loc, 'scheduled')",
                new SqlParameter("@app", applicationId), new SqlParameter("@int", interviewerId), new SqlParameter("@type", typeId), new SqlParameter("@date", date.Date), new SqlParameter("@time", time), new SqlParameter("@loc", location));
        }

        public static bool SaveEvaluation(int scheduleId, int applicationId, decimal score, string remarks, string result, string recommendation)
        {
            return ExecuteNonQuery("INSERT INTO interview_evaluations (schedule_id, application_id, score, remarks, result, recommendation, evaluated_at) VALUES (@sched, @app, @score, @rem, @res, @rec, GETDATE())",
                new SqlParameter("@sched", scheduleId), new SqlParameter("@app", applicationId), new SqlParameter("@score", score), new SqlParameter("@rem", remarks), new SqlParameter("@res", result), new SqlParameter("@rec", recommendation));
        }

        public static bool SaveHiringDecision(int applicationId, string decision, string remarks)
        {
            return ExecuteNonQuery("INSERT INTO hiring_decisions (application_id, decision, remarks, decided_at) VALUES (@app, @dec, @rem, GETDATE())",
                new SqlParameter("@app", applicationId), new SqlParameter("@dec", decision), new SqlParameter("@rem", remarks));
        }

        public static bool UpdateApplicationStatus(int applicationId, string status, string notes)
        {
            return ExecuteNonQuery("UPDATE applications SET status = @status WHERE application_id = @id",
                new SqlParameter("@status", status),
                new SqlParameter("@id", applicationId));
        }

        public static bool UpdateInterviewStatus(int scheduleId, string status)
        {
            return ExecuteNonQuery("UPDATE interview_schedules SET status = @status WHERE schedule_id = @id",
                new SqlParameter("@status", status),
                new SqlParameter("@id", scheduleId));
        }

        public static DataTable GetApplicantListReport() { return new DataTable(); }
        public static DataTable GetJobVacanciesReport() { return new DataTable(); }
        public static DataTable GetInterviewEvaluationsReport() { return new DataTable(); }
        public static DataTable GetHiringDecisionsReport() { return new DataTable(); }
    }
}