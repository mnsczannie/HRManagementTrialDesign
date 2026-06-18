namespace trial_hr_system
{
    partial class InterviewEvaluation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblRec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(30, 45);
            this.numScore.Size = new System.Drawing.Size(100, 23);
            // 
            // cmbResult
            // 
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.Items.AddRange(new object[] { "Passed", "Failed", "Hold" });
            this.cmbResult.Location = new System.Drawing.Point(150, 45);
            this.cmbResult.Size = new System.Drawing.Size(130, 23);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(30, 105);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Size = new System.Drawing.Size(250, 60);
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(30, 195);
            this.txtRec.Multiline = true;
            this.txtRec.Size = new System.Drawing.Size(250, 60);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 270);
            this.btnSave.Size = new System.Drawing.Size(250, 35);
            this.btnSave.Text = "Commit Scorecard";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(30, 25);
            this.lblScore.Text = "Score (0-100) / Decision:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(30, 85);
            this.lblRemarks.Text = "Notes:";
            // 
            // lblRec
            // 
            this.lblRec.Location = new System.Drawing.Point(30, 175);
            this.lblRec.Text = "Recommendation:";
            // 
            // InterviewEvaluation
            // 
            this.ClientSize = new System.Drawing.Size(314, 331);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.numScore);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblRec;
    }
}