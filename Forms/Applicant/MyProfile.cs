using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system.Forms.Applicant
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            SystemHelpers.DebugSession();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
            // SAFETY CHECK
            if (SystemHelpers.CurrentApplicantId <= 0)
            {
                MessageBox.Show("No logged-in applicant detected.");
                this.Close();
                return;
            }

            LoadProfile();
            CheckEditLock();

            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void LoadProfile()
        {
            var dt = SystemHelpers.GetApplicantById(SystemHelpers.CurrentApplicantId);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Profile not found.");
                return;
            }

            DataRow r = dt.Rows[0];

            txtFullName.Text = r["full_name"].ToString();
            txtEmail.Text = r["email"].ToString();
            txtPhone.Text = r["phone"].ToString();
            txtAddress.Text = r["address"].ToString();
            txtCity.Text = r["city"].ToString();
            txtProvince.Text = r["province"].ToString();
            txtZip.Text = r["zip_code"].ToString();
            txtSchool.Text = r["school"].ToString();
            txtDegree.Text = r["degree"].ToString();
            txtYearGrad.Text = r["year_grad"].ToString();
            txtSkills.Text = r["skills"].ToString();
            txtCompany.Text = r["company"].ToString();
            txtPosition.Text = r["position"].ToString();
            txtDuration.Text = r["duration"].ToString();

            if (r["birthdate"] != DBNull.Value)
                dtpBirthdate.Value = Convert.ToDateTime(r["birthdate"]);
        }

        private void CheckEditLock()
        {
            var apps = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);

            // Null guard — prevents NullReferenceException if query returns nothing
            if (apps == null) return;

            bool locked = false;

            foreach (DataRow row in apps.Rows)
            {
                string status = row["status"].ToString();

                if (status != "draft" && status != "submitted")
                {
                    locked = true;
                    break;
                }
            }

            if (locked)
            {
                // Recursive disable — covers controls nested inside panels/groupboxes
                SetControlsEnabled(this, false);

                btnSaveProfile.Enabled = false;

                lblLockNotice.Visible = true;
                lblLockNotice.Text = "Your profile is locked while your application is under HR review.";
                lblLockNotice.ForeColor = Color.Red;
            }
        }

        // Walks the full control tree so nested panels are handled correctly
        private void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    c.Enabled = enabled;

                if (c.HasChildren)
                    SetControlsEnabled(c, enabled);
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (SystemHelpers.CurrentApplicantId <= 0)
            {
                MessageBox.Show("Session error. Please log in again.");
                return;
            }

            bool success = SystemHelpers.UpdateApplicantProfile(
                SystemHelpers.CurrentApplicantId,
                txtFullName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPhone.Text.Trim(),
                txtAddress.Text.Trim(),
                txtCity.Text.Trim(),
                txtProvince.Text.Trim(),
                txtZip.Text.Trim(),
                dtpBirthdate.Value,
                txtSchool.Text.Trim(),
                txtDegree.Text.Trim(),
                txtYearGrad.Text.Trim(),
                txtSkills.Text.Trim(),
                txtCompany.Text.Trim(),
                txtPosition.Text.Trim(),
                txtDuration.Text.Trim()
            );

            if (success)
                MessageBox.Show("Profile saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to save profile. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ── NAVIGATION BUTTONS ───────────────────────────────────────────────

        private void button2_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new JobVacancies().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MyApplication().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ApplicationStatus().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new MyDocuments().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SystemHelpers.Logout();
            new LogIn().Show();
            this.Hide();
        }

        // ── LIVE CLOCK ───────────────────────────────────────────────────────

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }
    }
}