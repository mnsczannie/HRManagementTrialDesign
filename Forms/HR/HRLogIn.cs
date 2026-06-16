using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trial_hr_system.Forms.Applicant;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace trial_hr_system.Forms.HR
{
    public partial class HRLogIn : Form
    {
        public HRLogIn()
        {
            InitializeComponent();
        }
        
        public static void RegisterUser(string name, string email, string password, string role)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = @"
        INSERT INTO users (full_name, email, password, role)
        VALUES (@name, @email, @password, @role)";
            string connString =
"Server=tcp:hr-applicant-server.database.windows.net,1433;" +
"Initial Catalog=hr_applicant_db;" +
"User ID=hradmin;" +
"Password=YOUR_NEW_PASSWORD;" +
"Encrypt=True;" +
"TrustServerCertificate=False;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private string selectedRole = "";

        private void btnAdmin_Click_Click(object sender, EventArgs e)
        {
                selectedRole = "Admin";
                Login();

        }
        private void btnHRStaff_Click_Click(object sender, EventArgs e)
        {
            selectedRole = "HRStaff";
            Login();
        }
        private void btnManager_Click_Click(object sender, EventArgs e)
        {
            selectedRole = "Manager";
            Login();
        }
        private void Login()
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            { MessageBox.Show("Enter email and password.", "Login"); return; }

            if (SystemHelpers.LoginUser(email, password))
            {
                // Role check — selectedRole comes from which button was clicked
                if (SystemHelpers.CurrentUserRole != selectedRole.ToLower()
                    && !(selectedRole == "Admin" && SystemHelpers.CurrentUserRole == "admin")
                    && !(selectedRole == "HRStaff" && SystemHelpers.CurrentUserRole == "hr_staff")
                    && !(selectedRole == "Manager" && SystemHelpers.CurrentUserRole == "hr_manager"))
                {
                    MessageBox.Show("Your account does not have the '" + selectedRole + "' role.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SystemHelpers.LogAction("LOGIN", "users", SystemHelpers.CurrentUserId);
                HRDashboard dash = new HRDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HRDashboard dash = new HRDashboard();
            dash.Show();

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnCreateAdmin_Click_Click(object sender, EventArgs e)
        {
            SystemHelpers.RegisterUser("Admin User", "admin@email.com", "admin123", "admin");
            SystemHelpers.RegisterUser("HR Staff", "hr@email.com", "hr123", "hr_staff");
            SystemHelpers.RegisterUser("HR Manager", "manager@email.com", "manager123", "hr_manager");

            MessageBox.Show("Users created!");
        }
    }
}
