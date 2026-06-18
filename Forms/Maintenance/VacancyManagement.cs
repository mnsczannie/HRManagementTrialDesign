using System;
using System.Data;
using System.Windows.Forms;
using trial_hr_system.Forms.HR;

namespace trial_hr_system.Forms.Maintenance
{
    public partial class VacancyManagement : Form
    {
        public VacancyManagement()
        {
            InitializeComponent();
        }

        private void VacancyManagement_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "HR";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadVacancies();
        }

        private void LoadVacancies()
        {
            var dt = SystemHelpers.GetAllVacancies();
            dgvVacancies.DataSource = dt;
            dgvVacancies.ReadOnly = true;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new VacancyForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool ok = SystemHelpers.AddVacancy(
                    form.JobTitle, form.Department, form.Description,
                    form.Qualifications, form.Slots, form.RequiredDocuments);
                if (ok)
                {
                    SystemHelpers.LogAction("ADD_VACANCY", "vacancies", 0);
                    MessageBox.Show("Vacancy added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVacancies();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) { MessageBox.Show("Select a vacancy."); return; }
            int id = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);

            var form = new VacancyForm(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool ok = SystemHelpers.UpdateVacancy(id,
                    form.JobTitle, form.Department, form.Description,
                    form.Qualifications, form.Slots, form.RequiredDocuments);
                if (ok)
                {
                    SystemHelpers.LogAction("EDIT_VACANCY", "vacancies", id);
                    MessageBox.Show("Vacancy updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVacancies();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) { MessageBox.Show("Select a vacancy."); return; }
            int id = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);
            var confirm = MessageBox.Show("Close this vacancy? No new applications will be accepted.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool ok = SystemHelpers.CloseVacancy(id);
            if (ok)
            {
                SystemHelpers.LogAction("CLOSE_VACANCY", "vacancies", id);
                MessageBox.Show("Vacancy closed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVacancies();
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) { MessageBox.Show("Select a vacancy."); return; }
            int id = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);
            bool ok = SystemHelpers.ReopenVacancy(id);
            if (ok)
            {
                SystemHelpers.LogAction("REOPEN_VACANCY", "vacancies", id);
                MessageBox.Show("Vacancy reopened.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVacancies();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e) { new HRDashboard().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new ApplicantReview().Show(); this.Hide(); }
        private void button4_Click(object sender, EventArgs e) { /* Already here */ }
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