using System;
using System.Windows.Forms;

namespace trial_hr_system
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // Initialize assigned labels safely to prevent blank values on user view load
            lblUserName.Text = $"User: {SystemHelpers.CurrentUserName}";
            lblUserRole.Text = $"Role: {SystemHelpers.CurrentUserRole}";
            lblTime.Text = $"Timestamp: {DateTime.Now.ToShortTimeString()}";

            cmbReportType.SelectedIndex = 0;
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbReportType.SelectedIndex)
            {
                case 0:
                    dgvReport.DataSource = SystemHelpers.GetApplicantListReport();
                    break;
                case 1:
                    dgvReport.DataSource = SystemHelpers.GetJobVacanciesReport();
                    break;
                case 2:
                    dgvReport.DataSource = SystemHelpers.GetInterviewEvaluationsReport();
                    break;
                case 3:
                    dgvReport.DataSource = SystemHelpers.GetHiringDecisionsReport();
                    break;
            }
        }
    }
}