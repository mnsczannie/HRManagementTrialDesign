using System;
using System.Windows.Forms;
using trial_hr_system.Forms.Maintenance;
using trial_hr_system.Helpers;

namespace trial_hr_system
{
    public partial class HRLogin : Form
    {
        public HRLogin()
        {
            InitializeComponent();
        }
        private void HRLogIn_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt login via helper
            if (SystemHelpers.LoginUser(email, password))
            {
                MessageBox.Show($"Welcome back, {SystemHelpers.CurrentUserName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Maintenance Dashboard and hide Login
                HRMaintenance mainDashboard = new HRMaintenance();
                mainDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}