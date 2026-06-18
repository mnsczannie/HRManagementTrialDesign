using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system.Forms.Applicant
{
    public partial class JobVacancies : Form
    {
        public JobVacancies()
        {
            InitializeComponent();
        }
        private void JobVacancies_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
            LoadVacancies();
        }

        private void LoadVacancies()
        {
            var dt = SystemHelpers.GetOpenVacancies();
            dgvVacancies.DataSource = dt;
            dgvVacancies.ReadOnly = true;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
            { MessageBox.Show("Select a vacancy first.", "Apply"); return; }

            int vacancyId = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);

            // Check for duplicate (enforced by DB UNIQUE constraint too)
            var existing = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);
            foreach (DataRow row in existing.Rows)
            {
                if (Convert.ToInt32(row["vacancy_id"]) == vacancyId)
                {
                    MessageBox.Show(
                        "You have already applied for this position.\n" +
                        "Duplicate applications are not allowed.",
                        "Duplicate Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var confirm = MessageBox.Show("Submit your application for this position?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool ok = SystemHelpers.SubmitApplication(vacancyId);
                if (ok)
                {
                    // Auto-log submitted documents as missing for this vacancy
                    SystemHelpers.InitializeMissingDocuments(SystemHelpers.CurrentApplicantId, vacancyId);
                    SystemHelpers.LogAction("SUBMIT_APPLICATION", "applications", vacancyId);
                    MessageBox.Show("Application submitted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVacancies();
                }
            }
            catch (Exception ex)
            {
                // Catch duplicate constraint from SQL
                if (ex.Message.Contains("no_duplicate") || ex.Message.Contains("UNIQUE"))
                    MessageBox.Show("You have already applied for this position.", "Duplicate");
                else
                    MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyApplication dash = new MyApplication();
            dash.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplicationStatus dash = new ApplicationStatus();
            dash.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyProfile dash = new MyProfile();
            dash.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyDocuments dash = new MyDocuments();
            dash.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}
