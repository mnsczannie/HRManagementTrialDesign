using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_hr_system.Forms.Applicant
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            // --- Validation ---
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Full name, email and password are required.", "Validation"); return; }

            if (txtPassword.Text != txtConfirmPassword.Text)
            { MessageBox.Show("Passwords do not match.", "Validation"); return; }

            if (txtPassword.Text.Length < 6)
            { MessageBox.Show("Password must be at least 6 characters.", "Validation"); return; }

            // --- Save to database ---
            try
            {
                bool success = SystemHelpers.RegisterApplicant(
                    txtFullName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text,
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    dtpBirthdate.Value,
                    cmbGender.Text,
                    txtCity.Text.Trim(),
                    txtProvince.Text.Trim(),
                    txtZip.Text.Trim(),
                    txtSchool.Text.Trim(),
                    txtDegree.Text.Trim(),
                    txtYearGrad.Text.Trim(),
                    txtSkills.Text.Trim(),
                    txtCompany.Text.Trim(),
                    txtPosition.Text.Trim(),
                    txtDuration.Text.Trim()
                );

                if (success)
                {
                    MessageBox.Show("Account created successfully! You may now log in.",
                        "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogIn login = new LogIn();
                    login.Show();
                    this.Hide();
                }
                else
                { MessageBox.Show("Registration failed. Email may already be in use.", "Error"); }
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Database Error"); }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
