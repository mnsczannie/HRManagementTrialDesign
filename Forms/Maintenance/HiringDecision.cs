using System;
using System.Windows.Forms;

namespace trial_hr_system
{
    public partial class HiringDecisions : Form
    {
        private int applicationId;

        public HiringDecisions(int appId, string applicantName)
        {
            InitializeComponent();
            this.applicationId = appId;
            this.Text = $"Final Choice - {applicantName}";
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            string decision = cmbDecision.SelectedItem?.ToString() ?? "Hired";
            string remarks = txtRemarks.Text.Trim();

            if (SystemHelpers.SaveHiringDecision(applicationId, decision, remarks))
            {
                string globalAppStatus = (decision == "Hired") ? "offered" : "rejected";
                SystemHelpers.UpdateApplicationStatus(applicationId, globalAppStatus, $"Executive Action: {decision}");

                MessageBox.Show("Final determination applied to profile status.", "Process Terminated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}