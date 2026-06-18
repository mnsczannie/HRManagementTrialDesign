using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system.Forms.Applicant
{
    public partial class MyDocuments : Form
    {
        public MyDocuments()
        {
            InitializeComponent();
        }

        private void MyDocuments_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "APPLICANT";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadDocuments();
            LoadApplicationsCombo();
        }

        private void LoadApplicationsCombo()
        {
            if (SystemHelpers.CurrentApplicantId <= 0) return;
            var dt = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);
            cmbApplications.DisplayMember = "job_title";
            cmbApplications.ValueMember = "application_id";
            cmbApplications.DataSource = dt;
        }

        private void LoadDocuments()
        {
            if (SystemHelpers.CurrentApplicantId <= 0) return;

            int vacancyId = 0;
            if (cmbApplications.SelectedValue != null)
                int.TryParse(cmbApplications.SelectedValue.ToString(), out vacancyId);

            DataTable dt = vacancyId > 0
                ? SystemHelpers.GetDocumentsByApplicantAndVacancy(SystemHelpers.CurrentApplicantId, vacancyId)
                : SystemHelpers.GetDocumentsByApplicant(SystemHelpers.CurrentApplicantId);

            dgvDocuments.DataSource = dt;
            dgvDocuments.ReadOnly = true;
            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Color missing vs submitted
            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["status"]?.Value?.ToString() ?? "";
                row.DefaultCellStyle.BackColor = status == "submitted"
                    ? Color.LightGreen : Color.LightCoral;
            }

            // Missing alert
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a document requirement to upload.", "Upload");
                return;
            }

            // Check if application is still editable (not under HR review)
            string appStatus = dgvDocuments.SelectedRows[0].Cells["application_status"]?.Value?.ToString() ?? "";
            if (appStatus != "submitted" && appStatus != "draft" && !string.IsNullOrEmpty(appStatus))
            {
                MessageBox.Show("Documents cannot be uploaded once HR review has started.", "Locked",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requirementId = Convert.ToInt32(dgvDocuments.SelectedRows[0].Cells["requirement_id"].Value);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
                ofd.Title = "Select Document to Upload";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                string fileName = Path.GetFileName(ofd.FileName);
                byte[] fileData = File.ReadAllBytes(ofd.FileName);

                bool ok = SystemHelpers.UploadDocument(SystemHelpers.CurrentApplicantId, requirementId, fileName, fileData);
                if (ok)
                {
                    SystemHelpers.LogAction("UPLOAD_DOCUMENT", "applicant_documents", requirementId);
                    MessageBox.Show("Document uploaded successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDocuments();
                }
                else
                {
                    MessageBox.Show("Failed to upload document.", "Error");
                }
            }
        }

        private void cmbApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e) { btnUpload_Click(sender, e); }
        private void button2_Click(object sender, EventArgs e) { new Dashboard().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new JobVacancies().Show(); this.Hide(); }
        private void button4_Click(object sender, EventArgs e) { new MyApplication().Show(); this.Hide(); }
        private void button5_Click(object sender, EventArgs e) { new ApplicationStatus().Show(); this.Hide(); }
        private void button6_Click(object sender, EventArgs e) { new MyProfile().Show(); this.Hide(); }

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