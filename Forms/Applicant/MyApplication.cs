using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system.Forms.Applicant
{
    public partial class MyApplication : Form
    {
        public MyApplication()
        {
            InitializeComponent();
        }

        private void MyApplication_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "APPLICANT";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadMyApplications();
        }

        private void LoadMyApplications()
        {
            if (SystemHelpers.CurrentApplicantId <= 0) return;

            var dt = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);
            dgvMyApplications.DataSource = dt;
            dgvMyApplications.ReadOnly = true;
            dgvMyApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var missing = SystemHelpers.GetMissingDocumentCount(SystemHelpers.CurrentApplicantId);
            if (missing > 0)
            {
                panel5.Visible = true;
                label2.Text = $"You have {missing} missing document(s). Upload now.";
            }
            else
            {
                panel5.Visible = false;
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (dgvMyApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an application to withdraw.", "Withdraw");
                return;
            }

            string status = dgvMyApplications.SelectedRows[0].Cells["status"]?.Value?.ToString() ?? "";
            if (status != "submitted" && status != "draft")
            {
                MessageBox.Show("You can only withdraw submitted or draft applications.", "Cannot Withdraw",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int appId = Convert.ToInt32(dgvMyApplications.SelectedRows[0].Cells["application_id"].Value);
            var confirm = MessageBox.Show("Are you sure you want to withdraw this application?",
                "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool ok = SystemHelpers.WithdrawApplication(appId);
            if (ok)
            {
                SystemHelpers.LogAction("WITHDRAW_APPLICATION", "applications", appId);
                MessageBox.Show("Application withdrawn.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyApplications();
            }
            else
            {
                MessageBox.Show("Failed to withdraw application.", "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e) { new MyDocuments().Show(); this.Hide(); }
        private void button2_Click(object sender, EventArgs e) { new Dashboard().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new JobVacancies().Show(); this.Hide(); }
        private void button5_Click(object sender, EventArgs e) { new ApplicationStatus().Show(); this.Hide(); }
        private void button6_Click(object sender, EventArgs e) { new MyProfile().Show(); this.Hide(); }
        private void button7_Click(object sender, EventArgs e) { new MyDocuments().Show(); this.Hide(); }

        private void button9_Click(object sender, EventArgs e)
        {
            SystemHelpers.Logout();
            new LogIn().Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}