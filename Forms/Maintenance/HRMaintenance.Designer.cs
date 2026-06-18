namespace trial_hr_system
{
    partial class HRMaintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnOpenScreening = new System.Windows.Forms.Button();
            this.btnOpenScheduling = new System.Windows.Forms.Button();
            this.btnOpenEvaluation = new System.Windows.Forms.Button();
            this.btnOpenHiring = new System.Windows.Forms.Button();
            this.lblTargetInfo = new System.Windows.Forms.Label();
            this.lblMetricApplicants = new System.Windows.Forms.Label();
            this.lblMetricPending = new System.Windows.Forms.Label();
            this.lblMetricInterviews = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.Location = new System.Drawing.Point(20, 160);
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(760, 240);
            this.dgvApplications.SelectionChanged += new System.EventHandler(this.dgvApplications_SelectionChanged);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.Location = new System.Drawing.Point(20, 440);
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedules.Size = new System.Drawing.Size(760, 130);
            this.dgvSchedules.SelectionChanged += new System.EventHandler(this.dgvSchedules_SelectionChanged);
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActions.Controls.Add(this.btnOpenScreening);
            this.pnlActions.Controls.Add(this.btnOpenScheduling);
            this.pnlActions.Controls.Add(this.btnOpenEvaluation);
            this.pnlActions.Controls.Add(this.btnOpenHiring);
            this.pnlActions.Location = new System.Drawing.Point(20, 85);
            this.pnlActions.Size = new System.Drawing.Size(760, 50);
            // 
            // btnOpenScreening
            // 
            this.btnOpenScreening.Location = new System.Drawing.Point(10, 10);
            this.btnOpenScreening.Size = new System.Drawing.Size(160, 30);
            this.btnOpenScreening.Text = "1. Run Screening Form";
            this.btnOpenScreening.Click += new System.EventHandler(this.btnOpenScreening_Click);
            // 
            // btnOpenScheduling
            // 
            this.btnOpenScheduling.Location = new System.Drawing.Point(195, 10);
            this.btnOpenScheduling.Size = new System.Drawing.Size(160, 30);
            this.btnOpenScheduling.Text = "2. Open Scheduler Form";
            this.btnOpenScheduling.Click += new System.EventHandler(this.btnOpenScheduling_Click);
            // 
            // btnOpenEvaluation
            // 
            this.btnOpenEvaluation.Location = new System.Drawing.Point(380, 10);
            this.btnOpenEvaluation.Size = new System.Drawing.Size(170, 30);
            this.btnOpenEvaluation.Text = "3. Evaluate Interview Form";
            this.btnOpenEvaluation.Click += new System.EventHandler(this.btnOpenEvaluation_Click);
            // 
            // btnOpenHiring
            // 
            this.btnOpenHiring.Location = new System.Drawing.Point(580, 10);
            this.btnOpenHiring.Size = new System.Drawing.Size(170, 30);
            this.btnOpenHiring.Text = "4. Final Decision Form";
            this.btnOpenHiring.Click += new System.EventHandler(this.btnOpenHiring_Click);
            // 
            // lblTargetInfo
            // 
            this.lblTargetInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTargetInfo.Location = new System.Drawing.Point(20, 140);
            this.lblTargetInfo.Size = new System.Drawing.Size(500, 20);
            this.lblTargetInfo.Text = "Working Target Profile ID: None Selected";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Location = new System.Drawing.Point(20, 415);
            this.lblSubTitle.Text = "Linked Application Interviews Ledger:";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lblMetricApplicants);
            this.pnlTop.Controls.Add(this.lblMetricPending);
            this.pnlTop.Controls.Add(this.lblMetricInterviews);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(800, 70);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(680, 20);
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblMetricApplicants
            // 
            this.lblMetricApplicants.ForeColor = System.Drawing.Color.White;
            this.lblMetricApplicants.Location = new System.Drawing.Point(20, 25);
            this.lblMetricApplicants.Text = "Profiles: --";
            // 
            // lblMetricPending
            // 
            this.lblMetricPending.ForeColor = System.Drawing.Color.White;
            this.lblMetricPending.Location = new System.Drawing.Point(180, 25);
            this.lblMetricPending.Text = "Pending: --";
            // 
            // lblMetricInterviews
            // 
            this.lblMetricInterviews.ForeColor = System.Drawing.Color.White;
            this.lblMetricInterviews.Location = new System.Drawing.Point(340, 25);
            this.lblMetricInterviews.Text = "Interviews: --";
            // 
            // HRMaintenance
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTargetInfo);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HRMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Pipeline Dashboard";
            this.Load += new System.EventHandler(this.HRMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnOpenScreening;
        private System.Windows.Forms.Button btnOpenScheduling;
        private System.Windows.Forms.Button btnOpenEvaluation;
        private System.Windows.Forms.Button btnOpenHiring;
        private System.Windows.Forms.Label lblTargetInfo;
        private System.Windows.Forms.Label lblMetricApplicants;
        private System.Windows.Forms.Label lblMetricPending;
        private System.Windows.Forms.Label lblMetricInterviews;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSubTitle;
    }
}