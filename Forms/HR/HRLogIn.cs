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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace trial_hr_system.Forms.HR
{
    public partial class HRLogIn : Form
    {
        public HRLogIn()
        {
            InitializeComponent();
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
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            {
                Check credentials from database

                if (ValidLogin(email, password))
                {
                    if (selectedRole == "Admin")
                    {
                        HRDashboard admin = new HRDashboard();
                        admin.Show();
                    }
                    else if (selectedRole == "HRStaff")
                    {
                        HRDashboard hr = new HRDashboard();
                        hr.Show();
                    }
                    else if (selectedRole == "Manager")
                    {
                        HRDashboard manager = new HRDashboard();
                        manager.Show();
                    }

                    this.Hide();
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
    }
}
