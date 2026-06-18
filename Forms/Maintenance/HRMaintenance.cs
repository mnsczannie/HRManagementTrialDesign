using System;
using System.Data;
using System.Windows.Forms;

namespace trial_hr_system
{
    public partial class HRMaintenance : Form
    {
        private int selectedApplicationId = 0;
        private string selectedApplicantName = "";
        private int selectedScheduleId = 0;

        public HRMaintenance()
        {
            InitializeComponent();
        }

        private void HRMaintenance_Load(object sender, EventArgs e)
        {
            RefreshDashboardData();
        }

        private void RefreshDashboardData()
        {
            // Load stats
            var stats = SystemHelpers.GetDashboardStats();
            lblMetricApplicants.Text = $"Profiles: {stats["TotalApplicants"]}";
            lblMetricPending.Text = $"Pending: {stats["PendingApplications"]}";
            lblMetricInterviews.Text = $"Interviews: {stats["ScheduledInterviews"]}";

            // Load primary data tables
            dgvApplications.DataSource = SystemHelpers.GetAllApplications();
        }

        private void dgvApplications_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                var row = dgvApplications.SelectedRows[0];
                selectedApplicationId = Convert.ToInt32(row.Cells["application_id"].Value);
                selectedApplicantName = row.Cells["applicant"].Value.ToString();

                lblTargetInfo.Text = $"Working Target Profile ID: {selectedApplicationId} | Name: {selectedApplicantName}";

                // Load interview schedules linked to this specific applicant
                DataTable dt = SystemHelpers.GetInterviewSchedules(selectedApplicationId);
                dgvSchedules.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    selectedScheduleId = Convert.ToInt32(dt.Rows[0]["schedule_id"]);
                }
                else
                {
                    selectedScheduleId = 0;
                }
            }
        }

        private void dgvSchedules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count > 0)
            {
                selectedScheduleId = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["schedule_id"].Value);
            }
        }

        // ========================================================
        // POPS OPEN INDIVIDUAL FORM WINDOWS INSTEAD OF TABS
        // ========================================================

        private void btnOpenScreening_Click(object sender, EventArgs e)
        {
            if (selectedApplicationId == 0) return;

            using (Screening frm = new Screening(selectedApplicationId, selectedApplicantName))
            {
                if (frm.ShowDialog() == DialogResult.OK) RefreshDashboardData();
            }
        }

        private void btnOpenScheduling_Click(object sender, EventArgs e)
        {
            if (selectedApplicationId == 0) return;

            using (InterviewSchedule frm = new InterviewSchedule(selectedApplicationId, selectedApplicantName))
            {
                if (frm.ShowDialog() == DialogResult.OK) RefreshDashboardData();
            }
        }

        private void btnOpenEvaluation_Click(object sender, EventArgs e)
        {
            if (selectedApplicationId == 0 || selectedScheduleId == 0)
            {
                MessageBox.Show("Please select an active interview row below to evaluate.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (InterviewEvaluation frm = new InterviewEvaluation(selectedApplicationId, selectedScheduleId, selectedApplicantName))
            {
                if (frm.ShowDialog() == DialogResult.OK) RefreshDashboardData();
            }
        }

        private void btnOpenHiring_Click(object sender, EventArgs e)
        {
            if (selectedApplicationId == 0) return;

            using (HiringDecisions frm = new HiringDecisions(selectedApplicationId, selectedApplicantName))
            {
                if (frm.ShowDialog() == DialogResult.OK) RefreshDashboardData();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SystemHelpers.Logout();
            HRLogin login = new HRLogin();
            login.Show();
            this.Close();
        }
    }
}