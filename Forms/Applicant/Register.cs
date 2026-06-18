using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system.Forms.Applicant
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // ── FORM LOAD ────────────────────────────────────────────────────────
        private void Register_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
            // FIX #1: Populate gender dropdown (was empty in Designer)
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Prefer not to say" });
            cmbGender.SelectedIndex = 0;



            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        // ── REGISTER BUTTON ──────────────────────────────────────────────────
        private void Dashboard_Click(object sender, EventArgs e)
        {
            // FIX #3: Comprehensive validation
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            { MessageBox.Show("Full name is required.", "Validation"); return; }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text.Trim()))
            { MessageBox.Show("A valid email address is required.", "Validation"); return; }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            { MessageBox.Show("Phone number is required.", "Validation"); return; }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Password is required.", "Validation"); return; }

            // FIX #4: Match the 8-character hint shown in the UI
            if (txtPassword.Text.Length < 8)
            { MessageBox.Show("Password must be at least 8 characters.", "Validation"); return; }

            if (txtPassword.Text != txtConfirmPassword.Text)
            { MessageBox.Show("Passwords do not match.", "Validation"); return; }

            // --- Save to database ---
            try
            {
                bool success = SystemHelpers.RegisterApplicant(
                    txtFullName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text,
                    txtPhone.Text.Trim(),
                    dtpBirthdate.Value,
                    cmbGender.Text
                
                );

                if (success)
                {
                    MessageBox.Show("Account created successfully! You may now log in.",
                        "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new LogIn().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Email may already be in use.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── NAVIGATION ───────────────────────────────────────────────────────
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        // ── LIVE CLOCK ───────────────────────────────────────────────────────
        // FIX #5: Match date+time format used across all other forms
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt");
        }

        // ── UNUSED STUBS (kept to satisfy Designer event bindings) ────────────
        private void textBox14_TextChanged(object sender, EventArgs e) { }
        private void textBox22_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }

        // ── HELPER ───────────────────────────────────────────────────────────
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}