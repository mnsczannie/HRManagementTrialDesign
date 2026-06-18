using System;
using System.Windows.Forms;
using trial_hr_system.Helpers;

namespace trial_hr_system
{
    public partial class InterviewEvaluation : Form
    {
        private int applicationId;
        private int scheduleId;

        public InterviewEvaluation(int appId, int schedId, string applicantName)
        {
            InitializeComponent();
            this.applicationId = appId;
            this.scheduleId = schedId;
            this.Text = $"Evaluate: {applicantName}";
        }
        private void InterviewEvaluation_Load(object sender, EventArgs e)
        {
            UIHelper.ScaleControls(this, 1386f, 788f);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal score = numScore.Value;
            string remarks = txtRemarks.Text.Trim();
            string result = cmbResult.SelectedItem?.ToString() ?? "Passed";
            string recommendation = txtRec.Text.Trim();

            if (SystemHelpers.SaveEvaluation(scheduleId, applicationId, score, remarks, result, recommendation))
            {
                SystemHelpers.UpdateInterviewStatus(scheduleId, "completed");
                SystemHelpers.UpdateApplicationStatus(applicationId, "evaluated", $"Scored: {score}");

                MessageBox.Show("Evaluation metrics captured.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}