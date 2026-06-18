using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace trial_hr_system.Forms.Applicant
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "APPLICANT";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
            LoadDashboardAlerts();
        }

        private void LoadDashboardAlerts()
        {
            if (SystemHelpers.CurrentApplicantId <= 0) return;

            // Missing documents alert
            var missing = SystemHelpers.GetMissingDocumentCount(SystemHelpers.CurrentApplicantId);
            if (missing > 0)
            {
                panel5.Visible = true;
                label2.Text = $"You have {missing} missing document(s). Upload now to continue.";
                button1.Click -= button1_UploadNow_Click;
                button1.Click += button1_UploadNow_Click;
            }
            else
            {
                panel5.Visible = false;
            }

            // Interview schedule alert (panel6 - green)
            var schedule = SystemHelpers.GetUpcomingInterview(SystemHelpers.CurrentApplicantId);
            if (schedule != null)
            {
                panel6.Visible = true;
                // Show interview info if you have a label in panel6; otherwise just show the panel
                button8.Click -= button8_ViewDetails_Click;
                button8.Click += button8_ViewDetails_Click;
            }
            else
            {
                panel6.Visible = false;
            }
        }

        private void button1_UploadNow_Click(object sender, EventArgs e)
        {
            MyDocuments dash = new MyDocuments();
            dash.Show();
            this.Hide();
        }

        private void button8_ViewDetails_Click(object sender, EventArgs e)
        {
            ApplicationStatus dash = new ApplicationStatus();
            dash.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Already on dashboard
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

        private void button6_Click(object sender, EventArgs e)
        {
            new MyProfile().Show();
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

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void lblUserRole_Click(object sender, EventArgs e) { }
    }
}