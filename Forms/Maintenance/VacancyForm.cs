using System;
using System.Data;
using System.Windows.Forms;

namespace trial_hr_system.Forms.Maintenance
{
    public class VacancyForm : Form
    {
        private int _vacancyId;
        private TextBox txtJobTitle, txtDepartment, txtDescription, txtQualifications, txtRequiredDocs;
        private NumericUpDown numSlots;

        public string JobTitle => txtJobTitle.Text.Trim();
        public string Department => txtDepartment.Text.Trim();
        public string Description => txtDescription.Text.Trim();
        public string Qualifications => txtQualifications.Text.Trim();
        public int Slots => (int)numSlots.Value;
        public string RequiredDocuments => txtRequiredDocs.Text.Trim();

        public VacancyForm(int vacancyId = 0)
        {
            _vacancyId = vacancyId;
            BuildForm();
            if (_vacancyId > 0) LoadExisting();
        }

        private void BuildForm()
        {
            this.Text = _vacancyId == 0 ? "Add Vacancy" : "Edit Vacancy";
            this.Size = new System.Drawing.Size(500, 500);
            this.BackColor = System.Drawing.Color.Ivory;
            this.StartPosition = FormStartPosition.CenterParent;

            int y = 20, lx = 10, tx = 150, w = 300, h = 25, gap = 40;

            AddField("Job Title:", ref y, lx, tx, w, h, gap, out txtJobTitle);
            AddField("Department:", ref y, lx, tx, w, h, gap, out txtDepartment);
            AddField("Description:", ref y, lx, tx, w, h, gap, out txtDescription, multiline: true);
            AddField("Qualifications:", ref y, lx, tx, w, h, gap, out txtQualifications, multiline: true);
            AddField("Required Docs:", ref y, lx, tx, w, h, gap, out txtRequiredDocs, multiline: true);

            var lblSlots = new Label { Text = "Slots:", Location = new System.Drawing.Point(lx, y), AutoSize = true };
            numSlots = new NumericUpDown { Location = new System.Drawing.Point(tx, y), Minimum = 1, Maximum = 100, Value = 1, Width = 60 };
            this.Controls.Add(lblSlots);
            this.Controls.Add(numSlots);
            y += gap;

            var btnOK = new Button
            {
                Text = "Save",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(tx, y),
                Size = new System.Drawing.Size(80, 30),
                BackColor = System.Drawing.Color.SaddleBrown,
                ForeColor = System.Drawing.Color.White
            };
            btnOK.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(JobTitle))
                { MessageBox.Show("Job title is required."); this.DialogResult = DialogResult.None; return; }
            };

            var btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new System.Drawing.Point(tx + 90, y),
                Size = new System.Drawing.Size(80, 30)
            };

            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void AddField(string label, ref int y, int lx, int tx, int w, int h, int gap,
            out TextBox txt, bool multiline = false)
        {
            var lbl = new Label { Text = label, Location = new System.Drawing.Point(lx, y + 3), AutoSize = true };
            txt = new TextBox
            {
                Location = new System.Drawing.Point(tx, y),
                Size = new System.Drawing.Size(w, multiline ? 60 : h),
                Multiline = multiline
            };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            y += multiline ? 70 : gap;
        }

        private void LoadExisting()
        {
            var dt = SystemHelpers.GetVacancyById(_vacancyId);
            if (dt == null || dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];
            txtJobTitle.Text = r["job_title"].ToString();
            txtDepartment.Text = r["department"].ToString();
            txtDescription.Text = r["description"].ToString();
            txtQualifications.Text = r["qualifications"].ToString();
            txtRequiredDocs.Text = r["required_documents"].ToString();
            numSlots.Value = Convert.ToInt32(r["slots"]);
        }
    }
}