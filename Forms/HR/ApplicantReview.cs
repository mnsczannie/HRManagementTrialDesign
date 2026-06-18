using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using trial_hr_system.Forms.Maintenance;

namespace trial_hr_system.Forms.HR
{
    public partial class ApplicantReview : Form
    {
        public ApplicantReview()
        {
            InitializeComponent();
        }

        private void ApplicantReview_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "HR";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadApplicants();
        }

        private void LoadApplicants()
        {
            var dt = SystemHelpers.GetAllApplicationsForReview();
            if (dt == null) return;

            dgvApplicants.DataSource = dt;
            dgvApplicants.ReadOnly = true;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in dgvApplicants.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["status"]?.Value?.ToString() ?? "";
                switch (status.ToLower())
                {
                    case "submitted": row.DefaultCellStyle.BackColor = Color.LightYellow; break;
                    case "under_review": row.DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case "accepted": row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "rejected": row.DefaultCellStyle.BackColor = Color.LightCoral; break;
                }
            }
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            { MessageBox.Show("Select an applicant.", "Review"); return; }

            string currentStatus = dgvApplicants.SelectedRows[0].Cells["status"]?.Value?.ToString() ?? "";
            if (currentStatus != "submitted")
            {
                MessageBox.Show("Only submitted applications can be moved to review.", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int appId = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["application_id"].Value);
            bool ok = SystemHelpers.UpdateApplicationStatus(appId, "under_review", "HR review started.");
            if (ok)
            {
                SystemHelpers.LogAction("START_REVIEW", "applications", appId);
                MessageBox.Show("Application moved to Under Review. Applicant profile is now locked.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadApplicants();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdateStatus("accepted", "Applicant accepted.");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateStatus("rejected", txtRemarks.Text.Trim());
        }

        private void UpdateStatus(string newStatus, string remarks)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            { MessageBox.Show("Select an applicant.", "Update"); return; }

            // Role check for final hiring decision
            if ((newStatus == "accepted" || newStatus == "rejected") &&
                SystemHelpers.CurrentUserRole?.ToLower() != "hr_manager" &&
                SystemHelpers.CurrentUserRole?.ToLower() != "admin")
            {
                MessageBox.Show("Only HR Manager or Admin can make final hiring decisions.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int appId = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["application_id"].Value);
            bool ok = SystemHelpers.UpdateApplicationStatus(appId, newStatus, remarks);
            if (ok)
            {
                SystemHelpers.LogAction("UPDATE_STATUS_" + newStatus.ToUpper(), "applications", appId);
                MessageBox.Show($"Status updated to {newStatus}.", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadApplicants();
            }
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            { MessageBox.Show("Select an applicant.", "View"); return; }

            int applicantId = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["applicant_id"].Value);
            var profileForm = new ApplicantProfileView(applicantId);
            profileForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e) { new HRDashboard().Show(); this.Hide(); }
        private void button4_Click(object sender, EventArgs e) { new VacancyManagement().Show(); this.Hide(); }
        private void button5_Click(object sender, EventArgs e) { new Reports().Show(); this.Hide(); }
        private void button6_Click(object sender, EventArgs e) { new HRMaintenance().Show(); this.Hide(); }

        private void button9_Click(object sender, EventArgs e)
        {
            SystemHelpers.Logout();
            new HRLogin().Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}