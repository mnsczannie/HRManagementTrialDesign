using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace trial_hr_system.Forms.Applicant
{
    public partial class ApplicationStatus : Form
    {
        public ApplicationStatus()
        {
            InitializeComponent();
        }

        private void ApplicationStatus_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "APPLICANT";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadApplicationStatus();
        }

        private void LoadApplicationStatus()
        {
            if (SystemHelpers.CurrentApplicantId <= 0) return;

            var dt = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);
            if (dt == null || dt.Rows.Count == 0)
            {
                dgvStatus.DataSource = null;
                return;
            }

            dgvStatus.DataSource = dt;
            dgvStatus.ReadOnly = true;
            dgvStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Color-code rows by status
            foreach (DataGridViewRow row in dgvStatus.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["status"]?.Value?.ToString() ?? "";
                switch (status.ToLower())
                {
                    case "submitted": row.DefaultCellStyle.BackColor = Color.LightYellow; break;
                    case "under_review": row.DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case "accepted": row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "rejected": row.DefaultCellStyle.BackColor = Color.LightCoral; break;
                    case "withdrawn": row.DefaultCellStyle.BackColor = Color.LightGray; break;
                }
            }

            // Missing documents alert
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e) { new Dashboard().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new JobVacancies().Show(); this.Hide(); }
        private void button4_Click(object sender, EventArgs e) { new MyApplication().Show(); this.Hide(); }
        private void button6_Click(object sender, EventArgs e) { new MyProfile().Show(); this.Hide(); }
        private void button7_Click(object sender, EventArgs e) { new MyDocuments().Show(); this.Hide(); }

        private void button9_Click(object sender, EventArgs e)
        {
            SystemHelpers.Logout();
            new LogIn().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MyDocuments().Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}