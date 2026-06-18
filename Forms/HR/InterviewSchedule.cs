using System;
using System.Windows.Forms;

namespace trial_hr_system
{
    public partial class InterviewSchedule : Form
    {
        private int applicationId;

        public InterviewSchedule(int appId, string applicantName)
        {
            InitializeComponent();
            this.applicationId = appId;
            this.Text = $"Schedule Interview - {applicantName}";
        }

        private void InterviewSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                cmbType.DisplayMember = "label";
                cmbType.ValueMember = "interview_type_id";
                cmbType.DataSource = SystemHelpers.GetInterviewTypes();
            }
            catch { }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue == null) return;

            int typeId = Convert.ToInt32(cmbType.SelectedValue);
            DateTime date = dtpDate.Value;
            TimeSpan time = dtpTime.Value.TimeOfDay;
            string location = txtLocation.Text.Trim();
            int defaultInterviewerId = 1;

            if (SystemHelpers.ScheduleInterview(applicationId, defaultInterviewerId, typeId, date, time, location))
            {
                SystemHelpers.UpdateApplicationStatus(applicationId, "interview_scheduled", "Interview setup verified.");
                MessageBox.Show("Interview has been scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}