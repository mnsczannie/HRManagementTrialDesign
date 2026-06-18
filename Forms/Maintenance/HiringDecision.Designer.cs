namespace trial_hr_system
{
    partial class HiringDecisions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDecision
            // 
            this.cmbDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecision.Items.AddRange(new object[] { "Hired", "Rejected" });
            this.cmbDecision.Location = new System.Drawing.Point(30, 45);
            this.cmbDecision.Size = new System.Drawing.Size(200, 23);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(30, 105);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Size = new System.Drawing.Size(320, 100);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(30, 220);
            this.btnFinalize.Size = new System.Drawing.Size(150, 35);
            this.btnFinalize.Text = "Save Final Decision";
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblDecision
            // 
            this.lblDecision.Location = new System.Drawing.Point(30, 25);
            this.lblDecision.Text = "Hiring Executive Choice:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(30, 85);
            this.lblRemarks.Text = "Contract/Offer Terms Notes:";
            // 
            // HiringDecisions
            // 
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmbDecision);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbDecision;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lblRemarks;
    }
}