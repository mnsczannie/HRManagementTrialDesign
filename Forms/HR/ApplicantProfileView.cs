using System;
using System.Data;
using System.Windows.Forms;

namespace trial_hr_system.Forms.HR
{
    public class ApplicantProfileView : Form
    {
        private int _applicantId;

        public ApplicantProfileView(int applicantId)
        {
            _applicantId = applicantId;
            InitializeProfileView();
        }

        private void InitializeProfileView()
        {
            this.Text = "Applicant Profile";
            this.Size = new System.Drawing.Size(700, 600);
            this.BackColor = System.Drawing.Color.Ivory;
            this.StartPosition = FormStartPosition.CenterParent;

            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false
            };

            var dt = SystemHelpers.GetApplicantById(_applicantId);
            if (dt != null && dt.Rows.Count > 0)
            {
                // Display as name-value pairs
                var display = new DataTable();
                display.Columns.Add("Field");
                display.Columns.Add("Value");
                DataRow r = dt.Rows[0];
                foreach (DataColumn col in dt.Columns)
                    display.Rows.Add(col.ColumnName, r[col.ColumnName]?.ToString() ?? "");
                dgv.DataSource = display;
            }

            this.Controls.Add(dgv);
        }
    }
}