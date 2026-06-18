using System;
using System.Windows.Forms;

namespace trial_hr_system
{
    public partial class Screening : Form
    {
        private int applicationId;

        public Screening(int appId, string applicantName)
        {
            InitializeComponent();
            this.applicationId = appId;
            this.Text = $"Screening Assessment - {applicantName}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result = cmbResult.SelectedItem?.ToString() ?? "Passed";
            string remarks = txtRemarks.Text.Trim();

            if (SystemHelpers.SaveScreeningResult(applicationId, result, remarks))
            {
                string targetStatus = (result == "Passed") ? "screened_passed" : "rejected";
                SystemHelpers.UpdateApplicationStatus(applicationId, targetStatus, $"Screening complete: {result}");

                MessageBox.Show("Screening logged successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Tells the main dashboard to refresh
                this.Close();
            }
        }
    }
}