namespace trial_hr_system
{
    partial class Screening
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbResult
            // 
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.Items.AddRange(new object[] { "Passed", "Failed" });
            this.cmbResult.Location = new System.Drawing.Point(30, 45);
            this.cmbResult.Size = new System.Drawing.Size(200, 23);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(30, 105);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Size = new System.Drawing.Size(320, 100);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 220);
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.Text = "Save Assessment";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(30, 25);
            this.lblResult.Text = "Screening Result:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(30, 85);
            this.lblRemarks.Text = "Reviewer Remarks:";
            // 
            // Screening
            // 
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmbResult);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRemarks;
    }
}