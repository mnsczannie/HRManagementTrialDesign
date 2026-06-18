using System;
using System.Windows.Forms;
using trial_hr_system.Forms.Maintenance;

namespace trial_hr_system.Forms.HR
{
    public partial class HRDashboard : Form
    {
        public HRDashboard()
        {
            InitializeComponent();
        }

        private void HRDashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SystemHelpers.CurrentUserName;
            lblUserRole.Text = SystemHelpers.CurrentUserRole?.ToUpper() ?? "HR";
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e) { /* Already on dashboard */ }
        private void button3_Click(object sender, EventArgs e) { new ApplicantReview().Show(); this.Hide(); }
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