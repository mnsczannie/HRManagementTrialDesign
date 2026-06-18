namespace trial_hr_system
{
    partial class InterviewSchedule
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(30, 45);
            this.cmbType.Size = new System.Drawing.Size(250, 23);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(30, 105);
            this.dtpDate.Size = new System.Drawing.Size(120, 23);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Location = new System.Drawing.Point(160, 105);
            this.dtpTime.Size = new System.Drawing.Size(120, 23);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(30, 165);
            this.txtLocation.Size = new System.Drawing.Size(250, 23);
            this.txtLocation.Text = "Main Office / Online via Teams";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(30, 215);
            this.btnSchedule.Size = new System.Drawing.Size(250, 35);
            this.btnSchedule.Text = "Confirm Booking";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(30, 25);
            this.lblType.Text = "Interview Type:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(30, 85);
            this.lblDate.Text = "Date & Time:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(30, 145);
            this.lblLocation.Text = "Location or Meeting Link:";
            // 
            // InterviewSchedule
            // 
            this.ClientSize = new System.Drawing.Size(320, 281);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbType);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.InterviewSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
    }
}