namespace trial_hr_system.Forms.Applicant
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();

            // timer1
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // panel1
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 736);
            this.panel1.TabIndex = 23;

            // panel2
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(8, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 709);
            this.panel2.TabIndex = 24;

            // button2 - Dashboard (highlighted)
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Patrick Hand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 50);
            this.button2.TabIndex = 39;
            this.button2.Text = "      Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // textBox6
            this.textBox6.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox6.Location = new System.Drawing.Point(19, 230);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(38, 26);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "MAIN";

            // button7
            this.button7.BackColor = System.Drawing.Color.Goldenrod;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 521);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(317, 50);
            this.button7.TabIndex = 42;
            this.button7.Text = "      My Documents";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);

            // button6
            this.button6.BackColor = System.Drawing.Color.Goldenrod;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(0, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(317, 50);
            this.button6.TabIndex = 41;
            this.button6.Text = "      My Profile";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // button5
            this.button5.BackColor = System.Drawing.Color.Goldenrod;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 50);
            this.button5.TabIndex = 42;
            this.button5.Text = "      Application Status";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // button4
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(317, 50);
            this.button4.TabIndex = 41;
            this.button4.Text = "      My Application";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // textBox3
            this.textBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox3.Location = new System.Drawing.Point(19, 460);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 26);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "PROFILE";

            // textBox2
            this.textBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(112, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "C-ARTPROJECT_G7";

            // pictureBox1
            this.pictureBox1.BackgroundImage = global::trial_hr_system.Properties.Resources.projectlog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;

            // textBox1
            this.textBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C-ARTPROJECT_G7";

            // pictureBox2
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::trial_hr_system.Properties.Resources.snoop_removebg_preview__2_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-72, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;

            // button3
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 50);
            this.button3.TabIndex = 40;
            this.button3.Text = "      Job Vacancies";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // panel3
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.lblUserRole);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Location = new System.Drawing.Point(-2, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 39;

            // lblUserName
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Patrick Hand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(172, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(136, 29);
            this.lblUserName.TabIndex = 39;
            this.lblUserName.Text = "User Name";

            // button9
            this.button9.BackColor = System.Drawing.Color.SaddleBrown;
            this.button9.BackgroundImage = global::trial_hr_system.Properties.Resources.projectlog;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(135, -2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 56);
            this.button9.TabIndex = 29;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);

            // lblUserRole
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Patrick Hand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserRole.Location = new System.Drawing.Point(200, 53);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(77, 22);
            this.lblUserRole.TabIndex = 40;
            this.lblUserRole.Text = "APPLICANT";
            this.lblUserRole.Click += new System.EventHandler(this.lblUserRole_Click);

            // pictureBox7
            this.pictureBox7.BackgroundImage = global::trial_hr_system.Properties.Resources.cato1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(-48, -47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(249, 169);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;

            // pictureBox3
            this.pictureBox3.BackgroundImage = global::trial_hr_system.Properties.Resources.cato1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-49, 550);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 169);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;

            // panel4
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(338, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 58);
            this.panel4.TabIndex = 25;

            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Patrick Hand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTime.Location = new System.Drawing.Point(925, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 36);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "lblTime";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);

            // textBox4
            this.textBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(13, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 41);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "DASHBOARD";

            // panel6
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.Controls.Add(this.button8);
            this.panel6.Location = new System.Drawing.Point(860, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(488, 100);
            this.panel6.TabIndex = 27;
            this.panel6.Visible = false;

            // button8
            this.button8.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button8.Font = new System.Drawing.Font("Patrick Hand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(364, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 40);
            this.button8.TabIndex = 30;
            this.button8.Text = "View Details";
            this.button8.UseVisualStyleBackColor = false;

            // panel5
            this.panel5.BackColor = System.Drawing.Color.Coral;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(351, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 100);
            this.panel5.TabIndex = 28;
            this.panel5.Visible = false;

            // button1
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Patrick Hand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(361, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Upload Now";
            this.button1.UseVisualStyleBackColor = false;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Patrick Hand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Action Required";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Patrick Hand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Upload your missing documents";

            // Dashboard Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);

            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
    }
}