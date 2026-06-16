using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trial_hr_system.Forms.Applicant;
namespace trial_hr_system.Forms.Applicant
{
    public partial class MyProfile : Form
    {

        public MyProfile()
        {
            InitializeComponent();
        }
        private void MyProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
            CheckEditLock();
        }

        private void CheckEditLock()
        {
            // Check if any of the applicant's applications are under review or beyond
            var apps = SystemHelpers.GetApplicationsByApplicant(SystemHelpers.CurrentApplicantId);
            bool locked = false;
            foreach (DataRow row in apps.Rows)
            {
                string s = row["status"].ToString();
                if (s != "draft" && s != "submitted") { locked = true; break; }
            }

            if (locked)
            {
                // Disable all editable controls
                foreach (Control c in this.Controls)
                    if (c is TextBox || c is ComboBox || c is DateTimePicker)
                        c.Enabled = false;
                btnSaveProfile.Enabled = false;
                lblLockNotice.Visible = true;
                lblLockNotice.Text = "Your profile is locked while your application is under HR review.";
                lblLockNotice.ForeColor = Color.Red;
            }
        }

        private void LoadProfile()
        {
            var dt = SystemHelpers.GetApplicantById(SystemHelpers.CurrentApplicantId);
            if (dt.Rows.Count == 0) return;
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

        private void button3_Click(object sender, EventArgs e)
        {
            JobVacancies dash = new JobVacancies();
            dash.Show();

            this.Hide();
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
