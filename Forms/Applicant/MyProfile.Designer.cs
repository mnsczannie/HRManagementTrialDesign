namespace trial_hr_system.Forms.Applicant
{
    partial class MyProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── existing decorative / nav controls ──────────────────────────
            this.lblTime = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLockNotice = new System.Windows.Forms.Label();
            this.btnSaveProfile = new System.Windows.Forms.Button();

            // ── NEW: profile form panel and all input controls ───────────────
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblSchool = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.lblYearGrad = new System.Windows.Forms.Label();
            this.txtYearGrad = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();

            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();

            // ── lblTime ──────────────────────────────────────────────────────
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Patrick Hand", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTime.Location = new System.Drawing.Point(925, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 36);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "lblTime";

            // ── button8 ──────────────────────────────────────────────────────
            this.button8.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button8.Font = new System.Drawing.Font("Patrick Hand", 11.25F);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(364, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 40);
            this.button8.TabIndex = 30;
            this.button8.Text = "View Details";
            this.button8.UseVisualStyleBackColor = false;

            // ── button1 ──────────────────────────────────────────────────────
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Patrick Hand", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(361, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Upload Now";
            this.button1.UseVisualStyleBackColor = false;

            // ── textBox6 (decorative "MAIN" label) ───────────────────────────
            this.textBox6.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.textBox6.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox6.Location = new System.Drawing.Point(19, 230);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(38, 26);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "MAIN";

            // ── label2 ───────────────────────────────────────────────────────
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Patrick Hand", 12F);
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Upload your missing documents";

            // ── label1 ───────────────────────────────────────────────────────
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Patrick Hand", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Action Required";

            // ── panel5 ───────────────────────────────────────────────────────
            this.panel5.BackColor = System.Drawing.Color.Coral;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(351, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 100);
            this.panel5.TabIndex = 33;

            // ── panel6 ───────────────────────────────────────────────────────
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.Controls.Add(this.button8);
            this.panel6.Location = new System.Drawing.Point(860, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(488, 100);
            this.panel6.TabIndex = 32;

            // ── textBox4 (decorative "MY PROFILE" heading) ───────────────────
            this.textBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(13, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 41);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "MY PROFILE";

            // ── panel4 (top header bar) ───────────────────────────────────────
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(338, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(1028, 58);
            this.panel4.TabIndex = 31;

            // ── button2 (Dashboard nav) ───────────────────────────────────────
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 50);
            this.button2.TabIndex = 39;
            this.button2.Text = "      Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // ── lblUserName / lblUserRole ──────────────────────────────────────
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Patrick Hand", 15.75F);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(172, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(136, 29);
            this.lblUserName.TabIndex = 39;
            this.lblUserName.Text = "Zanne Antonette";

            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Patrick Hand", 12F);
            this.lblUserRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserRole.Location = new System.Drawing.Point(200, 53);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(77, 22);
            this.lblUserRole.TabIndex = 40;
            this.lblUserRole.Text = "APPLICANT";

            // ── nav buttons ───────────────────────────────────────────────────
            this.button7.BackColor = System.Drawing.Color.Goldenrod;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 521);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(317, 50);
            this.button7.TabIndex = 42;
            this.button7.Text = "      My Documents";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);

            this.button6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button6.Font = new System.Drawing.Font("Patrick Hand", 15.75F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(0, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(317, 50);
            this.button6.TabIndex = 41;
            this.button6.Text = "      My Profile";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;

            this.button5.BackColor = System.Drawing.Color.Goldenrod;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(317, 50);
            this.button5.TabIndex = 42;
            this.button5.Text = "      Application Status";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(317, 50);
            this.button4.TabIndex = 41;
            this.button4.Text = "      My Application";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 50);
            this.button3.TabIndex = 40;
            this.button3.Text = "      Job Vacancies";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // ── decorative textboxes ──────────────────────────────────────────
            this.textBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Patrick Hand", 14.25F);
            this.textBox3.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox3.Location = new System.Drawing.Point(19, 460);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 26);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "PROFILE";

            this.textBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(112, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "C-ARTPROJECT_G7";

            this.textBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Amatic SC", 24F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(117, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C-ARTPROJECT_G7";

            // ── panel3 (user info footer in sidebar) ──────────────────────────
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.lblUserName);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.lblUserRole);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Location = new System.Drawing.Point(-2, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 100);
            this.panel3.TabIndex = 39;

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

            this.pictureBox7.BackgroundImage = global::trial_hr_system.Properties.Resources.cato1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(-48, -47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(249, 169);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;

            // ── picture boxes ─────────────────────────────────────────────────
            this.pictureBox1.BackgroundImage = global::trial_hr_system.Properties.Resources.projectlog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;

            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::trial_hr_system.Properties.Resources.snoop_removebg_preview__2_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-72, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;

            this.pictureBox3.BackgroundImage = global::trial_hr_system.Properties.Resources.cato1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-49, 550);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 169);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;

            // ── panel2 (sidebar) ──────────────────────────────────────────────
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.button7);
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
            this.panel2.Location = new System.Drawing.Point(8, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 709);
            this.panel2.TabIndex = 30;

            // ── panel1 (sidebar background) ───────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(332, 736);
            this.panel1.TabIndex = 29;

            // ── timer1 ────────────────────────────────────────────────────────
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // ── lblLockNotice ─────────────────────────────────────────────────
            this.lblLockNotice.AutoSize = true;
            this.lblLockNotice.Font = new System.Drawing.Font("Patrick Hand", 10F);
            this.lblLockNotice.ForeColor = System.Drawing.Color.Red;
            this.lblLockNotice.Location = new System.Drawing.Point(355, 205);
            this.lblLockNotice.Name = "lblLockNotice";
            this.lblLockNotice.Size = new System.Drawing.Size(35, 13);
            this.lblLockNotice.TabIndex = 34;
            this.lblLockNotice.Text = "";
            this.lblLockNotice.Visible = false;

            // ── btnSaveProfile ────────────────────────────────────────────────
            this.btnSaveProfile.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSaveProfile.Font = new System.Drawing.Font("Patrick Hand", 12F);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(870, 650);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(150, 40);
            this.btnSaveProfile.TabIndex = 35;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);

            // ══════════════════════════════════════════════════════════════════
            // NEW PROFILE INPUT PANEL
            // Layout: 2 columns inside panelProfile, starting at x=355, y=200
            // ══════════════════════════════════════════════════════════════════
            int px = 10, py = 10, lw = 120, tw = 220, th = 26, gap = 38;
            int col2x = lw + tw + 30; // second column x offset inside panel

            // Helper locals — personal info (left column)
            SetField(this.lblFullName, this.txtFullName, "Full Name", px, py + gap * 0, lw, tw, th);
            SetField(this.lblEmail, this.txtEmail, "Email", px, py + gap * 1, lw, tw, th);
            SetField(this.lblPhone, this.txtPhone, "Phone", px, py + gap * 2, lw, tw, th);
            SetField(this.lblAddress, this.txtAddress, "Address", px, py + gap * 3, lw, tw, th);
            SetField(this.lblCity, this.txtCity, "City", px, py + gap * 4, lw, tw, th);
            SetField(this.lblProvince, this.txtProvince, "Province", px, py + gap * 5, lw, tw, th);
            SetField(this.lblZip, this.txtZip, "Zip Code", px, py + gap * 6, lw, tw, th);

            // Birthdate (DateTimePicker)
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Patrick Hand", 10F);
            this.lblBirthdate.Location = new System.Drawing.Point(px, py + gap * 7);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Text = "Birthdate";
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(px + lw, py + gap * 7);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(tw, th);

            // Education (right column)
            SetField(this.lblSchool, this.txtSchool, "School", col2x, py + gap * 0, lw, tw, th);
            SetField(this.lblDegree, this.txtDegree, "Degree", col2x, py + gap * 1, lw, tw, th);
            SetField(this.lblYearGrad, this.txtYearGrad, "Year Grad", col2x, py + gap * 2, lw, tw, th);
            SetField(this.lblSkills, this.txtSkills, "Skills", col2x, py + gap * 3, lw, tw, th);

            // Work experience (right column continued)
            SetField(this.lblCompany, this.txtCompany, "Company", col2x, py + gap * 4, lw, tw, th);
            SetField(this.lblPosition, this.txtPosition, "Position", col2x, py + gap * 5, lw, tw, th);
            SetField(this.lblDuration, this.txtDuration, "Duration", col2x, py + gap * 6, lw, tw, th);

            // panelProfile container
            this.panelProfile.BackColor = System.Drawing.Color.Ivory;
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfile.Controls.Add(this.lblFullName);
            this.panelProfile.Controls.Add(this.txtFullName);
            this.panelProfile.Controls.Add(this.lblEmail);
            this.panelProfile.Controls.Add(this.txtEmail);
            this.panelProfile.Controls.Add(this.lblPhone);
            this.panelProfile.Controls.Add(this.txtPhone);
            this.panelProfile.Controls.Add(this.lblAddress);
            this.panelProfile.Controls.Add(this.txtAddress);
            this.panelProfile.Controls.Add(this.lblCity);
            this.panelProfile.Controls.Add(this.txtCity);
            this.panelProfile.Controls.Add(this.lblProvince);
            this.panelProfile.Controls.Add(this.txtProvince);
            this.panelProfile.Controls.Add(this.lblZip);
            this.panelProfile.Controls.Add(this.txtZip);
            this.panelProfile.Controls.Add(this.lblBirthdate);
            this.panelProfile.Controls.Add(this.dtpBirthdate);
            this.panelProfile.Controls.Add(this.lblSchool);
            this.panelProfile.Controls.Add(this.txtSchool);
            this.panelProfile.Controls.Add(this.lblDegree);
            this.panelProfile.Controls.Add(this.txtDegree);
            this.panelProfile.Controls.Add(this.lblYearGrad);
            this.panelProfile.Controls.Add(this.txtYearGrad);
            this.panelProfile.Controls.Add(this.lblSkills);
            this.panelProfile.Controls.Add(this.txtSkills);
            this.panelProfile.Controls.Add(this.lblCompany);
            this.panelProfile.Controls.Add(this.txtCompany);
            this.panelProfile.Controls.Add(this.lblPosition);
            this.panelProfile.Controls.Add(this.txtPosition);
            this.panelProfile.Controls.Add(this.lblDuration);
            this.panelProfile.Controls.Add(this.txtDuration);
            this.panelProfile.Location = new System.Drawing.Point(355, 200);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(990, 430);
            this.panelProfile.TabIndex = 36;

            // ── Form ──────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.lblLockNotice);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);

            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Helper: positions a label+textbox pair inside a parent panel
        private void SetField(System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt,
                              string caption, int x, int y, int lw, int tw, int th)
        {
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Patrick Hand", 10F);
            lbl.Location = new System.Drawing.Point(x, y + 4);
            lbl.Text = caption;

            txt.Font = new System.Drawing.Font("Patrick Hand", 10F);
            txt.Location = new System.Drawing.Point(x + lw, y);
            txt.Size = new System.Drawing.Size(tw, th);
            txt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        #endregion

        // ── existing controls ────────────────────────────────────────────────
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLockNotice;
        private System.Windows.Forms.Button btnSaveProfile;

        // ── NEW profile input controls ───────────────────────────────────────
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label lblYearGrad;
        private System.Windows.Forms.TextBox txtYearGrad;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
    }
}