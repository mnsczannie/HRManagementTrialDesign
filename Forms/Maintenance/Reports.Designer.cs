namespace trial_hr_system
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Items.AddRange(new object[] {
            "Applicant Master List",
            "Job Vacancies Summary",
            "Interview Evaluations Log",
            "Final Hiring Decisions"});
            this.cmbReportType.Location = new System.Drawing.Point(20, 60);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(250, 23);
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.Location = new System.Drawing.Point(20, 100);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(740, 410);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 15);
            this.lblUserName.Text = "User Name:";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(250, 20);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(60, 15);
            this.lblUserRole.Text = "User Role:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(500, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 15);
            this.lblTime.Text = "Time:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.cmbReportType);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Reports Engine Dashboard";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblTime;
    }
}